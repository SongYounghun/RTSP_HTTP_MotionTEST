using GalvoScanner;
using GalvoScanner.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebEye.Controls.WinForms.StreamPlayerControl;

namespace SyringeTest
{
    public class RTSP_Cam
    {
        static private RTSP_Cam m_rtsp_cam = null;
        static public RTSP_Cam GetInstance()
        {
            if (m_rtsp_cam == null)
            {
                m_rtsp_cam = new RTSP_Cam();
            }

            return m_rtsp_cam;
        }

        static public string INISECT_RTSP = "RTSP_SETTING";
        static public string INIKEY_URI = "URI";
        static public string INIKEY_TRANSPORT = "TRANS_PORT";
        static public string INIKEY_TIMEOUT = "TIMEOUT";

        private StreamPlayerControl m_streamControl = new StreamPlayerControl();

        public event EventHandler<StreamFailedEventArgs> StreamFailed;
        public event EventHandler StreamStarted;
        public event EventHandler StreamStopped;

        public enum CamStatus { None = 0, Started, Stoped, Failed, Connecting }
        private CamStatus m_camStatus = CamStatus.None;
        public CamStatus CameraStatus
        {
            get { return m_camStatus; }
        }

        private string m_strUri = "";
        public string Uri
        {
            get { return m_strUri; }
        }

        private int m_nTimeOut = 200;
        public int TimeOut
        {
            get { return m_nTimeOut; }
        }

        private int m_nTransPort = 1;
        public int TransPort
        {
            get { return m_nTransPort; }
        }

        public bool IsPlaying
        {
            get { return m_streamControl.IsPlaying; }
        }

        public RTSP_Cam()
        {
            m_streamControl.StreamFailed += new EventHandler<StreamFailedEventArgs>(HandleStreamFailedEvent);
            m_streamControl.StreamStarted += new EventHandler(HandleStreamStartedEvent);
            m_streamControl.StreamStopped += new EventHandler(HandleStreamStoppedEvent);
        }

        private void HandleStreamFailedEvent(object sender, StreamFailedEventArgs e)
        {
            if (StreamFailed != null)
            {
                StreamFailed(sender, e);
            }

            m_camStatus = CamStatus.Failed;
        }

        private void HandleStreamStartedEvent(object sender, EventArgs e)
        {
            if (StreamStarted != null)
            {
                StreamStarted(sender, e);
            }

            m_camStatus = CamStatus.Started;
        }

        private void HandleStreamStoppedEvent(object sender, EventArgs e)
        {
            if (StreamStopped != null)
            {
                StreamStopped(sender, e);
            }

            m_camStatus = CamStatus.Stoped;
        }

        public void StartReadStream(string uri, int timeout_ms, int transport = 1) //transport : 1-TCP, 2-UDP, 0-NONE
        {
            m_strUri = uri;
            m_nTimeOut = timeout_ms;
            m_nTransPort = transport;

            Uri u = new Uri(uri);
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, timeout_ms);
            RtspTransport tsport = (RtspTransport)transport;

            IniFile ini = new IniFile();
            ini.IniWriteValue(INISECT_RTSP, INIKEY_URI, uri, DefPath.VisionSetting);
            ini.IniWriteValue(INISECT_RTSP, INIKEY_TIMEOUT, timeout_ms.ToString(), DefPath.VisionSetting);
            ini.IniWriteValue(INISECT_RTSP, INIKEY_TRANSPORT, transport.ToString(), DefPath.VisionSetting);

            m_streamControl.StartPlay(u, ts, tsport, RtspFlags.None);
            m_camStatus = CamStatus.Connecting;
        }

        public void StartReadStream()
        {
            try
            {
                LoadIni();

                Uri u = new Uri(m_strUri);
                TimeSpan ts = new TimeSpan(0, 0, 0, 0, m_nTimeOut);
                RtspTransport tsport = (RtspTransport)m_nTransPort;

                m_streamControl.StartPlay(u, ts, tsport, RtspFlags.None);
                m_camStatus = CamStatus.Connecting;
            }
            catch (Exception)
            {

            }
        }

        public void StopReadStream()
        {
            try
            {
                if (m_streamControl.IsPlaying)
                {
                    m_streamControl.Stop();
                }
            }
            catch (Exception)
            {

            }
        }

        public Bitmap SnapShot()
        {
            if (m_streamControl.IsPlaying)
            {
                return m_streamControl.GetCurrentFrame();
            }

            return null;
        }

        public void LoadIni()
        {
            IniFile ini = new IniFile();
            string iniVal = "";
            iniVal = ini.IniReadValue(INISECT_RTSP, INIKEY_URI, DefPath.VisionSetting);
            if (!String.IsNullOrEmpty(iniVal)) { m_strUri = iniVal; }
            else return;
            iniVal = ini.IniReadValue(INISECT_RTSP, INIKEY_TIMEOUT, DefPath.VisionSetting);
            if (!String.IsNullOrEmpty(iniVal)) { m_nTimeOut = Convert.ToInt32(iniVal); }
            else return;
            iniVal = ini.IniReadValue(INISECT_RTSP, INIKEY_TRANSPORT, DefPath.VisionSetting);
            if (!String.IsNullOrEmpty(iniVal)) { m_nTransPort = Convert.ToInt32(iniVal); }
            else return;
        }
    }
}
