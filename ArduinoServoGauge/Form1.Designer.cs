namespace ArduinoServoGauge
{
    partial class frmArduinoGauge
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
            this.pnlGauge = new System.Windows.Forms.Panel();
            this.gaugeTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.comStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCOMPorts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbIntervals = new System.Windows.Forms.ComboBox();
            this.checkDrawTicks = new System.Windows.Forms.CheckBox();
            this.checkResetServo = new System.Windows.Forms.CheckBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.controlTrack = new System.Windows.Forms.TrackBar();
            this.statusStrip1.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGauge
            // 
            this.pnlGauge.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnlGauge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGauge.Location = new System.Drawing.Point(89, 12);
            this.pnlGauge.Name = "pnlGauge";
            this.pnlGauge.Size = new System.Drawing.Size(362, 154);
            this.pnlGauge.TabIndex = 0;
            this.pnlGauge.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGauge_Paint);
            // 
            // gaugeTimer
            // 
            this.gaugeTimer.Enabled = true;
            this.gaugeTimer.Tick += new System.EventHandler(this.gaugeTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 338);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(532, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // comStatus
            // 
            this.comStatus.Name = "comStatus";
            this.comStatus.Size = new System.Drawing.Size(105, 17);
            this.comStatus.Text = "Connected: COM5";
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Location = new System.Drawing.Point(193, 190);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(145, 13);
            this.lblCurrentValue.TabIndex = 2;
            this.lblCurrentValue.Text = "Current Rotation(Degrees) : 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Available COM Ports:";
            // 
            // cmbCOMPorts
            // 
            this.cmbCOMPorts.FormattingEnabled = true;
            this.cmbCOMPorts.Location = new System.Drawing.Point(119, 20);
            this.cmbCOMPorts.Name = "cmbCOMPorts";
            this.cmbCOMPorts.Size = new System.Drawing.Size(121, 21);
            this.cmbCOMPorts.TabIndex = 5;
            this.cmbCOMPorts.Text = "COM5";
            this.cmbCOMPorts.SelectedIndexChanged += new System.EventHandler(this.cmbCOMPorts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rotation Interval: ";
            // 
            // cmbIntervals
            // 
            this.cmbIntervals.FormattingEnabled = true;
            this.cmbIntervals.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "9",
            "10",
            "12",
            "15",
            "18",
            "20",
            "30",
            "36",
            "45",
            "60",
            "90",
            "180"});
            this.cmbIntervals.Location = new System.Drawing.Point(119, 47);
            this.cmbIntervals.Name = "cmbIntervals";
            this.cmbIntervals.Size = new System.Drawing.Size(121, 21);
            this.cmbIntervals.TabIndex = 7;
            this.cmbIntervals.Text = "10";
            this.cmbIntervals.SelectedIndexChanged += new System.EventHandler(this.cmbIntervals_SelectedIndexChanged);
            // 
            // checkDrawTicks
            // 
            this.checkDrawTicks.AutoSize = true;
            this.checkDrawTicks.Checked = true;
            this.checkDrawTicks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDrawTicks.Location = new System.Drawing.Point(302, 26);
            this.checkDrawTicks.Name = "checkDrawTicks";
            this.checkDrawTicks.Size = new System.Drawing.Size(111, 17);
            this.checkDrawTicks.TabIndex = 8;
            this.checkDrawTicks.Text = "Display tick marks";
            this.checkDrawTicks.UseVisualStyleBackColor = true;
            // 
            // checkResetServo
            // 
            this.checkResetServo.AutoSize = true;
            this.checkResetServo.Location = new System.Drawing.Point(302, 49);
            this.checkResetServo.Name = "checkResetServo";
            this.checkResetServo.Size = new System.Drawing.Size(148, 17);
            this.checkResetServo.TabIndex = 9;
            this.checkResetServo.Text = "Reset servo when closing\r\n";
            this.checkResetServo.UseVisualStyleBackColor = true;
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.checkResetServo);
            this.groupBoxOptions.Controls.Add(this.checkDrawTicks);
            this.groupBoxOptions.Controls.Add(this.cmbIntervals);
            this.groupBoxOptions.Controls.Add(this.label2);
            this.groupBoxOptions.Controls.Add(this.cmbCOMPorts);
            this.groupBoxOptions.Controls.Add(this.label1);
            this.groupBoxOptions.Location = new System.Drawing.Point(12, 247);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(508, 78);
            this.groupBoxOptions.TabIndex = 3;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // controlTrack
            // 
            this.controlTrack.AutoSize = false;
            this.controlTrack.LargeChange = 30;
            this.controlTrack.Location = new System.Drawing.Point(168, 208);
            this.controlTrack.Maximum = 180;
            this.controlTrack.Name = "controlTrack";
            this.controlTrack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.controlTrack.Size = new System.Drawing.Size(209, 25);
            this.controlTrack.SmallChange = 30;
            this.controlTrack.TabIndex = 10;
            this.controlTrack.TickFrequency = 30;
            this.controlTrack.TickStyle = System.Windows.Forms.TickStyle.None;
            this.controlTrack.Scroll += new System.EventHandler(this.controlTrack_Scroll);
            // 
            // frmArduinoGauge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 360);
            this.Controls.Add(this.controlTrack);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.lblCurrentValue);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlGauge);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArduinoGauge";
            this.Text = "Arduino Gauge";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmArduinoGauge_FormClosing);
            this.Load += new System.EventHandler(this.frmArduinoGauge_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGauge;
        private System.Windows.Forms.Timer gaugeTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel comStatus;
        private System.Windows.Forms.Label lblCurrentValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCOMPorts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbIntervals;
        private System.Windows.Forms.CheckBox checkDrawTicks;
        private System.Windows.Forms.CheckBox checkResetServo;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.TrackBar controlTrack;
    }
}

