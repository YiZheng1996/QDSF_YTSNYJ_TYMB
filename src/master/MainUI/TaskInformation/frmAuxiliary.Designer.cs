namespace MainUI.TaskInformation
{
    partial class frmAuxiliary
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
            uiPanel1 = new UIPanel();
            dateComMutualTime = new AntdUI.DatePicker();
            btnClose = new UIButton();
            ComQualityResult = new AntdUI.Select();
            dateQualityTime = new AntdUI.DatePicker();
            ComMutualResult = new AntdUI.Select();
            btnOK = new UIButton();
            uiLabel1 = new UILabel();
            uiLabel2 = new UILabel();
            uiLabel3 = new UILabel();
            uiLabel4 = new UILabel();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(dateComMutualTime);
            uiPanel1.Controls.Add(btnClose);
            uiPanel1.Controls.Add(ComQualityResult);
            uiPanel1.Controls.Add(dateQualityTime);
            uiPanel1.Controls.Add(ComMutualResult);
            uiPanel1.Controls.Add(btnOK);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(uiLabel3);
            uiPanel1.Controls.Add(uiLabel4);
            uiPanel1.FillColor = Color.FromArgb(49, 54, 64);
            uiPanel1.FillColor2 = Color.FromArgb(49, 54, 64);
            uiPanel1.FillDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.ForeColor = Color.FromArgb(49, 54, 64);
            uiPanel1.ForeDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Location = new Point(35, 57);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.FromArgb(49, 54, 64);
            uiPanel1.RectDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Size = new Size(683, 269);
            uiPanel1.TabIndex = 409;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dateComMutualTime
            // 
            dateComMutualTime.BackColor = Color.FromArgb(42, 47, 55);
            dateComMutualTime.Font = new Font("Microsoft YaHei UI", 13F);
            dateComMutualTime.ForeColor = Color.FromArgb(235, 227, 221);
            dateComMutualTime.Format = "yyyy-MM-dd HH:mm:ss";
            dateComMutualTime.Location = new Point(21, 133);
            dateComMutualTime.Name = "dateComMutualTime";
            dateComMutualTime.PlaceholderText = "请选择";
            dateComMutualTime.Radius = 2;
            dateComMutualTime.SelectionColor = Color.FromArgb(239, 154, 78);
            dateComMutualTime.Size = new Size(295, 43);
            dateComMutualTime.TabIndex = 0;
            dateComMutualTime.Text = "请选择";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.DialogResult = DialogResult.No;
            btnClose.FillColor = Color.FromArgb(70, 75, 85);
            btnClose.FillColor2 = Color.FromArgb(70, 75, 85);
            btnClose.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(235, 227, 221);
            btnClose.Location = new Point(375, 210);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.RectColor = Color.FromArgb(70, 75, 85);
            btnClose.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnClose.Size = new Size(175, 37);
            btnClose.TabIndex = 454;
            btnClose.Text = "取消";
            btnClose.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnClose.TipsText = "1";
            btnClose.Click += btnClose_Click;
            // 
            // ComQualityResult
            // 
            ComQualityResult.BackColor = Color.FromArgb(42, 47, 55);
            ComQualityResult.Font = new Font("Microsoft YaHei UI", 13F);
            ComQualityResult.ForeColor = Color.FromArgb(235, 227, 221);
            ComQualityResult.Items.AddRange(new object[] { "不合格", "合格" });
            ComQualityResult.List = true;
            ComQualityResult.Location = new Point(368, 51);
            ComQualityResult.MaxCount = 10;
            ComQualityResult.Name = "ComQualityResult";
            ComQualityResult.PlaceholderText = "";
            ComQualityResult.Radius = 0;
            ComQualityResult.SelectionColor = Color.FromArgb(239, 154, 78);
            ComQualityResult.Size = new Size(219, 35);
            ComQualityResult.TabIndex = 453;
            ComQualityResult.Text = "--请选择--";
            ComQualityResult.TextAlign = HorizontalAlignment.Center;
            // 
            // dateQualityTime
            // 
            dateQualityTime.BackColor = Color.FromArgb(42, 47, 55);
            dateQualityTime.Font = new Font("Microsoft YaHei UI", 13F);
            dateQualityTime.ForeColor = Color.FromArgb(235, 227, 221);
            dateQualityTime.Format = "yyyy-MM-dd HH:mm:ss";
            dateQualityTime.Location = new Point(368, 133);
            dateQualityTime.Name = "dateQualityTime";
            dateQualityTime.PlaceholderText = "请选择";
            dateQualityTime.Radius = 2;
            dateQualityTime.SelectionColor = Color.FromArgb(239, 154, 78);
            dateQualityTime.Size = new Size(295, 43);
            dateQualityTime.TabIndex = 1;
            dateQualityTime.Text = "请选择";
            // 
            // ComMutualResult
            // 
            ComMutualResult.BackColor = Color.FromArgb(42, 47, 55);
            ComMutualResult.Font = new Font("Microsoft YaHei UI", 13F);
            ComMutualResult.ForeColor = Color.FromArgb(235, 227, 221);
            ComMutualResult.Items.AddRange(new object[] { "不合格", "合格" });
            ComMutualResult.List = true;
            ComMutualResult.Location = new Point(21, 51);
            ComMutualResult.MaxCount = 10;
            ComMutualResult.Name = "ComMutualResult";
            ComMutualResult.PlaceholderText = "";
            ComMutualResult.Radius = 0;
            ComMutualResult.SelectionColor = Color.FromArgb(239, 154, 78);
            ComMutualResult.Size = new Size(213, 35);
            ComMutualResult.TabIndex = 452;
            ComMutualResult.Text = "--请选择--";
            ComMutualResult.TextAlign = HorizontalAlignment.Center;
            // 
            // btnOK
            // 
            btnOK.Cursor = Cursors.Hand;
            btnOK.FillColor = Color.FromArgb(70, 75, 85);
            btnOK.FillColor2 = Color.FromArgb(70, 75, 85);
            btnOK.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            btnOK.ForeColor = Color.FromArgb(235, 227, 221);
            btnOK.Location = new Point(95, 210);
            btnOK.MinimumSize = new Size(1, 1);
            btnOK.Name = "btnOK";
            btnOK.RectColor = Color.FromArgb(70, 75, 85);
            btnOK.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnOK.Size = new Size(175, 37);
            btnOK.TabIndex = 451;
            btnOK.Text = "确认";
            btnOK.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnOK.TipsText = "1";
            btnOK.Click += btnOK_Click;
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel1.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel1.Location = new Point(21, 23);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(95, 23);
            uiLabel1.TabIndex = 427;
            uiLabel1.Text = "互检结果";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            uiLabel2.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel2.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel2.Location = new Point(368, 23);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(95, 23);
            uiLabel2.TabIndex = 429;
            uiLabel2.Text = "质检结果";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            uiLabel3.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel3.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel3.Location = new Point(21, 105);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(95, 23);
            uiLabel3.TabIndex = 431;
            uiLabel3.Text = "互检时间";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = Color.Transparent;
            uiLabel4.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel4.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel4.Location = new Point(368, 105);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(95, 23);
            uiLabel4.TabIndex = 433;
            uiLabel4.Text = "质检时间";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmAuxiliary
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(42, 47, 55);
            ClientSize = new Size(752, 349);
            ControlBox = false;
            Controls.Add(uiPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAuxiliary";
            RectColor = Color.FromArgb(47, 55, 64);
            Text = "质检 互检";
            TitleColor = Color.FromArgb(47, 55, 64);
            TitleFont = new Font("思源黑体 CN Heavy", 15F, FontStyle.Bold);
            TitleForeColor = Color.FromArgb(239, 154, 78);
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UIPanel uiPanel1;
        private AntdUI.Select ComMutualResult;
        private UIButton btnOK;
        private UILabel uiLabel1;
        private UILabel uiLabel2;
        private UILabel uiLabel4;
        private AntdUI.DatePicker dateQualityTime;
        private UIButton btnClose;
        private AntdUI.Select ComQualityResult;
        private AntdUI.DatePicker dateComMutualTime;
        private UILabel uiLabel3;
    }
}