namespace MainUI.Procedure.User
{
    partial class frmUserEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserEdit));
            uiLabel2 = new UILabel();
            comboBox1 = new UIComboBox();
            uiLabel3 = new UILabel();
            txtUserName = new UITextBox();
            uiLabel1 = new UILabel();
            btnCancel = new UIButton();
            btnSave = new UIButton();
            txtJobNumber = new UITextBox();
            txtDepName = new UITextBox();
            uiLabel4 = new UILabel();
            SuspendLayout();
            // 
            // uiLabel2
            // 
            resources.ApplyResources(uiLabel2, "uiLabel2");
            uiLabel2.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel2.Name = "uiLabel2";
            // 
            // comboBox1
            // 
            comboBox1.DataSource = null;
            comboBox1.DropDownStyle = UIDropDownStyle.DropDownList;
            comboBox1.FillColor = Color.FromArgb(49, 54, 64);
            comboBox1.FillColor2 = Color.FromArgb(49, 54, 64);
            comboBox1.FilterMaxCount = 50;
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.ForeColor = Color.FromArgb(235, 227, 221);
            comboBox1.ForeDisableColor = Color.FromArgb(235, 227, 221);
            comboBox1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1"), resources.GetString("comboBox1.Items2"), resources.GetString("comboBox1.Items3"), resources.GetString("comboBox1.Items4"), resources.GetString("comboBox1.Items5"), resources.GetString("comboBox1.Items6"), resources.GetString("comboBox1.Items7"), resources.GetString("comboBox1.Items8"), resources.GetString("comboBox1.Items9"), resources.GetString("comboBox1.Items10"), resources.GetString("comboBox1.Items11") });
            comboBox1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            comboBox1.Name = "comboBox1";
            comboBox1.RadiusSides = UICornerRadiusSides.None;
            comboBox1.RectColor = Color.FromArgb(49, 54, 64);
            comboBox1.RectDisableColor = Color.FromArgb(49, 54, 64);
            comboBox1.RectSides = ToolStripStatusLabelBorderSides.Bottom;
            comboBox1.SymbolSize = 24;
            comboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            comboBox1.Watermark = "请选择";
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            resources.ApplyResources(uiLabel3, "uiLabel3");
            uiLabel3.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel3.Name = "uiLabel3";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.FromArgb(49, 54, 64);
            txtUserName.Cursor = Cursors.IBeam;
            txtUserName.FillColor = Color.FromArgb(49, 54, 64);
            txtUserName.FillColor2 = Color.FromArgb(49, 54, 64);
            txtUserName.FillDisableColor = Color.FromArgb(49, 54, 64);
            txtUserName.FillReadOnlyColor = Color.FromArgb(49, 54, 64);
            resources.ApplyResources(txtUserName, "txtUserName");
            txtUserName.ForeColor = Color.FromArgb(235, 227, 221);
            txtUserName.ForeDisableColor = Color.FromArgb(235, 227, 221);
            txtUserName.Name = "txtUserName";
            txtUserName.RectColor = Color.FromArgb(49, 54, 64);
            txtUserName.RectDisableColor = Color.FromArgb(49, 54, 64);
            txtUserName.RectReadOnlyColor = Color.FromArgb(49, 54, 64);
            txtUserName.ShowText = false;
            txtUserName.TextAlignment = ContentAlignment.MiddleLeft;
            txtUserName.Watermark = "请输入";
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            resources.ApplyResources(uiLabel1, "uiLabel1");
            uiLabel1.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel1.Name = "uiLabel1";
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
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.FillColor = Color.FromArgb(70, 75, 85);
            btnSave.FillColor2 = Color.FromArgb(70, 75, 85);
            btnSave.FillDisableColor = Color.FromArgb(70, 75, 85);
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.ForeColor = Color.FromArgb(235, 227, 221);
            btnSave.Name = "btnSave";
            btnSave.RectColor = Color.FromArgb(70, 75, 85);
            btnSave.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnSave.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnSave.TipsText = "1";
            btnSave.Click += btnSave_Click;
            // 
            // txtJobNumber
            // 
            txtJobNumber.Cursor = Cursors.IBeam;
            txtJobNumber.FillColor = Color.FromArgb(49, 54, 64);
            txtJobNumber.FillColor2 = Color.FromArgb(49, 54, 64);
            txtJobNumber.FillDisableColor = Color.FromArgb(243, 249, 255);
            txtJobNumber.FillReadOnlyColor = Color.FromArgb(243, 249, 255);
            resources.ApplyResources(txtJobNumber, "txtJobNumber");
            txtJobNumber.ForeColor = Color.FromArgb(235, 227, 221);
            txtJobNumber.ForeDisableColor = Color.FromArgb(235, 227, 221);
            txtJobNumber.Name = "txtJobNumber";
            txtJobNumber.RectColor = Color.FromArgb(49, 54, 64);
            txtJobNumber.RectDisableColor = Color.FromArgb(49, 54, 64);
            txtJobNumber.RectReadOnlyColor = Color.FromArgb(80, 160, 255);
            txtJobNumber.ShowText = false;
            txtJobNumber.TextAlignment = ContentAlignment.MiddleLeft;
            txtJobNumber.Watermark = "请输入";
            // 
            // txtDepName
            // 
            txtDepName.Cursor = Cursors.IBeam;
            txtDepName.FillColor = Color.FromArgb(49, 54, 64);
            txtDepName.FillColor2 = Color.FromArgb(49, 54, 64);
            txtDepName.FillDisableColor = Color.FromArgb(243, 249, 255);
            txtDepName.FillReadOnlyColor = Color.FromArgb(243, 249, 255);
            resources.ApplyResources(txtDepName, "txtDepName");
            txtDepName.ForeColor = Color.FromArgb(235, 227, 221);
            txtDepName.ForeDisableColor = Color.FromArgb(235, 227, 221);
            txtDepName.Name = "txtDepName";
            txtDepName.RectColor = Color.FromArgb(49, 54, 64);
            txtDepName.RectDisableColor = Color.FromArgb(49, 54, 64);
            txtDepName.RectReadOnlyColor = Color.FromArgb(80, 160, 255);
            txtDepName.ShowText = false;
            txtDepName.TextAlignment = ContentAlignment.MiddleLeft;
            txtDepName.Watermark = "请输入";
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = Color.Transparent;
            resources.ApplyResources(uiLabel4, "uiLabel4");
            uiLabel4.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel4.Name = "uiLabel4";
            // 
            // frmUserEdit
            // 
            AutoScaleMode = AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            BackColor = Color.FromArgb(42, 47, 55);
            Controls.Add(txtDepName);
            Controls.Add(uiLabel4);
            Controls.Add(txtJobNumber);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtUserName);
            Controls.Add(uiLabel1);
            Controls.Add(uiLabel3);
            Controls.Add(uiLabel2);
            Controls.Add(comboBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUserEdit";
            RectColor = Color.FromArgb(49, 54, 64);
            ShowIcon = false;
            ShowInTaskbar = false;
            TitleColor = Color.FromArgb(49, 54, 64);
            TitleFont = new Font("思源黑体 CN Heavy", 15F, FontStyle.Bold);
            TitleForeColor = Color.FromArgb(239, 154, 78);
            ZoomScaleRect = new Rectangle(15, 15, 280, 234);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox comboBox1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtUserName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton btnCancel;
        private Sunny.UI.UIButton btnSave;
        private UITextBox txtJobNumber;
        private UITextBox txtDepName;
        private UILabel uiLabel4;
    }
}