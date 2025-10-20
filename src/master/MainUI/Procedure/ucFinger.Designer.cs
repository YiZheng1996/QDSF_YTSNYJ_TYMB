namespace MainUI.Procedure
{
    partial class ucFinger
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new UIGroupBox();
            txtJobNumber = new UITextBox();
            uiLabel2 = new UILabel();
            cboUsername = new UIComboBox();
            textRes = new UITextBox();
            uiPanel1 = new UIPanel();
            picFPImg = new PictureBox();
            uiLabel1 = new UILabel();
            btnDelFinger = new UIButton();
            btnAddFinger = new UIButton();
            groupBox1.SuspendLayout();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFPImg).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtJobNumber);
            groupBox1.Controls.Add(uiLabel2);
            groupBox1.Controls.Add(cboUsername);
            groupBox1.Controls.Add(textRes);
            groupBox1.Controls.Add(uiPanel1);
            groupBox1.Controls.Add(uiLabel1);
            groupBox1.Controls.Add(btnDelFinger);
            groupBox1.Controls.Add(btnAddFinger);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.FillColor = Color.FromArgb(42, 47, 55);
            groupBox1.FillColor2 = Color.FromArgb(42, 47, 55);
            groupBox1.FillDisableColor = Color.FromArgb(42, 47, 55);
            groupBox1.Font = new Font("思源黑体 CN Bold", 14F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(235, 227, 221);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.MinimumSize = new Size(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0, 32, 0, 0);
            groupBox1.RectColor = Color.FromArgb(42, 47, 55);
            groupBox1.RectDisableColor = Color.FromArgb(42, 47, 55);
            groupBox1.Size = new Size(650, 650);
            groupBox1.TabIndex = 399;
            groupBox1.Text = "指纹管理";
            groupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txtJobNumber
            // 
            txtJobNumber.FillColor = Color.FromArgb(49, 54, 64);
            txtJobNumber.FillColor2 = Color.FromArgb(49, 54, 64);
            txtJobNumber.FillDisableColor = Color.FromArgb(49, 54, 64);
            txtJobNumber.FillReadOnlyColor = Color.FromArgb(49, 54, 64);
            txtJobNumber.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            txtJobNumber.ForeColor = Color.White;
            txtJobNumber.ForeDisableColor = Color.White;
            txtJobNumber.ForeReadOnlyColor = Color.White;
            txtJobNumber.Location = new Point(120, 131);
            txtJobNumber.Margin = new Padding(4, 5, 4, 5);
            txtJobNumber.MinimumSize = new Size(1, 16);
            txtJobNumber.Name = "txtJobNumber";
            txtJobNumber.Padding = new Padding(5);
            txtJobNumber.RectColor = Color.FromArgb(49, 54, 64);
            txtJobNumber.RectDisableColor = Color.FromArgb(49, 54, 64);
            txtJobNumber.RectReadOnlyColor = Color.FromArgb(49, 54, 64);
            txtJobNumber.ShowText = false;
            txtJobNumber.Size = new Size(184, 33);
            txtJobNumber.TabIndex = 405;
            txtJobNumber.TextAlignment = ContentAlignment.MiddleLeft;
            txtJobNumber.Watermark = "工号";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            uiLabel2.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel2.Location = new Point(53, 131);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(75, 23);
            uiLabel2.TabIndex = 404;
            uiLabel2.Text = "工 号";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboUsername
            // 
            cboUsername.DataSource = null;
            cboUsername.DropDownStyle = UIDropDownStyle.DropDownList;
            cboUsername.FillColor = Color.FromArgb(49, 54, 64);
            cboUsername.FillColor2 = Color.FromArgb(49, 54, 64);
            cboUsername.FillDisableColor = Color.FromArgb(235, 227, 221);
            cboUsername.FilterMaxCount = 50;
            cboUsername.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            cboUsername.ForeColor = Color.FromArgb(235, 227, 221);
            cboUsername.ForeDisableColor = Color.FromArgb(235, 227, 221);
            cboUsername.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboUsername.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "11", "12", "13", "14", "15", "16" });
            cboUsername.ItemSelectForeColor = Color.FromArgb(49, 54, 64);
            cboUsername.Location = new Point(120, 75);
            cboUsername.Margin = new Padding(4, 5, 4, 5);
            cboUsername.MinimumSize = new Size(63, 0);
            cboUsername.Name = "cboUsername";
            cboUsername.Padding = new Padding(0, 0, 30, 2);
            cboUsername.RadiusSides = UICornerRadiusSides.None;
            cboUsername.RectColor = Color.FromArgb(49, 54, 64);
            cboUsername.RectDisableColor = Color.FromArgb(49, 54, 64);
            cboUsername.RectSides = ToolStripStatusLabelBorderSides.Bottom;
            cboUsername.Size = new Size(184, 33);
            cboUsername.SymbolSize = 24;
            cboUsername.TabIndex = 399;
            cboUsername.TextAlignment = ContentAlignment.MiddleLeft;
            cboUsername.Watermark = "请下拉选择";
            cboUsername.SelectedIndexChanged += cboUsername_SelectedIndexChanged;
            // 
            // textRes
            // 
            textRes.Cursor = Cursors.IBeam;
            textRes.FillColor = Color.FromArgb(49, 54, 64);
            textRes.FillColor2 = Color.FromArgb(49, 54, 64);
            textRes.FillDisableColor = Color.FromArgb(49, 54, 64);
            textRes.FillReadOnlyColor = Color.FromArgb(49, 54, 64);
            textRes.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            textRes.ForeColor = Color.FromArgb(235, 227, 221);
            textRes.ForeDisableColor = Color.FromArgb(48, 48, 48);
            textRes.ForeReadOnlyColor = Color.FromArgb(48, 48, 48);
            textRes.Location = new Point(68, 423);
            textRes.Margin = new Padding(4, 5, 4, 5);
            textRes.MinimumSize = new Size(1, 16);
            textRes.Multiline = true;
            textRes.Name = "textRes";
            textRes.Padding = new Padding(5);
            textRes.ReadOnly = true;
            textRes.RectColor = Color.FromArgb(49, 54, 64);
            textRes.RectDisableColor = Color.FromArgb(49, 54, 64);
            textRes.RectReadOnlyColor = Color.FromArgb(49, 54, 64);
            textRes.ShowText = false;
            textRes.Size = new Size(535, 155);
            textRes.Style = UIStyle.Custom;
            textRes.StyleCustomMode = true;
            textRes.TabIndex = 402;
            textRes.TextAlignment = ContentAlignment.MiddleLeft;
            textRes.Watermark = "";
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(picFPImg);
            uiPanel1.FillColor = Color.FromArgb(49, 54, 64);
            uiPanel1.FillColor2 = Color.FromArgb(49, 54, 64);
            uiPanel1.FillDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiPanel1.ForeColor = Color.FromArgb(235, 227, 221);
            uiPanel1.Location = new Point(337, 75);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.RectColor = Color.FromArgb(49, 54, 64);
            uiPanel1.RectDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Size = new Size(270, 263);
            uiPanel1.TabIndex = 401;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // picFPImg
            // 
            picFPImg.BackColor = Color.FromArgb(49, 54, 64);
            picFPImg.Dock = DockStyle.Fill;
            picFPImg.Location = new Point(0, 0);
            picFPImg.Name = "picFPImg";
            picFPImg.Size = new Size(270, 263);
            picFPImg.TabIndex = 0;
            picFPImg.TabStop = false;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            uiLabel1.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel1.Location = new Point(53, 78);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(75, 23);
            uiLabel1.TabIndex = 400;
            uiLabel1.Text = "用户名";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDelFinger
            // 
            btnDelFinger.Cursor = Cursors.Hand;
            btnDelFinger.FillColor = Color.FromArgb(70, 75, 85);
            btnDelFinger.FillColor2 = Color.FromArgb(70, 75, 85);
            btnDelFinger.FillDisableColor = Color.FromArgb(70, 75, 85);
            btnDelFinger.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            btnDelFinger.ForeColor = Color.FromArgb(235, 227, 221);
            btnDelFinger.Location = new Point(95, 281);
            btnDelFinger.MinimumSize = new Size(1, 1);
            btnDelFinger.Name = "btnDelFinger";
            btnDelFinger.RectColor = Color.FromArgb(70, 75, 85);
            btnDelFinger.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnDelFinger.Size = new Size(170, 50);
            btnDelFinger.TabIndex = 394;
            btnDelFinger.Text = "删除指纹";
            btnDelFinger.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDelFinger.TipsText = "1";
            btnDelFinger.Click += btnDelFinger_Click;
            // 
            // btnAddFinger
            // 
            btnAddFinger.Cursor = Cursors.Hand;
            btnAddFinger.FillColor = Color.FromArgb(70, 75, 85);
            btnAddFinger.FillColor2 = Color.FromArgb(70, 75, 85);
            btnAddFinger.FillDisableColor = Color.FromArgb(70, 75, 85);
            btnAddFinger.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            btnAddFinger.ForeColor = Color.FromArgb(235, 227, 221);
            btnAddFinger.Location = new Point(95, 205);
            btnAddFinger.MinimumSize = new Size(1, 1);
            btnAddFinger.Name = "btnAddFinger";
            btnAddFinger.RectColor = Color.FromArgb(70, 75, 85);
            btnAddFinger.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnAddFinger.Size = new Size(170, 50);
            btnAddFinger.TabIndex = 393;
            btnAddFinger.Text = "添加指纹";
            btnAddFinger.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnAddFinger.TipsText = "1";
            btnAddFinger.Click += btnAddFinger_Click;
            // 
            // ucFinger
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 47, 55);
            Controls.Add(groupBox1);
            Name = "ucFinger";
            Size = new Size(650, 650);
            Load += ucFinger_Load;
            groupBox1.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFPImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIGroupBox groupBox1;
        private Sunny.UI.UIButton btnDelFinger;
        private Sunny.UI.UIButton btnAddFinger;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cboUsername;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITextBox textRes;
        private System.Windows.Forms.PictureBox picFPImg;
        private UILabel uiLabel2;
        private UITextBox txtJobNumber;
    }
}
