namespace SyringeTest
{
    partial class RTSP_Vision
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox_snapshot = new System.Windows.Forms.PictureBox();
            this.textBox_uri = new System.Windows.Forms.TextBox();
            this.comboBox_transport = new System.Windows.Forms.ComboBox();
            this.numericUpDown_timeout = new System.Windows.Forms.NumericUpDown();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_snapshot = new System.Windows.Forms.Button();
            this.timer_status = new System.Windows.Forms.Timer(this.components);
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_save_path = new System.Windows.Forms.Button();
            this.textBox_save_path = new System.Windows.Forms.TextBox();
            this.pictureBox_snap_shot = new System.Windows.Forms.PictureBox();
            this.button_snap_shot = new System.Windows.Forms.Button();
            this.button_snap_continuous = new System.Windows.Forms.Button();
            this.timer_snap_continuous = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox_http_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_http_stream_addr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_http_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_http_pw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_http_timeout = new System.Windows.Forms.NumericUpDown();
            this.button_http_init = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_snapshot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timeout)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_snap_shot)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_http_timeout)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_snapshot
            // 
            this.pictureBox_snapshot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_snapshot.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_snapshot.Name = "pictureBox_snapshot";
            this.pictureBox_snapshot.Size = new System.Drawing.Size(566, 356);
            this.pictureBox_snapshot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_snapshot.TabIndex = 0;
            this.pictureBox_snapshot.TabStop = false;
            // 
            // textBox_uri
            // 
            this.textBox_uri.Location = new System.Drawing.Point(123, 3);
            this.textBox_uri.Name = "textBox_uri";
            this.textBox_uri.Size = new System.Drawing.Size(267, 21);
            this.textBox_uri.TabIndex = 1;
            // 
            // comboBox_transport
            // 
            this.comboBox_transport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_transport.FormattingEnabled = true;
            this.comboBox_transport.Items.AddRange(new object[] {
            "None",
            "TCP",
            "UDP"});
            this.comboBox_transport.Location = new System.Drawing.Point(495, 3);
            this.comboBox_transport.Name = "comboBox_transport";
            this.comboBox_transport.Size = new System.Drawing.Size(66, 20);
            this.comboBox_transport.TabIndex = 2;
            // 
            // numericUpDown_timeout
            // 
            this.numericUpDown_timeout.Location = new System.Drawing.Point(396, 3);
            this.numericUpDown_timeout.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_timeout.Name = "numericUpDown_timeout";
            this.numericUpDown_timeout.Size = new System.Drawing.Size(93, 21);
            this.numericUpDown_timeout.TabIndex = 3;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(3, 30);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(84, 30);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 5;
            this.button_stop.Text = "Stop";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_snapshot
            // 
            this.button_snapshot.Location = new System.Drawing.Point(165, 30);
            this.button_snapshot.Name = "button_snapshot";
            this.button_snapshot.Size = new System.Drawing.Size(82, 33);
            this.button_snapshot.TabIndex = 6;
            this.button_snapshot.Text = "Snap";
            this.button_snapshot.UseVisualStyleBackColor = true;
            this.button_snapshot.Click += new System.EventHandler(this.button_snapshot_Click);
            // 
            // timer_status
            // 
            this.timer_status.Enabled = true;
            this.timer_status.Interval = 200;
            this.timer_status.Tick += new System.EventHandler(this.timer_status_Tick);
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(3, 3);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.ReadOnly = true;
            this.textBox_status.Size = new System.Drawing.Size(114, 21);
            this.textBox_status.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBox_status);
            this.flowLayoutPanel1.Controls.Add(this.textBox_uri);
            this.flowLayoutPanel1.Controls.Add(this.numericUpDown_timeout);
            this.flowLayoutPanel1.Controls.Add(this.comboBox_transport);
            this.flowLayoutPanel1.Controls.Add(this.button_start);
            this.flowLayoutPanel1.Controls.Add(this.button_stop);
            this.flowLayoutPanel1.Controls.Add(this.button_snapshot);
            this.flowLayoutPanel1.Controls.Add(this.button_save_path);
            this.flowLayoutPanel1.Controls.Add(this.textBox_save_path);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 365);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(566, 148);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // button_save_path
            // 
            this.button_save_path.Location = new System.Drawing.Point(253, 30);
            this.button_save_path.Name = "button_save_path";
            this.button_save_path.Size = new System.Drawing.Size(82, 33);
            this.button_save_path.TabIndex = 8;
            this.button_save_path.Text = "Set path";
            this.button_save_path.UseVisualStyleBackColor = true;
            this.button_save_path.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_save_path
            // 
            this.textBox_save_path.Location = new System.Drawing.Point(3, 69);
            this.textBox_save_path.Name = "textBox_save_path";
            this.textBox_save_path.Size = new System.Drawing.Size(267, 21);
            this.textBox_save_path.TabIndex = 9;
            this.textBox_save_path.Text = "C:";
            // 
            // pictureBox_snap_shot
            // 
            this.pictureBox_snap_shot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_snap_shot.Location = new System.Drawing.Point(575, 3);
            this.pictureBox_snap_shot.Name = "pictureBox_snap_shot";
            this.pictureBox_snap_shot.Size = new System.Drawing.Size(567, 356);
            this.pictureBox_snap_shot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_snap_shot.TabIndex = 9;
            this.pictureBox_snap_shot.TabStop = false;
            // 
            // button_snap_shot
            // 
            this.button_snap_shot.Location = new System.Drawing.Point(3, 3);
            this.button_snap_shot.Name = "button_snap_shot";
            this.button_snap_shot.Size = new System.Drawing.Size(164, 47);
            this.button_snap_shot.TabIndex = 10;
            this.button_snap_shot.Text = "Snapshot";
            this.button_snap_shot.UseVisualStyleBackColor = true;
            this.button_snap_shot.Click += new System.EventHandler(this.button_snap_shot_Click);
            // 
            // button_snap_continuous
            // 
            this.button_snap_continuous.Location = new System.Drawing.Point(173, 3);
            this.button_snap_continuous.Name = "button_snap_continuous";
            this.button_snap_continuous.Size = new System.Drawing.Size(164, 47);
            this.button_snap_continuous.TabIndex = 11;
            this.button_snap_continuous.Text = "Continuous";
            this.button_snap_continuous.UseVisualStyleBackColor = true;
            this.button_snap_continuous.Click += new System.EventHandler(this.button_snap_continuous_Click);
            // 
            // timer_snap_continuous
            // 
            this.timer_snap_continuous.Interval = 200;
            this.timer_snap_continuous.Tick += new System.EventHandler(this.timer_snap_continuous_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_snapshot, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox_snap_shot, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.26349F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.73651F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1145, 516);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button_snap_shot);
            this.flowLayoutPanel2.Controls.Add(this.button_snap_continuous);
            this.flowLayoutPanel2.Controls.Add(this.textBox_http_ip);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.textBox_http_stream_addr);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.textBox_http_id);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.textBox_http_pw);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.numericUpDown_http_timeout);
            this.flowLayoutPanel2.Controls.Add(this.button_http_init);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(575, 365);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(567, 148);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // textBox_http_ip
            // 
            this.textBox_http_ip.Location = new System.Drawing.Point(3, 56);
            this.textBox_http_ip.Name = "textBox_http_ip";
            this.textBox_http_ip.Size = new System.Drawing.Size(240, 21);
            this.textBox_http_ip.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "<-ip";
            // 
            // textBox_http_stream_addr
            // 
            this.textBox_http_stream_addr.Location = new System.Drawing.Point(3, 83);
            this.textBox_http_stream_addr.Name = "textBox_http_stream_addr";
            this.textBox_http_stream_addr.Size = new System.Drawing.Size(288, 21);
            this.textBox_http_stream_addr.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "<-stream_addr";
            // 
            // textBox_http_id
            // 
            this.textBox_http_id.Location = new System.Drawing.Point(392, 83);
            this.textBox_http_id.Name = "textBox_http_id";
            this.textBox_http_id.Size = new System.Drawing.Size(127, 21);
            this.textBox_http_id.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "<-id";
            // 
            // textBox_http_pw
            // 
            this.textBox_http_pw.Location = new System.Drawing.Point(3, 110);
            this.textBox_http_pw.Name = "textBox_http_pw";
            this.textBox_http_pw.Size = new System.Drawing.Size(127, 21);
            this.textBox_http_pw.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "<-pw";
            // 
            // numericUpDown_http_timeout
            // 
            this.numericUpDown_http_timeout.Location = new System.Drawing.Point(178, 110);
            this.numericUpDown_http_timeout.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown_http_timeout.Name = "numericUpDown_http_timeout";
            this.numericUpDown_http_timeout.Size = new System.Drawing.Size(93, 21);
            this.numericUpDown_http_timeout.TabIndex = 13;
            // 
            // button_http_init
            // 
            this.button_http_init.Location = new System.Drawing.Point(277, 110);
            this.button_http_init.Name = "button_http_init";
            this.button_http_init.Size = new System.Drawing.Size(75, 23);
            this.button_http_init.TabIndex = 17;
            this.button_http_init.Text = "Initialize";
            this.button_http_init.UseVisualStyleBackColor = true;
            this.button_http_init.Click += new System.EventHandler(this.button_http_init_Click);
            // 
            // RTSP_Vision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 540);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RTSP_Vision";
            this.Text = "RTSP_Vision";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RTSP_Vision_FormClosing);
            this.Load += new System.EventHandler(this.RTSP_Vision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_snapshot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_timeout)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_snap_shot)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_http_timeout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_snapshot;
        private System.Windows.Forms.TextBox textBox_uri;
        private System.Windows.Forms.ComboBox comboBox_transport;
        private System.Windows.Forms.NumericUpDown numericUpDown_timeout;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Button button_snapshot;
        private System.Windows.Forms.Timer timer_status;
        private System.Windows.Forms.TextBox textBox_status;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_save_path;
        private System.Windows.Forms.TextBox textBox_save_path;
        private System.Windows.Forms.PictureBox pictureBox_snap_shot;
        private System.Windows.Forms.Button button_snap_shot;
        private System.Windows.Forms.Button button_snap_continuous;
        private System.Windows.Forms.Timer timer_snap_continuous;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox_http_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_http_stream_addr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_http_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_http_pw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_http_timeout;
        private System.Windows.Forms.Button button_http_init;
    }
}