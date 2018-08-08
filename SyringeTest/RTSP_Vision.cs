using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SyringeTest
{
    public partial class RTSP_Vision : Form
    {
        RTSP_Cam m_rtspCam = null;
        HTTP_Cam m_httpCam = null;

        public RTSP_Vision()
        {
            InitializeComponent();
        }

        private void RTSP_Vision_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void RTSP_Vision_Load(object sender, EventArgs e)
        {
            m_rtspCam = RTSP_Cam.GetInstance();
            m_httpCam = HTTP_Cam.GetInstance();

            try
            {
                m_rtspCam.LoadIni();
                textBox_uri.Text = m_rtspCam.Uri;
                numericUpDown_timeout.Value = Convert.ToDecimal(m_rtspCam.TimeOut);
                comboBox_transport.SelectedIndex = m_rtspCam.TransPort;

                if (!m_httpCam.SetInit())
                    m_httpCam.LoadIni();

                textBox_http_ip.Text = m_httpCam.Address;
                textBox_http_stream_addr.Text = m_httpCam.StreamAddress;
                textBox_http_id.Text = m_httpCam.ID;
                textBox_http_pw.Text = m_httpCam.PW;
                numericUpDown_http_timeout.Value = Convert.ToDecimal(m_httpCam.TimeOut);

            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            } 
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                m_rtspCam.StartReadStream(textBox_uri.Text, Convert.ToInt32(numericUpDown_timeout.Value), comboBox_transport.SelectedIndex);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                m_rtspCam.StopReadStream();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void timer_status_Tick(object sender, EventArgs e)
        {
            try
            {
                //if (m_rtspCam.IsPlaying)
                {
                    textBox_status.Text = m_rtspCam.CameraStatus.ToString();
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void button_snapshot_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox_snapshot.Image = m_rtspCam.SnapShot();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        string m_strSavePath = "C:";
        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fb = new FolderBrowserDialog();
                if (fb.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    m_httpCam.SavePath = textBox_save_path.Text = m_strSavePath = fb.SelectedPath;
                    
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void button_snap_shot_Click(object sender, EventArgs e)
        {
            try
            {
                pictureBox_snap_shot.Image = m_httpCam.SnapShot();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void button_snap_continuous_Click(object sender, EventArgs e)
        {
            //if (timer_snap_continuous.Enabled)
            //    timer_snap_continuous.Stop();
            //else
            //    timer_snap_continuous.Start();

            if (m_thGrabContinuous == null)
            {
                m_bIsLiveGrabContinuous = true;
                m_thGrabContinuous = new Thread(new ThreadStart(GrabContinuous));
                m_thGrabContinuous.Start();
            }
            else
            {
                m_bIsLiveGrabContinuous = false;
            }
        }

        private void timer_snap_continuous_Tick(object sender, EventArgs e)
        {
            try
            {
                pictureBox_snap_shot.Image = m_httpCam.SnapShot();
            }
            catch (Exception E)
            {
                timer_snap_continuous.Stop();
                MessageBox.Show(E.ToString());
            }            
        }

        private void button_http_init_Click(object sender, EventArgs e)
        {
            try
            {
                bool ret = m_httpCam.SetInit(textBox_http_ip.Text, textBox_http_stream_addr.Text, Convert.ToInt32(numericUpDown_http_timeout.Value),
                                    textBox_http_id.Text, textBox_http_pw.Text);

                if (!ret)
                {
                    MessageBox.Show("Fail.");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        public Bitmap SnapShot()
        {
            return m_httpCam.SnapShot();
        }

        Thread m_thGrabContinuous = null;
        bool m_bIsLiveGrabContinuous = false;
        void GrabContinuous()
        {
            try
            {
                while (m_bIsLiveGrabContinuous)
                {
                    Thread.Sleep(5);
                    if (pictureBox_snap_shot.InvokeRequired)
                    {
                        pictureBox_snap_shot.Invoke((MethodInvoker)delegate()
                        {
                            Bitmap bitmap = m_httpCam.SnapShot();
                            if (bitmap != null)
                                pictureBox_snap_shot.Image = bitmap;
                            else
                                m_bIsLiveGrabContinuous = false;
                        });
                    }
                    else
                    {
                        Bitmap bitmap = m_httpCam.SnapShot();
                        if (bitmap != null)
                            pictureBox_snap_shot.Image = bitmap;
                        else
                            m_bIsLiveGrabContinuous = false;
                    }                    
                }

                m_thGrabContinuous = null;
            }
            catch (Exception E)
            {
                m_thGrabContinuous = null;
            }
        }
    }
}
