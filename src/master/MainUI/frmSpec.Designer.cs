namespace MainUI
{
    partial class frmSpec
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            uiLabel2 = new UILabel();
            cboType = new UIComboBox();
            uiLabel1 = new UILabel();
            cboModel = new UIComboBox();
            btnGet = new UIButton();
            uiButton1 = new UIButton();
            uiButton2 = new UIButton();
            uiButton3 = new UIButton();
            uiDataGridView1 = new UIDataGridView();
            colID = new DataGridViewTextBoxColumn();
            TypeName = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            uiLabel2.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel2.Location = new Point(339, 54);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(94, 23);
            uiLabel2.TabIndex = 78;
            uiLabel2.Text = "产品型号";
            uiLabel2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboType
            // 
            cboType.DataSource = null;
            cboType.DropDownStyle = UIDropDownStyle.DropDownList;
            cboType.FillColor = Color.FromArgb(49, 54, 64);
            cboType.FillColor2 = Color.FromArgb(49, 54, 64);
            cboType.FillDisableColor = Color.FromArgb(49, 54, 64);
            cboType.FilterMaxCount = 50;
            cboType.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            cboType.ForeColor = Color.FromArgb(235, 227, 221);
            cboType.ForeDisableColor = Color.FromArgb(235, 227, 221);
            cboType.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboType.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboType.Location = new Point(440, 52);
            cboType.Margin = new Padding(4, 5, 4, 5);
            cboType.MinimumSize = new Size(63, 0);
            cboType.Name = "cboType";
            cboType.Padding = new Padding(0, 0, 30, 2);
            cboType.RadiusSides = UICornerRadiusSides.None;
            cboType.RectColor = Color.Silver;
            cboType.RectDisableColor = Color.Silver;
            cboType.RectSides = ToolStripStatusLabelBorderSides.None;
            cboType.Size = new Size(184, 29);
            cboType.SymbolSize = 24;
            cboType.TabIndex = 77;
            cboType.TextAlignment = ContentAlignment.MiddleLeft;
            cboType.Watermark = "下拉查找";
            cboType.WatermarkActiveColor = Color.White;
            cboType.WatermarkColor = Color.White;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            uiLabel1.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel1.Location = new Point(18, 54);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(95, 23);
            uiLabel1.TabIndex = 76;
            uiLabel1.Text = "产品类型";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboModel
            // 
            cboModel.DataSource = null;
            cboModel.DropDownStyle = UIDropDownStyle.DropDownList;
            cboModel.FillColor = Color.FromArgb(49, 54, 64);
            cboModel.FillColor2 = Color.FromArgb(49, 54, 64);
            cboModel.FillDisableColor = Color.FromArgb(49, 54, 64);
            cboModel.FilterMaxCount = 50;
            cboModel.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            cboModel.ForeColor = Color.FromArgb(235, 227, 221);
            cboModel.ForeDisableColor = Color.FromArgb(235, 227, 221);
            cboModel.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboModel.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboModel.Location = new Point(120, 52);
            cboModel.Margin = new Padding(4, 5, 4, 5);
            cboModel.MinimumSize = new Size(63, 0);
            cboModel.Name = "cboModel";
            cboModel.Padding = new Padding(0, 0, 30, 2);
            cboModel.RadiusSides = UICornerRadiusSides.None;
            cboModel.RectColor = Color.Silver;
            cboModel.RectDisableColor = Color.Silver;
            cboModel.RectSides = ToolStripStatusLabelBorderSides.None;
            cboModel.Size = new Size(200, 29);
            cboModel.SymbolSize = 24;
            cboModel.TabIndex = 75;
            cboModel.TextAlignment = ContentAlignment.MiddleLeft;
            cboModel.Watermark = "下拉查找";
            cboModel.WatermarkActiveColor = Color.White;
            cboModel.WatermarkColor = Color.White;
            cboModel.SelectedIndexChanged += cboModel_SelectedIndexChanged;
            // 
            // btnGet
            // 
            btnGet.Cursor = Cursors.Hand;
            btnGet.FillColor = Color.FromArgb(70, 75, 85);
            btnGet.FillColor2 = Color.FromArgb(70, 75, 85);
            btnGet.Font = new Font("思源黑体 CN Bold", 11F, FontStyle.Bold);
            btnGet.ForeColor = Color.FromArgb(235, 227, 221);
            btnGet.Location = new Point(651, 47);
            btnGet.MinimumSize = new Size(1, 1);
            btnGet.Name = "btnGet";
            btnGet.RectColor = Color.FromArgb(70, 75, 85);
            btnGet.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnGet.Size = new Size(120, 40);
            btnGet.TabIndex = 388;
            btnGet.Text = "搜索";
            btnGet.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnGet.TipsText = "1";
            btnGet.Click += btnGet_Click;
            // 
            // uiButton1
            // 
            uiButton1.Cursor = Cursors.Hand;
            uiButton1.FillColor = Color.FromArgb(70, 75, 85);
            uiButton1.FillColor2 = Color.FromArgb(70, 75, 85);
            uiButton1.Font = new Font("思源黑体 CN Bold", 11F, FontStyle.Bold);
            uiButton1.ForeColor = Color.FromArgb(235, 227, 221);
            uiButton1.Location = new Point(18, 699);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.RectColor = Color.FromArgb(70, 75, 85);
            uiButton1.RectDisableColor = Color.FromArgb(70, 75, 85);
            uiButton1.Size = new Size(86, 38);
            uiButton1.TabIndex = 389;
            uiButton1.Text = "▲";
            uiButton1.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.TipsText = "1";
            uiButton1.Click += button1_Click;
            // 
            // uiButton2
            // 
            uiButton2.Cursor = Cursors.Hand;
            uiButton2.FillColor = Color.FromArgb(70, 75, 85);
            uiButton2.FillColor2 = Color.FromArgb(70, 75, 85);
            uiButton2.Font = new Font("思源黑体 CN Bold", 11F, FontStyle.Bold);
            uiButton2.ForeColor = Color.FromArgb(235, 227, 221);
            uiButton2.Location = new Point(110, 699);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.RectColor = Color.FromArgb(70, 75, 85);
            uiButton2.RectDisableColor = Color.FromArgb(70, 75, 85);
            uiButton2.Size = new Size(86, 38);
            uiButton2.TabIndex = 390;
            uiButton2.Text = "▼";
            uiButton2.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.TipsText = "1";
            uiButton2.Click += button2_Click;
            // 
            // uiButton3
            // 
            uiButton3.Cursor = Cursors.Hand;
            uiButton3.DialogResult = DialogResult.OK;
            uiButton3.FillColor = Color.FromArgb(70, 75, 85);
            uiButton3.FillColor2 = Color.FromArgb(70, 75, 85);
            uiButton3.Font = new Font("思源黑体 CN Bold", 11F, FontStyle.Bold);
            uiButton3.ForeColor = Color.FromArgb(235, 227, 221);
            uiButton3.Location = new Point(651, 697);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.RectColor = Color.FromArgb(70, 75, 85);
            uiButton3.RectDisableColor = Color.FromArgb(70, 75, 85);
            uiButton3.Size = new Size(120, 40);
            uiButton3.TabIndex = 391;
            uiButton3.Text = "选择实行";
            uiButton3.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton3.TipsText = "1";
            uiButton3.Click += button3_Click;
            // 
            // uiDataGridView1
            // 
            uiDataGridView1.AllowUserToAddRows = false;
            uiDataGridView1.AllowUserToDeleteRows = false;
            uiDataGridView1.AllowUserToResizeColumns = false;
            uiDataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(49, 54, 64);
            uiDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            uiDataGridView1.BackgroundColor = Color.FromArgb(49, 54, 64);
            uiDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(239, 154, 78);
            dataGridViewCellStyle7.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(235, 227, 221);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(239, 154, 78);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(235, 227, 221);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            uiDataGridView1.ColumnHeadersHeight = 32;
            uiDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            uiDataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, TypeName, colUsername, colPassword });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(235, 227, 221);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            uiDataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            uiDataGridView1.EnableHeadersVisualStyles = false;
            uiDataGridView1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiDataGridView1.GridColor = Color.FromArgb(49, 54, 64);
            uiDataGridView1.Location = new Point(17, 101);
            uiDataGridView1.Name = "uiDataGridView1";
            uiDataGridView1.ReadOnly = true;
            uiDataGridView1.RectColor = Color.FromArgb(49, 54, 64);
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle9.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            uiDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(49, 54, 64);
            dataGridViewCellStyle10.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(235, 227, 221);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(235, 227, 221);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(49, 54, 64);
            uiDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle10;
            uiDataGridView1.RowTemplate.Height = 34;
            uiDataGridView1.ScrollBarColor = Color.FromArgb(42, 47, 55);
            uiDataGridView1.ScrollBarStyleInherited = false;
            uiDataGridView1.SelectedIndex = -1;
            uiDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            uiDataGridView1.Size = new Size(753, 584);
            uiDataGridView1.StripeEvenColor = Color.FromArgb(49, 54, 64);
            uiDataGridView1.StripeOddColor = Color.FromArgb(49, 54, 64);
            uiDataGridView1.TabIndex = 392;
            uiDataGridView1.CellDoubleClick += dataGridView_Spec_CellDoubleClick;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            // 
            // TypeName
            // 
            TypeName.DataPropertyName = "modeltype";
            TypeName.HeaderText = "产品类型";
            TypeName.Name = "TypeName";
            TypeName.ReadOnly = true;
            TypeName.Width = 250;
            // 
            // colUsername
            // 
            colUsername.DataPropertyName = "Name";
            colUsername.HeaderText = "产品型号";
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            colUsername.Width = 250;
            // 
            // colPassword
            // 
            colPassword.DataPropertyName = "mark";
            colPassword.HeaderText = "备注";
            colPassword.Name = "colPassword";
            colPassword.ReadOnly = true;
            colPassword.Width = 210;
            // 
            // frmSpec
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(42, 47, 55);
            ClientSize = new Size(786, 746);
            Controls.Add(uiDataGridView1);
            Controls.Add(uiButton3);
            Controls.Add(uiButton2);
            Controls.Add(uiButton1);
            Controls.Add(btnGet);
            Controls.Add(uiLabel2);
            Controls.Add(cboType);
            Controls.Add(uiLabel1);
            Controls.Add(cboModel);
            Font = new Font("思源黑体 CN Bold", 11F, FontStyle.Bold);
            ForeColor = Color.FromArgb(235, 227, 221);
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSpec";
            Padding = new Padding(0, 32, 0, 0);
            RectColor = Color.FromArgb(49, 54, 64);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "车型选择";
            TitleColor = Color.FromArgb(47, 55, 64);
            TitleFont = new Font("思源黑体 CN Heavy", 15F, FontStyle.Bold);
            TitleForeColor = Color.FromArgb(239, 154, 78);
            TitleHeight = 32;
            ZoomScaleRect = new Rectangle(15, 15, 786, 678);
            Load += frmSpec_Load;
            ((System.ComponentModel.ISupportInitialize)uiDataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIComboBox cboType;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cboModel;
        private Sunny.UI.UIButton btnGet;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIDataGridView uiDataGridView1;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn TypeName;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colPassword;
    }
}