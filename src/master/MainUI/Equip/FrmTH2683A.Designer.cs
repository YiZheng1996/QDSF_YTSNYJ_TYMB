namespace MainUI.Equip
{
    partial class FrmTH2683A
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
            grpTest = new UIPanel();
            uiLine3 = new UILine();
            grpParams = new UIPanel();
            uiLine4 = new UILine();
            lblTestCount = new UILabel();
            numTestVoltage = new NumericUpDown();
            lblTestVoltage = new UILabel();
            numTestTime = new NumericUpDown();
            lblTestTime = new UILabel();
            numResistanceLimit = new NumericUpDown();
            lblResistanceLimit = new UILabel();
            grpControl = new UIPanel();
            btnStartTest = new UIButton();
            btnStopTest = new UIButton();
            grpResult = new UIPanel();
            uiLine1 = new UILine();
            lblElapsedTimeValue = new UILabel();
            lblElapsedTime = new UILabel();
            txtTestResult = new UITextBox();
            lblTestResultLabel = new UILabel();
            txtResistanceValue = new UITextBox();
            lblResistanceValue = new UILabel();
            txtTestConclusion = new UITextBox();
            lblTestConclusion = new UILabel();
            grpConnection = new UIPanel();
            cmbComPort = new UIComboBox();
            lblComPort = new UILabel();
            btnConnect = new UIButton();
            btnDisconnect = new UIButton();
            lblConnectionStatus = new UILabel();
            timerTest = new System.Windows.Forms.Timer(components);
            grpTest.SuspendLayout();
            grpParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTestVoltage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTestTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numResistanceLimit).BeginInit();
            grpControl.SuspendLayout();
            grpResult.SuspendLayout();
            grpConnection.SuspendLayout();
            SuspendLayout();
            // 
            // grpTest
            // 
            grpTest.BackColor = Color.Transparent;
            grpTest.Controls.Add(uiLine3);
            grpTest.Controls.Add(grpParams);
            grpTest.Controls.Add(grpControl);
            grpTest.Controls.Add(grpResult);
            grpTest.FillColor = Color.FromArgb(49, 54, 64);
            grpTest.FillColor2 = Color.FromArgb(49, 54, 64);
            grpTest.FillDisableColor = Color.FromArgb(49, 54, 64);
            grpTest.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            grpTest.ForeColor = Color.FromArgb(235, 227, 221);
            grpTest.Location = new Point(12, 130);
            grpTest.Margin = new Padding(4, 5, 4, 5);
            grpTest.MinimumSize = new Size(1, 1);
            grpTest.Name = "grpTest";
            grpTest.Padding = new Padding(0, 32, 0, 0);
            grpTest.Radius = 10;
            grpTest.RectColor = Color.FromArgb(49, 54, 64);
            grpTest.RectDisableColor = Color.FromArgb(49, 54, 64);
            grpTest.Size = new Size(560, 511);
            grpTest.TabIndex = 0;
            grpTest.TabStop = false;
            grpTest.Text = null;
            grpTest.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiLine3
            // 
            uiLine3.BackColor = Color.Transparent;
            uiLine3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLine3.ForeColor = Color.White;
            uiLine3.LineColor = Color.Transparent;
            uiLine3.Location = new Point(-7, 1);
            uiLine3.MinimumSize = new Size(1, 1);
            uiLine3.Name = "uiLine3";
            uiLine3.Size = new Size(554, 29);
            uiLine3.TabIndex = 10;
            uiLine3.Text = "绝缘电阻测试";
            uiLine3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grpParams
            // 
            grpParams.Controls.Add(uiLine4);
            grpParams.Controls.Add(lblTestCount);
            grpParams.Controls.Add(numTestVoltage);
            grpParams.Controls.Add(lblTestVoltage);
            grpParams.Controls.Add(numTestTime);
            grpParams.Controls.Add(lblTestTime);
            grpParams.Controls.Add(numResistanceLimit);
            grpParams.Controls.Add(lblResistanceLimit);
            grpParams.FillColor = Color.FromArgb(42, 47, 55);
            grpParams.FillColor2 = Color.FromArgb(42, 47, 55);
            grpParams.FillDisableColor = Color.FromArgb(42, 47, 55);
            grpParams.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            grpParams.ForeColor = Color.FromArgb(235, 227, 221);
            grpParams.Location = new Point(20, 37);
            grpParams.Margin = new Padding(4, 5, 4, 5);
            grpParams.MinimumSize = new Size(1, 1);
            grpParams.Name = "grpParams";
            grpParams.Padding = new Padding(0, 32, 0, 0);
            grpParams.Radius = 10;
            grpParams.RectColor = Color.FromArgb(42, 47, 55);
            grpParams.RectDisableColor = Color.FromArgb(42, 47, 55);
            grpParams.Size = new Size(520, 140);
            grpParams.TabIndex = 0;
            grpParams.TabStop = false;
            grpParams.Text = null;
            grpParams.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiLine4
            // 
            uiLine4.BackColor = Color.Transparent;
            uiLine4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLine4.ForeColor = Color.White;
            uiLine4.LineColor = Color.Transparent;
            uiLine4.Location = new Point(10, 0);
            uiLine4.MinimumSize = new Size(1, 1);
            uiLine4.Name = "uiLine4";
            uiLine4.Size = new Size(507, 29);
            uiLine4.TabIndex = 11;
            uiLine4.Text = "绝缘电阻测试参数";
            uiLine4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTestCount
            // 
            lblTestCount.AutoSize = true;
            lblTestCount.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lblTestCount.ForeColor = Color.FromArgb(48, 48, 48);
            lblTestCount.Location = new Point(20, 110);
            lblTestCount.Name = "lblTestCount";
            lblTestCount.Size = new Size(0, 16);
            lblTestCount.TabIndex = 6;
            // 
            // numTestVoltage
            // 
            numTestVoltage.Location = new Point(180, 30);
            numTestVoltage.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numTestVoltage.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTestVoltage.Name = "numTestVoltage";
            numTestVoltage.Size = new Size(120, 26);
            numTestVoltage.TabIndex = 1;
            numTestVoltage.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // lblTestVoltage
            // 
            lblTestVoltage.AutoSize = true;
            lblTestVoltage.BackColor = Color.Transparent;
            lblTestVoltage.Font = new Font("微软雅黑", 12F);
            lblTestVoltage.ForeColor = Color.FromArgb(235, 227, 221);
            lblTestVoltage.Location = new Point(20, 32);
            lblTestVoltage.Name = "lblTestVoltage";
            lblTestVoltage.Size = new Size(123, 21);
            lblTestVoltage.TabIndex = 0;
            lblTestVoltage.Text = "测试电压DC (V)";
            // 
            // numTestTime
            // 
            numTestTime.DecimalPlaces = 1;
            numTestTime.Location = new Point(180, 65);
            numTestTime.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numTestTime.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTestTime.Name = "numTestTime";
            numTestTime.Size = new Size(120, 26);
            numTestTime.TabIndex = 3;
            numTestTime.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // lblTestTime
            // 
            lblTestTime.AutoSize = true;
            lblTestTime.BackColor = Color.Transparent;
            lblTestTime.Font = new Font("微软雅黑", 12F);
            lblTestTime.ForeColor = Color.FromArgb(235, 227, 221);
            lblTestTime.Location = new Point(20, 67);
            lblTestTime.Name = "lblTestTime";
            lblTestTime.Size = new Size(98, 21);
            lblTestTime.TabIndex = 2;
            lblTestTime.Text = "测试时间 (S)";
            // 
            // numResistanceLimit
            // 
            numResistanceLimit.Location = new Point(180, 100);
            numResistanceLimit.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numResistanceLimit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numResistanceLimit.Name = "numResistanceLimit";
            numResistanceLimit.Size = new Size(120, 26);
            numResistanceLimit.TabIndex = 5;
            numResistanceLimit.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lblResistanceLimit
            // 
            lblResistanceLimit.AutoSize = true;
            lblResistanceLimit.BackColor = Color.Transparent;
            lblResistanceLimit.Font = new Font("微软雅黑", 12F);
            lblResistanceLimit.ForeColor = Color.FromArgb(235, 227, 221);
            lblResistanceLimit.Location = new Point(20, 102);
            lblResistanceLimit.Name = "lblResistanceLimit";
            lblResistanceLimit.Size = new Size(118, 21);
            lblResistanceLimit.TabIndex = 4;
            lblResistanceLimit.Text = "电阻下限 (MΩ)";
            // 
            // grpControl
            // 
            grpControl.BackColor = Color.Transparent;
            grpControl.Controls.Add(btnStartTest);
            grpControl.Controls.Add(btnStopTest);
            grpControl.FillColor = Color.FromArgb(42, 47, 55);
            grpControl.FillColor2 = Color.FromArgb(42, 47, 55);
            grpControl.FillDisableColor = Color.FromArgb(49, 54, 64);
            grpControl.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            grpControl.Location = new Point(20, 190);
            grpControl.Margin = new Padding(4, 5, 4, 5);
            grpControl.MinimumSize = new Size(1, 1);
            grpControl.Name = "grpControl";
            grpControl.Padding = new Padding(0, 32, 0, 0);
            grpControl.Radius = 10;
            grpControl.RectColor = Color.FromArgb(49, 54, 64);
            grpControl.RectDisableColor = Color.FromArgb(49, 54, 64);
            grpControl.Size = new Size(520, 80);
            grpControl.TabIndex = 1;
            grpControl.TabStop = false;
            grpControl.Text = null;
            grpControl.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // btnStartTest
            // 
            btnStartTest.FillColor = Color.FromArgb(70, 75, 85);
            btnStartTest.FillColor2 = Color.FromArgb(70, 75, 85);
            btnStartTest.FillDisableColor = Color.FromArgb(70, 75, 85);
            btnStartTest.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            btnStartTest.ForeColor = Color.FromArgb(235, 227, 221);
            btnStartTest.ForeDisableColor = Color.FromArgb(235, 227, 221);
            btnStartTest.Location = new Point(50, 21);
            btnStartTest.MinimumSize = new Size(1, 1);
            btnStartTest.Name = "btnStartTest";
            btnStartTest.RectColor = Color.FromArgb(70, 75, 85);
            btnStartTest.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnStartTest.Size = new Size(180, 40);
            btnStartTest.TabIndex = 0;
            btnStartTest.Text = "开始绝缘电阻测试";
            btnStartTest.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnStartTest.Click += btnStartTest_Click;
            // 
            // btnStopTest
            // 
            btnStopTest.FillColor = Color.FromArgb(70, 75, 85);
            btnStopTest.FillColor2 = Color.FromArgb(70, 75, 85);
            btnStopTest.FillDisableColor = Color.FromArgb(70, 75, 85);
            btnStopTest.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            btnStopTest.ForeColor = Color.FromArgb(235, 227, 221);
            btnStopTest.ForeDisableColor = Color.FromArgb(235, 227, 221);
            btnStopTest.Location = new Point(290, 20);
            btnStopTest.MinimumSize = new Size(1, 1);
            btnStopTest.Name = "btnStopTest";
            btnStopTest.RectColor = Color.FromArgb(70, 75, 85);
            btnStopTest.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnStopTest.Size = new Size(180, 40);
            btnStopTest.TabIndex = 1;
            btnStopTest.Text = "停止绝缘电阻测试";
            btnStopTest.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnStopTest.Click += btnStopTest_Click;
            // 
            // grpResult
            // 
            grpResult.BackColor = Color.Transparent;
            grpResult.Controls.Add(uiLine1);
            grpResult.Controls.Add(lblElapsedTimeValue);
            grpResult.Controls.Add(lblElapsedTime);
            grpResult.Controls.Add(txtTestResult);
            grpResult.Controls.Add(lblTestResultLabel);
            grpResult.Controls.Add(txtResistanceValue);
            grpResult.Controls.Add(lblResistanceValue);
            grpResult.Controls.Add(txtTestConclusion);
            grpResult.Controls.Add(lblTestConclusion);
            grpResult.FillColor = Color.FromArgb(42, 47, 55);
            grpResult.FillColor2 = Color.FromArgb(42, 47, 55);
            grpResult.FillDisableColor = Color.FromArgb(42, 47, 55);
            grpResult.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            grpResult.ForeColor = Color.FromArgb(235, 227, 221);
            grpResult.Location = new Point(20, 290);
            grpResult.Margin = new Padding(4, 5, 4, 5);
            grpResult.MinimumSize = new Size(1, 1);
            grpResult.Name = "grpResult";
            grpResult.Padding = new Padding(0, 32, 0, 0);
            grpResult.RectColor = Color.FromArgb(42, 47, 55);
            grpResult.RectDisableColor = Color.FromArgb(42, 47, 55);
            grpResult.Size = new Size(520, 210);
            grpResult.TabIndex = 2;
            grpResult.TabStop = false;
            grpResult.Text = null;
            grpResult.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiLine1
            // 
            uiLine1.BackColor = Color.Transparent;
            uiLine1.Font = new Font("宋体", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uiLine1.ForeColor = Color.White;
            uiLine1.LineColor = Color.Transparent;
            uiLine1.Location = new Point(-7, 1);
            uiLine1.MinimumSize = new Size(1, 1);
            uiLine1.Name = "uiLine1";
            uiLine1.Size = new Size(507, 29);
            uiLine1.TabIndex = 8;
            uiLine1.Text = "测试结果";
            uiLine1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblElapsedTimeValue
            // 
            lblElapsedTimeValue.AutoSize = true;
            lblElapsedTimeValue.BackColor = Color.Transparent;
            lblElapsedTimeValue.Font = new Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lblElapsedTimeValue.ForeColor = Color.Red;
            lblElapsedTimeValue.Location = new Point(260, 33);
            lblElapsedTimeValue.Name = "lblElapsedTimeValue";
            lblElapsedTimeValue.Size = new Size(80, 22);
            lblElapsedTimeValue.TabIndex = 7;
            lblElapsedTimeValue.Text = "00:00:00";
            // 
            // lblElapsedTime
            // 
            lblElapsedTime.AutoSize = true;
            lblElapsedTime.BackColor = Color.Transparent;
            lblElapsedTime.Font = new Font("微软雅黑", 12F);
            lblElapsedTime.ForeColor = Color.FromArgb(235, 227, 221);
            lblElapsedTime.Location = new Point(180, 33);
            lblElapsedTime.Name = "lblElapsedTime";
            lblElapsedTime.Size = new Size(62, 21);
            lblElapsedTime.TabIndex = 6;
            lblElapsedTime.Text = "倒计时:";
            // 
            // txtTestResult
            // 
            txtTestResult.Font = new Font("微软雅黑", 12F);
            txtTestResult.ForeColor = Color.FromArgb(64, 64, 64);
            txtTestResult.ForeDisableColor = Color.FromArgb(64, 64, 64);
            txtTestResult.ForeReadOnlyColor = Color.FromArgb(64, 64, 64);
            txtTestResult.Location = new Point(180, 70);
            txtTestResult.Margin = new Padding(4, 5, 4, 5);
            txtTestResult.MinimumSize = new Size(1, 16);
            txtTestResult.Name = "txtTestResult";
            txtTestResult.Padding = new Padding(5);
            txtTestResult.ReadOnly = true;
            txtTestResult.ShowText = false;
            txtTestResult.Size = new Size(320, 26);
            txtTestResult.TabIndex = 5;
            txtTestResult.TextAlignment = ContentAlignment.MiddleLeft;
            txtTestResult.Watermark = "";
            // 
            // lblTestResultLabel
            // 
            lblTestResultLabel.AutoSize = true;
            lblTestResultLabel.BackColor = Color.Transparent;
            lblTestResultLabel.Font = new Font("微软雅黑", 12F);
            lblTestResultLabel.ForeColor = Color.FromArgb(235, 227, 221);
            lblTestResultLabel.Location = new Point(20, 73);
            lblTestResultLabel.Name = "lblTestResultLabel";
            lblTestResultLabel.Size = new Size(110, 21);
            lblTestResultLabel.TabIndex = 4;
            lblTestResultLabel.Text = "绝缘测试状态:";
            // 
            // txtResistanceValue
            // 
            txtResistanceValue.Font = new Font("微软雅黑", 12F);
            txtResistanceValue.ForeColor = Color.FromArgb(64, 64, 64);
            txtResistanceValue.ForeDisableColor = Color.FromArgb(64, 64, 64);
            txtResistanceValue.ForeReadOnlyColor = Color.FromArgb(64, 64, 64);
            txtResistanceValue.Location = new Point(180, 110);
            txtResistanceValue.Margin = new Padding(4, 5, 4, 5);
            txtResistanceValue.MinimumSize = new Size(1, 16);
            txtResistanceValue.Name = "txtResistanceValue";
            txtResistanceValue.Padding = new Padding(5);
            txtResistanceValue.ReadOnly = true;
            txtResistanceValue.ShowText = false;
            txtResistanceValue.Size = new Size(250, 26);
            txtResistanceValue.TabIndex = 3;
            txtResistanceValue.TextAlignment = ContentAlignment.MiddleLeft;
            txtResistanceValue.Watermark = "";
            // 
            // lblResistanceValue
            // 
            lblResistanceValue.AutoSize = true;
            lblResistanceValue.BackColor = Color.Transparent;
            lblResistanceValue.Font = new Font("微软雅黑", 12F);
            lblResistanceValue.ForeColor = Color.FromArgb(235, 227, 221);
            lblResistanceValue.Location = new Point(20, 113);
            lblResistanceValue.Name = "lblResistanceValue";
            lblResistanceValue.Size = new Size(126, 21);
            lblResistanceValue.TabIndex = 2;
            lblResistanceValue.Text = "绝缘电阻测试值:";
            // 
            // txtTestConclusion
            // 
            txtTestConclusion.Font = new Font("微软雅黑", 12F);
            txtTestConclusion.ForeColor = Color.FromArgb(64, 64, 64);
            txtTestConclusion.ForeDisableColor = Color.FromArgb(64, 64, 64);
            txtTestConclusion.ForeReadOnlyColor = Color.FromArgb(64, 64, 64);
            txtTestConclusion.Location = new Point(180, 150);
            txtTestConclusion.Margin = new Padding(4, 5, 4, 5);
            txtTestConclusion.MinimumSize = new Size(1, 16);
            txtTestConclusion.Multiline = true;
            txtTestConclusion.Name = "txtTestConclusion";
            txtTestConclusion.Padding = new Padding(5);
            txtTestConclusion.ReadOnly = true;
            txtTestConclusion.ShowText = false;
            txtTestConclusion.Size = new Size(320, 40);
            txtTestConclusion.TabIndex = 1;
            txtTestConclusion.TextAlignment = ContentAlignment.MiddleLeft;
            txtTestConclusion.Watermark = "";
            // 
            // lblTestConclusion
            // 
            lblTestConclusion.AutoSize = true;
            lblTestConclusion.BackColor = Color.Transparent;
            lblTestConclusion.Font = new Font("微软雅黑", 12F);
            lblTestConclusion.ForeColor = Color.FromArgb(235, 227, 221);
            lblTestConclusion.Location = new Point(20, 153);
            lblTestConclusion.Name = "lblTestConclusion";
            lblTestConclusion.Size = new Size(142, 21);
            lblTestConclusion.TabIndex = 0;
            lblTestConclusion.Text = "绝缘电阻测试结果:";
            // 
            // grpConnection
            // 
            grpConnection.BackColor = Color.Transparent;
            grpConnection.Controls.Add(cmbComPort);
            grpConnection.Controls.Add(lblComPort);
            grpConnection.Controls.Add(btnConnect);
            grpConnection.Controls.Add(btnDisconnect);
            grpConnection.Controls.Add(lblConnectionStatus);
            grpConnection.FillColor = Color.FromArgb(49, 54, 64);
            grpConnection.FillColor2 = Color.FromArgb(49, 54, 64);
            grpConnection.FillDisableColor = Color.FromArgb(49, 54, 64);
            grpConnection.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            grpConnection.ForeColor = Color.FromArgb(235, 227, 221);
            grpConnection.Location = new Point(12, 49);
            grpConnection.Margin = new Padding(4, 5, 4, 5);
            grpConnection.MinimumSize = new Size(1, 1);
            grpConnection.Name = "grpConnection";
            grpConnection.Padding = new Padding(0, 32, 0, 0);
            grpConnection.Radius = 10;
            grpConnection.RectColor = Color.FromArgb(49, 54, 64);
            grpConnection.RectDisableColor = Color.FromArgb(49, 54, 64);
            grpConnection.Size = new Size(560, 70);
            grpConnection.TabIndex = 1;
            grpConnection.TabStop = false;
            grpConnection.Text = null;
            grpConnection.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // cmbComPort
            // 
            cmbComPort.DataSource = null;
            cmbComPort.DropDownStyle = UIDropDownStyle.DropDownList;
            cmbComPort.FillColor = Color.FromArgb(42, 47, 55);
            cmbComPort.FillColor2 = Color.FromArgb(42, 47, 55);
            cmbComPort.FillDisableColor = Color.FromArgb(42, 47, 55);
            cmbComPort.Font = new Font("微软雅黑", 12F);
            cmbComPort.ForeColor = Color.FromArgb(235, 227, 221);
            cmbComPort.ForeDisableColor = Color.FromArgb(235, 227, 221);
            cmbComPort.FormattingEnabled = true;
            cmbComPort.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbComPort.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbComPort.Location = new Point(100, 22);
            cmbComPort.Margin = new Padding(4, 5, 4, 5);
            cmbComPort.MinimumSize = new Size(63, 0);
            cmbComPort.Name = "cmbComPort";
            cmbComPort.Padding = new Padding(0, 0, 30, 2);
            cmbComPort.RectColor = Color.Gray;
            cmbComPort.RectDisableColor = Color.FromArgb(42, 47, 55);
            cmbComPort.Size = new Size(100, 24);
            cmbComPort.SymbolSize = 24;
            cmbComPort.TabIndex = 1;
            cmbComPort.TextAlignment = ContentAlignment.MiddleLeft;
            cmbComPort.Watermark = "";
            // 
            // lblComPort
            // 
            lblComPort.AutoSize = true;
            lblComPort.BackColor = Color.Transparent;
            lblComPort.Font = new Font("微软雅黑", 12F);
            lblComPort.ForeColor = Color.FromArgb(235, 227, 221);
            lblComPort.Location = new Point(20, 22);
            lblComPort.Name = "lblComPort";
            lblComPort.Size = new Size(62, 21);
            lblComPort.TabIndex = 0;
            lblComPort.Text = "串口号:";
            // 
            // btnConnect
            // 
            btnConnect.FillColor = Color.FromArgb(70, 75, 85);
            btnConnect.FillColor2 = Color.FromArgb(70, 75, 85);
            btnConnect.FillDisableColor = Color.FromArgb(70, 75, 85);
            btnConnect.Font = new Font("微软雅黑", 12F);
            btnConnect.Location = new Point(220, 22);
            btnConnect.MinimumSize = new Size(1, 1);
            btnConnect.Name = "btnConnect";
            btnConnect.RectColor = Color.FromArgb(70, 75, 85);
            btnConnect.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnConnect.Size = new Size(80, 28);
            btnConnect.TabIndex = 2;
            btnConnect.Text = "连接";
            btnConnect.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.FillColor = Color.FromArgb(70, 75, 85);
            btnDisconnect.FillColor2 = Color.FromArgb(70, 75, 85);
            btnDisconnect.FillDisableColor = Color.FromArgb(70, 75, 85);
            btnDisconnect.Font = new Font("微软雅黑", 12F);
            btnDisconnect.Location = new Point(310, 22);
            btnDisconnect.MinimumSize = new Size(1, 1);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.RectColor = Color.FromArgb(70, 75, 85);
            btnDisconnect.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnDisconnect.Size = new Size(80, 28);
            btnDisconnect.TabIndex = 3;
            btnDisconnect.Text = "断开";
            btnDisconnect.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // lblConnectionStatus
            // 
            lblConnectionStatus.AutoSize = true;
            lblConnectionStatus.BackColor = Color.Transparent;
            lblConnectionStatus.Font = new Font("微软雅黑", 12F);
            lblConnectionStatus.ForeColor = Color.Red;
            lblConnectionStatus.Location = new Point(410, 25);
            lblConnectionStatus.Name = "lblConnectionStatus";
            lblConnectionStatus.Size = new Size(58, 21);
            lblConnectionStatus.TabIndex = 4;
            lblConnectionStatus.Text = "未连接";
            // 
            // timerTest
            // 
            timerTest.Interval = 1000;
            timerTest.Tick += timerTest_Tick;
            // 
            // FrmTH2683A
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(42, 47, 55);
            ClientSize = new Size(590, 647);
            Controls.Add(grpConnection);
            Controls.Add(grpTest);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTH2683A";
            RectColor = Color.FromArgb(42, 47, 55);
            ShowIcon = false;
            Text = "绝缘电阻测试仪";
            TitleColor = Color.FromArgb(47, 55, 64);
            TitleFont = new Font("思源黑体 CN Heavy", 15F, FontStyle.Bold);
            TitleForeColor = Color.FromArgb(239, 154, 78);
            ZoomScaleRect = new Rectangle(15, 15, 590, 625);
            FormClosing += FrmTH2683A_FormClosing;
            Load += FrmTH2683A_Load;
            grpTest.ResumeLayout(false);
            grpParams.ResumeLayout(false);
            grpParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTestVoltage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTestTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numResistanceLimit).EndInit();
            grpControl.ResumeLayout(false);
            grpResult.ResumeLayout(false);
            grpResult.PerformLayout();
            grpConnection.ResumeLayout(false);
            grpConnection.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel grpTest;
        private Sunny.UI.UIPanel grpParams;
        private System.Windows.Forms.NumericUpDown numTestVoltage;
        private Sunny.UI.UILabel lblTestVoltage;
        private System.Windows.Forms.NumericUpDown numTestTime;
        private Sunny.UI.UILabel lblTestTime;
        private System.Windows.Forms.NumericUpDown numResistanceLimit;
        private Sunny.UI.UILabel lblResistanceLimit;
        private Sunny.UI.UIPanel grpControl;
        private Sunny.UI.UIButton btnStartTest;
        private Sunny.UI.UIButton btnStopTest;
        private Sunny.UI.UIPanel grpResult;
        private Sunny.UI.UILabel lblElapsedTime;
        private Sunny.UI.UITextBox txtTestResult;
        private Sunny.UI.UILabel lblTestResultLabel;
        private Sunny.UI.UITextBox txtResistanceValue;
        private Sunny.UI.UILabel lblResistanceValue;
        private Sunny.UI.UITextBox txtTestConclusion;
        private Sunny.UI.UILabel lblTestConclusion;
        private Sunny.UI.UIPanel grpConnection;
        private Sunny.UI.UIComboBox cmbComPort;
        private Sunny.UI.UILabel lblComPort;
        private Sunny.UI.UIButton btnConnect;
        private Sunny.UI.UIButton btnDisconnect;
        private Sunny.UI.UILabel lblConnectionStatus;
        private Sunny.UI.UILabel lblElapsedTimeValue;
        private Sunny.UI.UILabel lblTestCount;
        private System.Windows.Forms.Timer timerTest;
        private UILine uiLine1;
        private UILine uiLine3;
        private UILine uiLine4;
    }
}