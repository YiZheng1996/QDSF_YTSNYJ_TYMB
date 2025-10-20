namespace MainUI.TaskInformation
{
    partial class frmUserSelection
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
            ComMutualPerson = new AntdUI.Select();
            btnOK = new UIButton();
            uiLabel1 = new UILabel();
            txtauxiliariesName4 = new UITextBox();
            uiLabel2 = new UILabel();
            uiLabel9 = new UILabel();
            txtmutualPersonName = new UITextBox();
            txtauxiliariesCode4 = new UITextBox();
            uiLabel3 = new UILabel();
            uiLabel10 = new UILabel();
            txtqualityPerson = new UITextBox();
            txtauxiliariesName3 = new UITextBox();
            uiLabel4 = new UILabel();
            uiLabel11 = new UILabel();
            txtqualityPersonName = new UITextBox();
            txtauxiliariesCode3 = new UITextBox();
            uiLabel12 = new UILabel();
            txtauxiliariesName2 = new UITextBox();
            uiLabel5 = new UILabel();
            txtauxiliariesCode2 = new UITextBox();
            uiLabel6 = new UILabel();
            txtauxiliariesName1 = new UITextBox();
            uiLabel7 = new UILabel();
            txtauxiliariesCode1 = new UITextBox();
            uiLabel8 = new UILabel();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(ComMutualPerson);
            uiPanel1.Controls.Add(btnOK);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(txtauxiliariesName4);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(uiLabel9);
            uiPanel1.Controls.Add(txtmutualPersonName);
            uiPanel1.Controls.Add(txtauxiliariesCode4);
            uiPanel1.Controls.Add(uiLabel3);
            uiPanel1.Controls.Add(uiLabel10);
            uiPanel1.Controls.Add(txtqualityPerson);
            uiPanel1.Controls.Add(txtauxiliariesName3);
            uiPanel1.Controls.Add(uiLabel4);
            uiPanel1.Controls.Add(uiLabel11);
            uiPanel1.Controls.Add(txtqualityPersonName);
            uiPanel1.Controls.Add(txtauxiliariesCode3);
            uiPanel1.Controls.Add(uiLabel12);
            uiPanel1.Controls.Add(txtauxiliariesName2);
            uiPanel1.Controls.Add(uiLabel5);
            uiPanel1.Controls.Add(txtauxiliariesCode2);
            uiPanel1.Controls.Add(uiLabel6);
            uiPanel1.Controls.Add(txtauxiliariesName1);
            uiPanel1.Controls.Add(uiLabel7);
            uiPanel1.Controls.Add(txtauxiliariesCode1);
            uiPanel1.Controls.Add(uiLabel8);
            uiPanel1.FillColor = Color.FromArgb(49, 54, 64);
            uiPanel1.FillColor2 = Color.FromArgb(49, 54, 64);
            uiPanel1.FillDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.ForeColor = Color.FromArgb(49, 54, 64);
            uiPanel1.ForeDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Location = new Point(19, 57);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.FromArgb(49, 54, 64);
            uiPanel1.RectDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Size = new Size(487, 574);
            uiPanel1.TabIndex = 408;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ComMutualPerson
            // 
            ComMutualPerson.BackColor = Color.FromArgb(42, 47, 55);
            ComMutualPerson.Font = new Font("Microsoft YaHei UI", 13F);
            ComMutualPerson.ForeColor = Color.FromArgb(235, 227, 221);
            ComMutualPerson.List = true;
            ComMutualPerson.Location = new Point(21, 51);
            ComMutualPerson.MaxCount = 10;
            ComMutualPerson.Name = "ComMutualPerson";
            ComMutualPerson.PlaceholderText = "--请选择--";
            ComMutualPerson.Radius = 0;
            ComMutualPerson.SelectionColor = Color.FromArgb(239, 154, 78);
            ComMutualPerson.Size = new Size(197, 35);
            ComMutualPerson.TabIndex = 452;
            ComMutualPerson.Text = "--请选择--";
            ComMutualPerson.TextAlign = HorizontalAlignment.Center;
            ComMutualPerson.SelectedIndexChanged += ComMutualPerson_SelectedIndexChanged;
            // 
            // btnOK
            // 
            btnOK.Cursor = Cursors.Hand;
            btnOK.FillColor = Color.FromArgb(70, 75, 85);
            btnOK.FillColor2 = Color.FromArgb(70, 75, 85);
            btnOK.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            btnOK.ForeColor = Color.FromArgb(235, 227, 221);
            btnOK.Location = new Point(156, 515);
            btnOK.MinimumSize = new Size(1, 1);
            btnOK.Name = "btnOK";
            btnOK.RectColor = Color.FromArgb(70, 75, 85);
            btnOK.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnOK.Size = new Size(175, 37);
            btnOK.TabIndex = 451;
            btnOK.Text = "确定";
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
            uiLabel1.Text = "互检人工号";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtauxiliariesName4
            // 
            txtauxiliariesName4.Cursor = Cursors.IBeam;
            txtauxiliariesName4.FillColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName4.FillColor2 = Color.FromArgb(43, 46, 57);
            txtauxiliariesName4.FillDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName4.FillReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName4.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            txtauxiliariesName4.ForeColor = Color.FromArgb(235, 227, 221);
            txtauxiliariesName4.Location = new Point(268, 457);
            txtauxiliariesName4.Margin = new Padding(4, 5, 4, 5);
            txtauxiliariesName4.MinimumSize = new Size(1, 16);
            txtauxiliariesName4.Name = "txtauxiliariesName4";
            txtauxiliariesName4.Padding = new Padding(5);
            txtauxiliariesName4.RectColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName4.RectDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName4.RectReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName4.ShowText = false;
            txtauxiliariesName4.Size = new Size(197, 29);
            txtauxiliariesName4.TabIndex = 450;
            txtauxiliariesName4.TextAlignment = ContentAlignment.MiddleLeft;
            txtauxiliariesName4.Watermark = "请输入";
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            uiLabel2.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel2.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel2.Location = new Point(268, 23);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(95, 23);
            uiLabel2.TabIndex = 429;
            uiLabel2.Text = "互检人姓名";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel9
            // 
            uiLabel9.BackColor = Color.Transparent;
            uiLabel9.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel9.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel9.Location = new Point(268, 429);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new Size(104, 23);
            uiLabel9.TabIndex = 449;
            uiLabel9.Text = "辅助人姓名4";
            uiLabel9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtmutualPersonName
            // 
            txtmutualPersonName.Cursor = Cursors.IBeam;
            txtmutualPersonName.FillColor = Color.FromArgb(43, 46, 57);
            txtmutualPersonName.FillColor2 = Color.FromArgb(43, 46, 57);
            txtmutualPersonName.FillDisableColor = Color.FromArgb(43, 46, 57);
            txtmutualPersonName.FillReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtmutualPersonName.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            txtmutualPersonName.ForeColor = Color.FromArgb(235, 227, 221);
            txtmutualPersonName.Location = new Point(268, 51);
            txtmutualPersonName.Margin = new Padding(4, 5, 4, 5);
            txtmutualPersonName.MinimumSize = new Size(1, 16);
            txtmutualPersonName.Name = "txtmutualPersonName";
            txtmutualPersonName.Padding = new Padding(5);
            txtmutualPersonName.Radius = 15;
            txtmutualPersonName.RectColor = Color.FromArgb(43, 46, 57);
            txtmutualPersonName.RectDisableColor = Color.FromArgb(43, 46, 57);
            txtmutualPersonName.RectReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtmutualPersonName.ShowText = false;
            txtmutualPersonName.Size = new Size(197, 29);
            txtmutualPersonName.TabIndex = 430;
            txtmutualPersonName.TextAlignment = ContentAlignment.MiddleLeft;
            txtmutualPersonName.Watermark = "请输入";
            // 
            // txtauxiliariesCode4
            // 
            txtauxiliariesCode4.Cursor = Cursors.IBeam;
            txtauxiliariesCode4.FillColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode4.FillColor2 = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode4.FillDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode4.FillReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode4.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            txtauxiliariesCode4.ForeColor = Color.FromArgb(235, 227, 221);
            txtauxiliariesCode4.Location = new Point(21, 457);
            txtauxiliariesCode4.Margin = new Padding(4, 5, 4, 5);
            txtauxiliariesCode4.MinimumSize = new Size(1, 16);
            txtauxiliariesCode4.Name = "txtauxiliariesCode4";
            txtauxiliariesCode4.Padding = new Padding(5);
            txtauxiliariesCode4.RectColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode4.RectDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode4.RectReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode4.ShowText = false;
            txtauxiliariesCode4.Size = new Size(197, 29);
            txtauxiliariesCode4.TabIndex = 448;
            txtauxiliariesCode4.TextAlignment = ContentAlignment.MiddleLeft;
            txtauxiliariesCode4.Watermark = "请输入";
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
            uiLabel3.Text = "质检人工号";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel10
            // 
            uiLabel10.BackColor = Color.Transparent;
            uiLabel10.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel10.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel10.Location = new Point(21, 429);
            uiLabel10.Name = "uiLabel10";
            uiLabel10.Size = new Size(104, 23);
            uiLabel10.TabIndex = 447;
            uiLabel10.Text = "辅助人工号4";
            uiLabel10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtqualityPerson
            // 
            txtqualityPerson.Cursor = Cursors.IBeam;
            txtqualityPerson.FillColor = Color.FromArgb(43, 46, 57);
            txtqualityPerson.FillColor2 = Color.FromArgb(43, 46, 57);
            txtqualityPerson.FillDisableColor = Color.FromArgb(43, 46, 57);
            txtqualityPerson.FillReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtqualityPerson.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            txtqualityPerson.ForeColor = Color.FromArgb(235, 227, 221);
            txtqualityPerson.Location = new Point(21, 131);
            txtqualityPerson.Margin = new Padding(4, 5, 4, 5);
            txtqualityPerson.MinimumSize = new Size(1, 16);
            txtqualityPerson.Name = "txtqualityPerson";
            txtqualityPerson.Padding = new Padding(5);
            txtqualityPerson.RectColor = Color.FromArgb(43, 46, 57);
            txtqualityPerson.RectDisableColor = Color.FromArgb(43, 46, 57);
            txtqualityPerson.RectReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtqualityPerson.ShowText = false;
            txtqualityPerson.Size = new Size(197, 29);
            txtqualityPerson.TabIndex = 432;
            txtqualityPerson.TextAlignment = ContentAlignment.MiddleLeft;
            txtqualityPerson.Watermark = "请输入";
            // 
            // txtauxiliariesName3
            // 
            txtauxiliariesName3.Cursor = Cursors.IBeam;
            txtauxiliariesName3.FillColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName3.FillColor2 = Color.FromArgb(43, 46, 57);
            txtauxiliariesName3.FillDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName3.FillReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName3.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            txtauxiliariesName3.ForeColor = Color.FromArgb(235, 227, 221);
            txtauxiliariesName3.Location = new Point(268, 374);
            txtauxiliariesName3.Margin = new Padding(4, 5, 4, 5);
            txtauxiliariesName3.MinimumSize = new Size(1, 16);
            txtauxiliariesName3.Name = "txtauxiliariesName3";
            txtauxiliariesName3.Padding = new Padding(5);
            txtauxiliariesName3.RectColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName3.RectDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName3.RectReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName3.ShowText = false;
            txtauxiliariesName3.Size = new Size(197, 29);
            txtauxiliariesName3.TabIndex = 446;
            txtauxiliariesName3.TextAlignment = ContentAlignment.MiddleLeft;
            txtauxiliariesName3.Watermark = "请输入";
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = Color.Transparent;
            uiLabel4.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel4.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel4.Location = new Point(268, 105);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(95, 23);
            uiLabel4.TabIndex = 433;
            uiLabel4.Text = "质检人姓名";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel11
            // 
            uiLabel11.BackColor = Color.Transparent;
            uiLabel11.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel11.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel11.Location = new Point(268, 347);
            uiLabel11.Name = "uiLabel11";
            uiLabel11.Size = new Size(104, 23);
            uiLabel11.TabIndex = 445;
            uiLabel11.Text = "辅助人姓名3";
            uiLabel11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtqualityPersonName
            // 
            txtqualityPersonName.Cursor = Cursors.IBeam;
            txtqualityPersonName.FillColor = Color.FromArgb(43, 46, 57);
            txtqualityPersonName.FillColor2 = Color.FromArgb(43, 46, 57);
            txtqualityPersonName.FillDisableColor = Color.FromArgb(43, 46, 57);
            txtqualityPersonName.FillReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtqualityPersonName.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            txtqualityPersonName.ForeColor = Color.FromArgb(235, 227, 221);
            txtqualityPersonName.Location = new Point(268, 131);
            txtqualityPersonName.Margin = new Padding(4, 5, 4, 5);
            txtqualityPersonName.MinimumSize = new Size(1, 16);
            txtqualityPersonName.Name = "txtqualityPersonName";
            txtqualityPersonName.Padding = new Padding(5);
            txtqualityPersonName.RectColor = Color.FromArgb(43, 46, 57);
            txtqualityPersonName.RectDisableColor = Color.FromArgb(43, 46, 57);
            txtqualityPersonName.RectReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtqualityPersonName.ShowText = false;
            txtqualityPersonName.Size = new Size(197, 29);
            txtqualityPersonName.TabIndex = 434;
            txtqualityPersonName.TextAlignment = ContentAlignment.MiddleLeft;
            txtqualityPersonName.Watermark = "请输入";
            // 
            // txtauxiliariesCode3
            // 
            txtauxiliariesCode3.Cursor = Cursors.IBeam;
            txtauxiliariesCode3.FillColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode3.FillColor2 = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode3.FillDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode3.FillReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode3.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            txtauxiliariesCode3.ForeColor = Color.FromArgb(235, 227, 221);
            txtauxiliariesCode3.Location = new Point(21, 374);
            txtauxiliariesCode3.Margin = new Padding(4, 5, 4, 5);
            txtauxiliariesCode3.MinimumSize = new Size(1, 16);
            txtauxiliariesCode3.Name = "txtauxiliariesCode3";
            txtauxiliariesCode3.Padding = new Padding(5);
            txtauxiliariesCode3.RectColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode3.RectDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode3.RectReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode3.ShowText = false;
            txtauxiliariesCode3.Size = new Size(197, 29);
            txtauxiliariesCode3.TabIndex = 444;
            txtauxiliariesCode3.TextAlignment = ContentAlignment.MiddleLeft;
            txtauxiliariesCode3.Watermark = "请输入";
            // 
            // uiLabel12
            // 
            uiLabel12.BackColor = Color.Transparent;
            uiLabel12.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel12.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel12.Location = new Point(21, 347);
            uiLabel12.Name = "uiLabel12";
            uiLabel12.Size = new Size(104, 23);
            uiLabel12.TabIndex = 443;
            uiLabel12.Text = "辅助人工号3";
            uiLabel12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtauxiliariesName2
            // 
            txtauxiliariesName2.Cursor = Cursors.IBeam;
            txtauxiliariesName2.FillColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName2.FillColor2 = Color.FromArgb(43, 46, 57);
            txtauxiliariesName2.FillDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName2.FillReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName2.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            txtauxiliariesName2.ForeColor = Color.FromArgb(235, 227, 221);
            txtauxiliariesName2.Location = new Point(268, 294);
            txtauxiliariesName2.Margin = new Padding(4, 5, 4, 5);
            txtauxiliariesName2.MinimumSize = new Size(1, 16);
            txtauxiliariesName2.Name = "txtauxiliariesName2";
            txtauxiliariesName2.Padding = new Padding(5);
            txtauxiliariesName2.RectColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName2.RectDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName2.RectReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName2.ShowText = false;
            txtauxiliariesName2.Size = new Size(197, 29);
            txtauxiliariesName2.TabIndex = 442;
            txtauxiliariesName2.TextAlignment = ContentAlignment.MiddleLeft;
            txtauxiliariesName2.Watermark = "请输入";
            // 
            // uiLabel5
            // 
            uiLabel5.BackColor = Color.Transparent;
            uiLabel5.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel5.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel5.Location = new Point(268, 266);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(104, 23);
            uiLabel5.TabIndex = 441;
            uiLabel5.Text = "辅助人姓名2";
            uiLabel5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtauxiliariesCode2
            // 
            txtauxiliariesCode2.Cursor = Cursors.IBeam;
            txtauxiliariesCode2.FillColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode2.FillColor2 = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode2.FillDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode2.FillReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode2.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            txtauxiliariesCode2.ForeColor = Color.FromArgb(235, 227, 221);
            txtauxiliariesCode2.Location = new Point(21, 294);
            txtauxiliariesCode2.Margin = new Padding(4, 5, 4, 5);
            txtauxiliariesCode2.MinimumSize = new Size(1, 16);
            txtauxiliariesCode2.Name = "txtauxiliariesCode2";
            txtauxiliariesCode2.Padding = new Padding(5);
            txtauxiliariesCode2.RectColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode2.RectDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode2.RectReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode2.ShowText = false;
            txtauxiliariesCode2.Size = new Size(197, 29);
            txtauxiliariesCode2.TabIndex = 440;
            txtauxiliariesCode2.TextAlignment = ContentAlignment.MiddleLeft;
            txtauxiliariesCode2.Watermark = "请输入";
            // 
            // uiLabel6
            // 
            uiLabel6.BackColor = Color.Transparent;
            uiLabel6.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel6.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel6.Location = new Point(21, 266);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(104, 23);
            uiLabel6.TabIndex = 439;
            uiLabel6.Text = "辅助人工号2";
            uiLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtauxiliariesName1
            // 
            txtauxiliariesName1.Cursor = Cursors.IBeam;
            txtauxiliariesName1.FillColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName1.FillColor2 = Color.FromArgb(43, 46, 57);
            txtauxiliariesName1.FillDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName1.FillReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName1.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            txtauxiliariesName1.ForeColor = Color.FromArgb(235, 227, 221);
            txtauxiliariesName1.Location = new Point(268, 211);
            txtauxiliariesName1.Margin = new Padding(4, 5, 4, 5);
            txtauxiliariesName1.MinimumSize = new Size(1, 16);
            txtauxiliariesName1.Name = "txtauxiliariesName1";
            txtauxiliariesName1.Padding = new Padding(5);
            txtauxiliariesName1.RectColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName1.RectDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName1.RectReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesName1.ShowText = false;
            txtauxiliariesName1.Size = new Size(197, 29);
            txtauxiliariesName1.TabIndex = 438;
            txtauxiliariesName1.TextAlignment = ContentAlignment.MiddleLeft;
            txtauxiliariesName1.Watermark = "请输入";
            // 
            // uiLabel7
            // 
            uiLabel7.BackColor = Color.Transparent;
            uiLabel7.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel7.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel7.Location = new Point(268, 185);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(104, 23);
            uiLabel7.TabIndex = 437;
            uiLabel7.Text = "辅助人姓名1";
            uiLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtauxiliariesCode1
            // 
            txtauxiliariesCode1.Cursor = Cursors.IBeam;
            txtauxiliariesCode1.FillColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode1.FillColor2 = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode1.FillDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode1.FillReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode1.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            txtauxiliariesCode1.ForeColor = Color.FromArgb(235, 227, 221);
            txtauxiliariesCode1.Location = new Point(21, 211);
            txtauxiliariesCode1.Margin = new Padding(4, 5, 4, 5);
            txtauxiliariesCode1.MinimumSize = new Size(1, 16);
            txtauxiliariesCode1.Name = "txtauxiliariesCode1";
            txtauxiliariesCode1.Padding = new Padding(5);
            txtauxiliariesCode1.RectColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode1.RectDisableColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode1.RectReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtauxiliariesCode1.ShowText = false;
            txtauxiliariesCode1.Size = new Size(197, 29);
            txtauxiliariesCode1.TabIndex = 436;
            txtauxiliariesCode1.TextAlignment = ContentAlignment.MiddleLeft;
            txtauxiliariesCode1.Watermark = "请输入";
            // 
            // uiLabel8
            // 
            uiLabel8.BackColor = Color.Transparent;
            uiLabel8.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel8.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel8.Location = new Point(21, 185);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new Size(104, 23);
            uiLabel8.TabIndex = 435;
            uiLabel8.Text = "辅助人工号1";
            uiLabel8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmUserSelection
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(42, 47, 55);
            ClientSize = new Size(525, 650);
            ControlBox = false;
            Controls.Add(uiPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUserSelection";
            RectColor = Color.FromArgb(47, 55, 64);
            Text = "人员选择";
            TitleColor = Color.FromArgb(47, 55, 64);
            TitleFont = new Font("思源黑体 CN Heavy", 15F, FontStyle.Bold);
            TitleForeColor = Color.FromArgb(239, 154, 78);
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private UIPanel uiPanel1;
        private UILabel uiLabel1;
        private UITextBox txtauxiliariesName4;
        private UILabel uiLabel2;
        private UILabel uiLabel9;
        private UITextBox txtmutualPersonName;
        private UITextBox txtauxiliariesCode4;
        private UILabel uiLabel3;
        private UILabel uiLabel10;
        private UITextBox txtqualityPerson;
        private UITextBox txtauxiliariesName3;
        private UILabel uiLabel4;
        private UILabel uiLabel11;
        private UITextBox txtqualityPersonName;
        private UITextBox txtauxiliariesCode3;
        private UILabel uiLabel12;
        private UITextBox txtauxiliariesName2;
        private UILabel uiLabel5;
        private UITextBox txtauxiliariesCode2;
        private UILabel uiLabel6;
        private UITextBox txtauxiliariesName1;
        private UILabel uiLabel7;
        private UITextBox txtauxiliariesCode1;
        private UILabel uiLabel8;
        private UIButton btnOK;
        private AntdUI.Select ComMutualPerson;
    }
}