namespace MainUI
{
    partial class FrmChangePwd
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangePwd));
            uiLabel1 = new UILabel();
            txtPassword = new UITextBox();
            txtUsername = new UITextBox();
            txtNewPwd1 = new UITextBox();
            txtNewPwd2 = new UITextBox();
            uiLabel2 = new UILabel();
            uiLabel3 = new UILabel();
            uiLabel4 = new UILabel();
            btnCancel = new UIButton();
            btnSubmit = new UIButton();
            txtJobNumber = new UITextBox();
            uiLabel5 = new UILabel();
            uiPanel1 = new UIPanel();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            resources.ApplyResources(uiLabel1, "uiLabel1");
            uiLabel1.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel1.Name = "uiLabel1";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(49, 54, 64);
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.FillColor = Color.FromArgb(42, 47, 55);
            txtPassword.FillColor2 = Color.FromArgb(42, 47, 55);
            txtPassword.FillDisableColor = Color.FromArgb(42, 47, 55);
            txtPassword.FillReadOnlyColor = Color.FromArgb(42, 47, 55);
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.ForeColor = Color.FromArgb(235, 227, 221);
            txtPassword.ForeDisableColor = Color.FromArgb(235, 227, 221);
            txtPassword.ForeReadOnlyColor = Color.FromArgb(235, 227, 221);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.RectColor = Color.FromArgb(42, 47, 55);
            txtPassword.RectDisableColor = Color.FromArgb(42, 47, 55);
            txtPassword.RectReadOnlyColor = Color.FromArgb(42, 47, 55);
            txtPassword.ShowText = false;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "请输入";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(49, 54, 64);
            resources.ApplyResources(txtUsername, "txtUsername");
            txtUsername.FillColor = Color.FromArgb(42, 47, 55);
            txtUsername.FillColor2 = Color.FromArgb(42, 47, 55);
            txtUsername.FillDisableColor = Color.FromArgb(42, 47, 55);
            txtUsername.FillReadOnlyColor = Color.FromArgb(42, 47, 55);
            txtUsername.ForeColor = Color.FromArgb(235, 227, 221);
            txtUsername.ForeDisableColor = Color.FromArgb(235, 227, 221);
            txtUsername.ForeReadOnlyColor = Color.FromArgb(235, 227, 221);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.RectColor = Color.FromArgb(42, 47, 55);
            txtUsername.RectDisableColor = Color.FromArgb(42, 47, 55);
            txtUsername.RectReadOnlyColor = Color.FromArgb(42, 47, 55);
            txtUsername.ShowText = false;
            txtUsername.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsername.Watermark = "用户名";
            // 
            // txtNewPwd1
            // 
            txtNewPwd1.BackColor = Color.FromArgb(49, 54, 64);
            txtNewPwd1.Cursor = Cursors.IBeam;
            txtNewPwd1.FillColor = Color.FromArgb(42, 47, 55);
            txtNewPwd1.FillColor2 = Color.FromArgb(42, 47, 55);
            txtNewPwd1.FillDisableColor = Color.FromArgb(42, 47, 55);
            txtNewPwd1.FillReadOnlyColor = Color.FromArgb(42, 47, 55);
            resources.ApplyResources(txtNewPwd1, "txtNewPwd1");
            txtNewPwd1.ForeColor = Color.FromArgb(235, 227, 221);
            txtNewPwd1.ForeDisableColor = Color.FromArgb(235, 227, 221);
            txtNewPwd1.ForeReadOnlyColor = Color.FromArgb(235, 227, 221);
            txtNewPwd1.Name = "txtNewPwd1";
            txtNewPwd1.PasswordChar = '*';
            txtNewPwd1.RectColor = Color.FromArgb(42, 47, 55);
            txtNewPwd1.RectDisableColor = Color.FromArgb(42, 47, 55);
            txtNewPwd1.RectReadOnlyColor = Color.FromArgb(42, 47, 55);
            txtNewPwd1.ShowText = false;
            txtNewPwd1.TextAlignment = ContentAlignment.MiddleLeft;
            txtNewPwd1.Watermark = "请输入";
            // 
            // txtNewPwd2
            // 
            txtNewPwd2.BackColor = Color.FromArgb(49, 54, 64);
            txtNewPwd2.Cursor = Cursors.IBeam;
            txtNewPwd2.FillColor = Color.FromArgb(42, 47, 55);
            txtNewPwd2.FillColor2 = Color.FromArgb(42, 47, 55);
            txtNewPwd2.FillDisableColor = Color.FromArgb(42, 47, 55);
            txtNewPwd2.FillReadOnlyColor = Color.FromArgb(42, 47, 55);
            resources.ApplyResources(txtNewPwd2, "txtNewPwd2");
            txtNewPwd2.ForeColor = Color.FromArgb(235, 227, 221);
            txtNewPwd2.ForeDisableColor = Color.FromArgb(235, 227, 221);
            txtNewPwd2.ForeReadOnlyColor = Color.FromArgb(235, 227, 221);
            txtNewPwd2.Name = "txtNewPwd2";
            txtNewPwd2.PasswordChar = '*';
            txtNewPwd2.RectColor = Color.FromArgb(42, 47, 55);
            txtNewPwd2.RectDisableColor = Color.FromArgb(42, 47, 55);
            txtNewPwd2.RectReadOnlyColor = Color.FromArgb(42, 47, 55);
            txtNewPwd2.ShowText = false;
            txtNewPwd2.TextAlignment = ContentAlignment.MiddleLeft;
            txtNewPwd2.Watermark = "请输入";
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            resources.ApplyResources(uiLabel2, "uiLabel2");
            uiLabel2.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel2.Name = "uiLabel2";
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            resources.ApplyResources(uiLabel3, "uiLabel3");
            uiLabel3.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel3.Name = "uiLabel3";
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = Color.Transparent;
            resources.ApplyResources(uiLabel4, "uiLabel4");
            uiLabel4.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel4.Name = "uiLabel4";
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FillColor = Color.FromArgb(70, 75, 85);
            btnCancel.FillColor2 = Color.FromArgb(70, 75, 85);
            btnCancel.FillDisableColor = Color.FromArgb(70, 75, 85);
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.ForeColor = Color.FromArgb(235, 227, 221);
            btnCancel.Name = "btnCancel";
            btnCancel.RectColor = Color.FromArgb(70, 75, 85);
            btnCancel.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnCancel.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnCancel.TipsText = "1";
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FillColor = Color.FromArgb(70, 75, 85);
            btnSubmit.FillColor2 = Color.FromArgb(70, 75, 85);
            btnSubmit.FillDisableColor = Color.FromArgb(70, 75, 85);
            resources.ApplyResources(btnSubmit, "btnSubmit");
            btnSubmit.ForeColor = Color.FromArgb(235, 227, 221);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.RectColor = Color.FromArgb(70, 75, 85);
            btnSubmit.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnSubmit.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSubmit.TipsText = "1";
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // txtJobNumber
            // 
            txtJobNumber.BackColor = Color.FromArgb(49, 54, 64);
            resources.ApplyResources(txtJobNumber, "txtJobNumber");
            txtJobNumber.FillColor = Color.FromArgb(42, 47, 55);
            txtJobNumber.FillColor2 = Color.FromArgb(42, 47, 55);
            txtJobNumber.FillDisableColor = Color.FromArgb(42, 47, 55);
            txtJobNumber.FillReadOnlyColor = Color.FromArgb(42, 47, 55);
            txtJobNumber.ForeColor = Color.FromArgb(235, 227, 221);
            txtJobNumber.ForeDisableColor = Color.FromArgb(235, 227, 221);
            txtJobNumber.ForeReadOnlyColor = Color.FromArgb(235, 227, 221);
            txtJobNumber.Name = "txtJobNumber";
            txtJobNumber.ReadOnly = true;
            txtJobNumber.RectColor = Color.FromArgb(42, 47, 55);
            txtJobNumber.RectDisableColor = Color.FromArgb(42, 47, 55);
            txtJobNumber.RectReadOnlyColor = Color.FromArgb(42, 47, 55);
            txtJobNumber.ShowText = false;
            txtJobNumber.TextAlignment = ContentAlignment.MiddleLeft;
            txtJobNumber.Watermark = "工  号";
            // 
            // uiLabel5
            // 
            uiLabel5.BackColor = Color.Transparent;
            resources.ApplyResources(uiLabel5, "uiLabel5");
            uiLabel5.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel5.Name = "uiLabel5";
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(txtJobNumber);
            uiPanel1.Controls.Add(txtPassword);
            uiPanel1.Controls.Add(uiLabel5);
            uiPanel1.Controls.Add(txtUsername);
            uiPanel1.Controls.Add(btnCancel);
            uiPanel1.Controls.Add(txtNewPwd1);
            uiPanel1.Controls.Add(btnSubmit);
            uiPanel1.Controls.Add(txtNewPwd2);
            uiPanel1.Controls.Add(uiLabel4);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(uiLabel3);
            uiPanel1.FillColor = Color.FromArgb(49, 54, 64);
            uiPanel1.FillColor2 = Color.FromArgb(49, 54, 64);
            uiPanel1.FillDisableColor = Color.FromArgb(49, 54, 64);
            resources.ApplyResources(uiPanel1, "uiPanel1");
            uiPanel1.ForeColor = Color.FromArgb(49, 54, 64);
            uiPanel1.ForeDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.FromArgb(49, 54, 64);
            uiPanel1.RectDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FrmChangePwd
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(42, 47, 55);
            resources.ApplyResources(this, "$this");
            Controls.Add(uiPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmChangePwd";
            RectColor = Color.FromArgb(42, 47, 55);
            ShowIcon = false;
            ShowInTaskbar = false;
            TitleColor = Color.FromArgb(47, 55, 64);
            TitleFont = new Font("思源黑体 CN Heavy", 15F, FontStyle.Bold);
            TitleForeColor = Color.FromArgb(239, 154, 78);
            ZoomScaleRect = new Rectangle(15, 15, 294, 282);
            Load += frmChangePwd_Load;
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UITextBox txtNewPwd1;
        private Sunny.UI.UITextBox txtNewPwd2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIButton btnSubmit;
        private UITextBox txtJobNumber;
        private UILabel uiLabel5;
        private UIPanel uiPanel1;
    }
}