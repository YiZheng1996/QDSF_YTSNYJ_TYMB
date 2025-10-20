namespace MainUI
{
    partial class frmMainMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            panel1 = new Panel();
            lblDateTime = new Label();
            picRunStatus = new PictureBox();
            Logo = new PictureBox();
            lblTitle = new Label();
            timerPLC = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            tslblUser = new ToolStripStatusLabel();
            tslblPLC = new ToolStripStatusLabel();
            tslblHeartbeat = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            btnExit = new UISymbolButton();
            btnDeviceDetection = new UIImageButton();
            btnChangePwd = new UISymbolButton();
            btnNLog = new UIImageButton();
            btnMainData = new UIImageButton();
            btnHardwareTest = new UIImageButton();
            btnReports = new UIImageButton();
            timerHeartbeat = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRunStatus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnDeviceDetection).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnNLog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMainData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnHardwareTest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReports).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 55, 64);
            panel1.Controls.Add(lblDateTime);
            panel1.Controls.Add(picRunStatus);
            panel1.Controls.Add(Logo);
            panel1.Controls.Add(lblTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 44);
            panel1.TabIndex = 0;
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = Color.FromArgb(47, 55, 64);
            lblDateTime.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            lblDateTime.ForeColor = Color.White;
            lblDateTime.Location = new Point(1634, 9);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(196, 26);
            lblDateTime.TabIndex = 4;
            lblDateTime.Text = "2016-09-13 00:00:00";
            // 
            // picRunStatus
            // 
            picRunStatus.BackColor = Color.FromArgb(47, 55, 64);
            picRunStatus.Image = (Image)resources.GetObject("picRunStatus.Image");
            picRunStatus.Location = new Point(1870, 1);
            picRunStatus.Name = "picRunStatus";
            picRunStatus.Size = new Size(47, 43);
            picRunStatus.SizeMode = PictureBoxSizeMode.CenterImage;
            picRunStatus.TabIndex = 1;
            picRunStatus.TabStop = false;
            // 
            // Logo
            // 
            Logo.BackColor = Color.FromArgb(47, 55, 64);
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(0, 0);
            Logo.Name = "Logo";
            Logo.Size = new Size(161, 45);
            Logo.SizeMode = PictureBoxSizeMode.CenterImage;
            Logo.TabIndex = 2;
            Logo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.BackColor = Color.FromArgb(47, 55, 64);
            lblTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(167, -2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1461, 44);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "试验台名称";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            lblTitle.MouseDown += lblTitle_MouseDown;
            // 
            // timerPLC
            // 
            timerPLC.Interval = 1000;
            timerPLC.Tick += timerPLC_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(47, 55, 64);
            statusStrip1.Font = new Font("思源黑体 CN Bold", 9F, FontStyle.Bold);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslblUser, tslblPLC, tslblHeartbeat });
            statusStrip1.Location = new Point(0, 1010);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1920, 23);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslblUser
            // 
            tslblUser.Font = new Font("思源黑体 CN Bold", 9F, FontStyle.Bold);
            tslblUser.ForeColor = Color.FromArgb(235, 227, 221);
            tslblUser.Name = "tslblUser";
            tslblUser.Size = new Size(56, 18);
            tslblUser.Text = "用户名称";
            // 
            // tslblPLC
            // 
            tslblPLC.Font = new Font("思源黑体 CN Bold", 9F, FontStyle.Bold);
            tslblPLC.ForeColor = Color.FromArgb(235, 227, 221);
            tslblPLC.Name = "tslblPLC";
            tslblPLC.Size = new Size(55, 18);
            tslblPLC.Text = "PLC状态";
            // 
            // tslblHeartbeat
            // 
            tslblHeartbeat.Font = new Font("思源黑体 CN Bold", 9F, FontStyle.Bold);
            tslblHeartbeat.ForeColor = Color.FromArgb(235, 227, 221);
            tslblHeartbeat.Name = "tslblHeartbeat";
            tslblHeartbeat.Size = new Size(80, 18);
            tslblHeartbeat.Text = "网络连接状态";
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = Color.FromArgb(49, 54, 64);
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 44);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(49, 54, 64);
            splitContainer1.Panel1.Controls.Add(btnExit);
            splitContainer1.Panel1.Controls.Add(btnDeviceDetection);
            splitContainer1.Panel1.Controls.Add(btnChangePwd);
            splitContainer1.Panel1.Controls.Add(btnNLog);
            splitContainer1.Panel1.Controls.Add(btnMainData);
            splitContainer1.Panel1.Controls.Add(btnHardwareTest);
            splitContainer1.Panel1.Controls.Add(btnReports);
            splitContainer1.Panel1.Font = new Font("宋体", 10.5F);
            splitContainer1.Panel1.ForeColor = Color.FromArgb(235, 227, 221);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(49, 54, 64);
            splitContainer1.Size = new Size(1920, 966);
            splitContainer1.SplitterDistance = 130;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 5;
            // 
            // btnExit
            // 
            btnExit.FillColor = Color.FromArgb(49, 54, 64);
            btnExit.FillColor2 = Color.FromArgb(49, 54, 64);
            btnExit.FillDisableColor = Color.FromArgb(49, 54, 64);
            btnExit.FillHoverColor = Color.FromArgb(49, 54, 64);
            btnExit.FillPressColor = Color.FromArgb(70, 75, 85);
            btnExit.FillSelectedColor = Color.FromArgb(70, 75, 85);
            btnExit.Font = new Font("思源黑体 CN Bold", 14F, FontStyle.Bold);
            btnExit.ForeColor = Color.FromArgb(235, 227, 221);
            btnExit.ForeDisableColor = Color.FromArgb(235, 227, 221);
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.Location = new Point(6, 914);
            btnExit.MinimumSize = new Size(1, 1);
            btnExit.Name = "btnExit";
            btnExit.RectColor = Color.FromArgb(49, 54, 64);
            btnExit.RectDisableColor = Color.FromArgb(49, 54, 64);
            btnExit.RectHoverColor = Color.FromArgb(49, 54, 64);
            btnExit.RectPressColor = Color.FromArgb(70, 75, 85);
            btnExit.RectSelectedColor = Color.FromArgb(70, 75, 85);
            btnExit.Size = new Size(120, 47);
            btnExit.Symbol = 0;
            btnExit.SymbolDisableColor = Color.FromArgb(90, 95, 102);
            btnExit.SymbolSize = 25;
            btnExit.TabIndex = 119;
            btnExit.Text = "退出         ";
            btnExit.TipsFont = new Font("宋体", 11F);
            btnExit.Click += btnExit_Click;
            // 
            // btnDeviceDetection
            // 
            btnDeviceDetection.Cursor = Cursors.Hand;
            btnDeviceDetection.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            btnDeviceDetection.ForeColor = Color.FromArgb(235, 227, 221);
            btnDeviceDetection.Image = (Image)resources.GetObject("btnDeviceDetection.Image");
            btnDeviceDetection.ImageHover = (Image)resources.GetObject("btnDeviceDetection.ImageHover");
            btnDeviceDetection.ImageOffset = new Point(12, 5);
            btnDeviceDetection.ImagePress = (Image)resources.GetObject("btnDeviceDetection.ImagePress");
            btnDeviceDetection.Location = new Point(2, 166);
            btnDeviceDetection.Name = "btnDeviceDetection";
            btnDeviceDetection.Size = new Size(123, 99);
            btnDeviceDetection.SizeMode = PictureBoxSizeMode.CenterImage;
            btnDeviceDetection.TabIndex = 120;
            btnDeviceDetection.TabStop = false;
            btnDeviceDetection.Text = "设备检查";
            btnDeviceDetection.TextAlign = ContentAlignment.BottomCenter;
            btnDeviceDetection.Click += btnDeviceDetection_Click;
            // 
            // btnChangePwd
            // 
            btnChangePwd.FillColor = Color.FromArgb(49, 54, 64);
            btnChangePwd.FillColor2 = Color.FromArgb(49, 54, 64);
            btnChangePwd.FillDisableColor = Color.FromArgb(49, 54, 64);
            btnChangePwd.FillHoverColor = Color.FromArgb(49, 54, 64);
            btnChangePwd.FillPressColor = Color.FromArgb(49, 54, 64);
            btnChangePwd.FillSelectedColor = Color.FromArgb(44, 64, 64);
            btnChangePwd.Font = new Font("思源黑体 CN Bold", 14F, FontStyle.Bold);
            btnChangePwd.ForeColor = Color.FromArgb(235, 227, 221);
            btnChangePwd.ForeDisableColor = Color.FromArgb(235, 227, 221);
            btnChangePwd.Image = (Image)resources.GetObject("btnChangePwd.Image");
            btnChangePwd.Location = new Point(6, 855);
            btnChangePwd.MinimumSize = new Size(1, 1);
            btnChangePwd.Name = "btnChangePwd";
            btnChangePwd.RectColor = Color.FromArgb(49, 54, 64);
            btnChangePwd.RectDisableColor = Color.FromArgb(49, 54, 64);
            btnChangePwd.RectHoverColor = Color.FromArgb(49, 54, 64);
            btnChangePwd.RectPressColor = Color.FromArgb(70, 75, 85);
            btnChangePwd.RectSelectedColor = Color.FromArgb(70, 75, 85);
            btnChangePwd.Size = new Size(120, 47);
            btnChangePwd.Symbol = 0;
            btnChangePwd.SymbolDisableColor = Color.FromArgb(90, 95, 102);
            btnChangePwd.SymbolSize = 25;
            btnChangePwd.TabIndex = 118;
            btnChangePwd.Text = "更改密码";
            btnChangePwd.TipsFont = new Font("宋体", 11F);
            btnChangePwd.Click += btnChangePwd_Click;
            // 
            // btnNLog
            // 
            btnNLog.Cursor = Cursors.Hand;
            btnNLog.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            btnNLog.ForeColor = Color.FromArgb(235, 227, 221);
            btnNLog.Image = (Image)resources.GetObject("btnNLog.Image");
            btnNLog.ImageHover = (Image)resources.GetObject("btnNLog.ImageHover");
            btnNLog.ImageOffset = new Point(12, 5);
            btnNLog.ImagePress = (Image)resources.GetObject("btnNLog.ImagePress");
            btnNLog.Location = new Point(2, 562);
            btnNLog.Name = "btnNLog";
            btnNLog.Size = new Size(123, 99);
            btnNLog.SizeMode = PictureBoxSizeMode.CenterImage;
            btnNLog.TabIndex = 117;
            btnNLog.TabStop = false;
            btnNLog.Text = "日志";
            btnNLog.TextAlign = ContentAlignment.BottomCenter;
            btnNLog.Visible = false;
            btnNLog.Click += uiImageButton1_Click;
            // 
            // btnMainData
            // 
            btnMainData.Cursor = Cursors.Hand;
            btnMainData.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            btnMainData.ForeColor = Color.FromArgb(235, 227, 221);
            btnMainData.Image = (Image)resources.GetObject("btnMainData.Image");
            btnMainData.ImageHover = (Image)resources.GetObject("btnMainData.ImageHover");
            btnMainData.ImageOffset = new Point(12, 5);
            btnMainData.ImagePress = (Image)resources.GetObject("btnMainData.ImagePress");
            btnMainData.Location = new Point(2, 448);
            btnMainData.Name = "btnMainData";
            btnMainData.Size = new Size(123, 99);
            btnMainData.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMainData.TabIndex = 114;
            btnMainData.TabStop = false;
            btnMainData.Text = "数据管理";
            btnMainData.TextAlign = ContentAlignment.BottomCenter;
            btnMainData.Click += btnMainData_Click;
            // 
            // btnHardwareTest
            // 
            btnHardwareTest.Cursor = Cursors.Hand;
            btnHardwareTest.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            btnHardwareTest.ForeColor = Color.FromArgb(235, 227, 221);
            btnHardwareTest.Image = (Image)resources.GetObject("btnHardwareTest.Image");
            btnHardwareTest.ImageHover = (Image)resources.GetObject("btnHardwareTest.ImageHover");
            btnHardwareTest.ImageOffset = new Point(12, 5);
            btnHardwareTest.ImagePress = (Image)resources.GetObject("btnHardwareTest.ImagePress");
            btnHardwareTest.Location = new Point(2, 307);
            btnHardwareTest.Name = "btnHardwareTest";
            btnHardwareTest.Size = new Size(123, 99);
            btnHardwareTest.SizeMode = PictureBoxSizeMode.CenterImage;
            btnHardwareTest.TabIndex = 113;
            btnHardwareTest.TabStop = false;
            btnHardwareTest.Text = "硬件校准";
            btnHardwareTest.TextAlign = ContentAlignment.BottomCenter;
            btnHardwareTest.Click += btnHardwareTest_Click;
            // 
            // btnReports
            // 
            btnReports.Cursor = Cursors.Hand;
            btnReports.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            btnReports.ForeColor = Color.FromArgb(235, 227, 221);
            btnReports.Image = (Image)resources.GetObject("btnReports.Image");
            btnReports.ImageHover = (Image)resources.GetObject("btnReports.ImageHover");
            btnReports.ImageOffset = new Point(12, 5);
            btnReports.ImagePress = (Image)resources.GetObject("btnReports.ImagePress");
            btnReports.Location = new Point(2, 25);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(123, 99);
            btnReports.SizeMode = PictureBoxSizeMode.CenterImage;
            btnReports.TabIndex = 112;
            btnReports.TabStop = false;
            btnReports.Text = "数据查询";
            btnReports.TextAlign = ContentAlignment.BottomCenter;
            btnReports.Click += btnReports_Click;
            // 
            // timerHeartbeat
            // 
            timerHeartbeat.Interval = 5000;
            timerHeartbeat.Tick += TimerHeartbeat_Tick;
            // 
            // frmMainMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(243, 249, 255);
            ClientSize = new Size(1920, 1033);
            ControlBox = false;
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmMainMenu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picRunStatus).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnDeviceDetection).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnNLog).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMainData).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnHardwareTest).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picRunStatus;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer timerPLC;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblUser;
        private System.Windows.Forms.ToolStripStatusLabel tslblPLC;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Sunny.UI.UIImageButton btnReports;
        private Sunny.UI.UIImageButton btnMainData;
        private Sunny.UI.UIImageButton btnHardwareTest;
        public System.Windows.Forms.PictureBox Logo;
        private Sunny.UI.UIImageButton btnNLog;
        private System.Windows.Forms.Timer timerHeartbeat;
        private ToolStripStatusLabel tslblHeartbeat;
        private UISymbolButton btnChangePwd;
        private UISymbolButton btnExit;
        private UIImageButton btnDeviceDetection;
    }
}