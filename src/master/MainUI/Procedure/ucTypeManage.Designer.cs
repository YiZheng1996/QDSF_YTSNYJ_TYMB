namespace MainUI.Procedure
{
    partial class ucTypeManage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            groupBox1 = new UIGroupBox();
            dataGridView1 = new UIDataGridView();
            name = new DataGridViewTextBoxColumn();
            ModelNo = new DataGridViewTextBoxColumn();
            TypeID = new DataGridViewTextBoxColumn();
            mark = new DataGridViewTextBoxColumn();
            txtMark = new UITextBox();
            uiLabel4 = new UILabel();
            txtTypeName = new UITextBox();
            uiLabel3 = new UILabel();
            uiLabel1 = new UILabel();
            cboModelName = new UIComboBox();
            uiPanel1 = new UIPanel();
            btnEdit = new UIButton();
            btnDelete = new UIButton();
            btnAdd = new UIButton();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(49, 54, 64);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.FillColor = Color.FromArgb(49, 54, 64);
            groupBox1.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            groupBox1.ForeColor = Color.FromArgb(235, 227, 221);
            groupBox1.Location = new Point(0, 47);
            groupBox1.Margin = new Padding(5, 7, 5, 7);
            groupBox1.MinimumSize = new Size(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0, 45, 0, 0);
            groupBox1.Radius = 15;
            groupBox1.RectColor = Color.FromArgb(49, 54, 64);
            groupBox1.RectDisableColor = Color.FromArgb(49, 54, 64);
            groupBox1.Size = new Size(454, 559);
            groupBox1.TabIndex = 399;
            groupBox1.Text = "型号列表";
            groupBox1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 54, 64);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.FromArgb(49, 54, 64);
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(239, 154, 78);
            dataGridViewCellStyle2.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(235, 227, 221);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(239, 154, 78);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(235, 227, 221);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 32;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { name, ModelNo, TypeID, mark });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new Font("微软雅黑", 12F);
            dataGridView1.GridColor = Color.FromArgb(42, 47, 55);
            dataGridView1.Location = new Point(0, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RectColor = Color.FromArgb(42, 47, 55);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(49, 54, 64);
            dataGridViewCellStyle5.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(235, 227, 221);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(235, 227, 221);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(42, 47, 55);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.ScrollBarBackColor = Color.FromArgb(49, 54, 64);
            dataGridView1.ScrollBarStyleInherited = false;
            dataGridView1.SelectedIndex = -1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(454, 524);
            dataGridView1.StripeEvenColor = Color.FromArgb(49, 54, 64);
            dataGridView1.StripeOddColor = Color.FromArgb(49, 54, 64);
            dataGridView1.TabIndex = 398;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "型号";
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 220;
            // 
            // ModelNo
            // 
            ModelNo.DataPropertyName = "ID";
            ModelNo.HeaderText = "ID";
            ModelNo.Name = "ModelNo";
            ModelNo.ReadOnly = true;
            ModelNo.Visible = false;
            ModelNo.Width = 170;
            // 
            // TypeID
            // 
            TypeID.DataPropertyName = "TypeID";
            TypeID.HeaderText = "类型编号";
            TypeID.Name = "TypeID";
            TypeID.ReadOnly = true;
            TypeID.Visible = false;
            TypeID.Width = 180;
            // 
            // mark
            // 
            mark.DataPropertyName = "mark";
            mark.HeaderText = "备注";
            mark.Name = "mark";
            mark.ReadOnly = true;
            mark.Width = 215;
            // 
            // txtMark
            // 
            txtMark.Cursor = Cursors.IBeam;
            txtMark.FillColor = Color.FromArgb(43, 46, 57);
            txtMark.FillColor2 = Color.FromArgb(43, 46, 57);
            txtMark.FillDisableColor = Color.FromArgb(43, 46, 57);
            txtMark.FillReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtMark.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            txtMark.ForeColor = Color.FromArgb(235, 227, 221);
            txtMark.Location = new Point(9, 116);
            txtMark.Margin = new Padding(4, 5, 4, 5);
            txtMark.MinimumSize = new Size(1, 16);
            txtMark.Name = "txtMark";
            txtMark.Padding = new Padding(5);
            txtMark.RectColor = Color.FromArgb(43, 46, 57);
            txtMark.RectDisableColor = Color.FromArgb(43, 46, 57);
            txtMark.RectReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtMark.ShowText = false;
            txtMark.Size = new Size(177, 29);
            txtMark.TabIndex = 406;
            txtMark.TextAlignment = ContentAlignment.MiddleLeft;
            txtMark.Watermark = "请输入";
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = Color.Transparent;
            uiLabel4.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel4.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel4.Location = new Point(9, 89);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(75, 23);
            uiLabel4.TabIndex = 405;
            uiLabel4.Text = "备注";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTypeName
            // 
            txtTypeName.Cursor = Cursors.IBeam;
            txtTypeName.FillColor = Color.FromArgb(43, 46, 57);
            txtTypeName.FillColor2 = Color.FromArgb(43, 46, 57);
            txtTypeName.FillDisableColor = Color.FromArgb(43, 46, 57);
            txtTypeName.FillReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtTypeName.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            txtTypeName.ForeColor = Color.FromArgb(235, 227, 221);
            txtTypeName.Location = new Point(9, 39);
            txtTypeName.Margin = new Padding(4, 5, 4, 5);
            txtTypeName.MinimumSize = new Size(1, 16);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Padding = new Padding(5);
            txtTypeName.RectColor = Color.FromArgb(43, 46, 57);
            txtTypeName.RectDisableColor = Color.FromArgb(43, 46, 57);
            txtTypeName.RectReadOnlyColor = Color.FromArgb(43, 46, 57);
            txtTypeName.ShowText = false;
            txtTypeName.Size = new Size(177, 29);
            txtTypeName.TabIndex = 404;
            txtTypeName.TextAlignment = ContentAlignment.MiddleLeft;
            txtTypeName.Watermark = "请输入";
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            uiLabel3.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel3.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel3.Location = new Point(8, 11);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(95, 23);
            uiLabel3.TabIndex = 403;
            uiLabel3.Text = "产品型号";
            uiLabel3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            uiLabel1.ForeColor = Color.FromArgb(235, 227, 221);
            uiLabel1.Location = new Point(89, 4);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(87, 33);
            uiLabel1.TabIndex = 400;
            uiLabel1.Text = "产品类型";
            uiLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cboModelName
            // 
            cboModelName.DataSource = null;
            cboModelName.DropDownStyle = UIDropDownStyle.DropDownList;
            cboModelName.FillColor = Color.FromArgb(49, 54, 64);
            cboModelName.FillColor2 = Color.FromArgb(49, 54, 64);
            cboModelName.FillDisableColor = Color.FromArgb(43, 46, 57);
            cboModelName.FilterMaxCount = 50;
            cboModelName.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            cboModelName.ForeColor = Color.FromArgb(235, 227, 221);
            cboModelName.ForeDisableColor = Color.FromArgb(235, 227, 221);
            cboModelName.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cboModelName.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "11", "12", "13", "14", "15", "16" });
            cboModelName.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cboModelName.Location = new Point(171, 7);
            cboModelName.Margin = new Padding(5, 7, 5, 7);
            cboModelName.MinimumSize = new Size(73, 0);
            cboModelName.Name = "cboModelName";
            cboModelName.Padding = new Padding(0, 0, 35, 3);
            cboModelName.RadiusSides = UICornerRadiusSides.None;
            cboModelName.RectColor = Color.FromArgb(49, 54, 64);
            cboModelName.RectDisableColor = Color.FromArgb(49, 54, 64);
            cboModelName.RectSides = ToolStripStatusLabelBorderSides.Bottom;
            cboModelName.Size = new Size(210, 28);
            cboModelName.SymbolSize = 24;
            cboModelName.TabIndex = 399;
            cboModelName.TextAlignment = ContentAlignment.MiddleLeft;
            cboModelName.Watermark = "请选择";
            cboModelName.SelectedIndexChanged += cboModelType_SelectedIndexChanged;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiLabel3);
            uiPanel1.Controls.Add(txtMark);
            uiPanel1.Controls.Add(txtTypeName);
            uiPanel1.Controls.Add(uiLabel4);
            uiPanel1.FillColor = Color.FromArgb(49, 54, 64);
            uiPanel1.FillColor2 = Color.FromArgb(49, 54, 64);
            uiPanel1.FillDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.ForeColor = Color.FromArgb(49, 54, 64);
            uiPanel1.ForeDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Location = new Point(461, 47);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.FromArgb(49, 54, 64);
            uiPanel1.RectDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Size = new Size(200, 559);
            uiPanel1.TabIndex = 407;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FillColor = Color.FromArgb(70, 75, 85);
            btnEdit.FillColor2 = Color.FromArgb(70, 75, 85);
            btnEdit.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            btnEdit.ForeColor = Color.FromArgb(235, 227, 221);
            btnEdit.Location = new Point(361, 616);
            btnEdit.MinimumSize = new Size(1, 1);
            btnEdit.Name = "btnEdit";
            btnEdit.RectColor = Color.FromArgb(70, 75, 85);
            btnEdit.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnEdit.Size = new Size(147, 37);
            btnEdit.TabIndex = 408;
            btnEdit.Text = "更改";
            btnEdit.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnEdit.TipsText = "1";
            btnEdit.Click += btnChange_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FillColor = Color.FromArgb(70, 75, 85);
            btnDelete.FillColor2 = Color.FromArgb(70, 75, 85);
            btnDelete.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(235, 227, 221);
            btnDelete.Location = new Point(188, 616);
            btnDelete.MinimumSize = new Size(1, 1);
            btnDelete.Name = "btnDelete";
            btnDelete.RectColor = Color.FromArgb(70, 75, 85);
            btnDelete.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnDelete.Size = new Size(147, 37);
            btnDelete.TabIndex = 409;
            btnDelete.Text = "删 除";
            btnDelete.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDelete.TipsText = "1";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FillColor = Color.FromArgb(70, 75, 85);
            btnAdd.FillColor2 = Color.FromArgb(70, 75, 85);
            btnAdd.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(235, 227, 221);
            btnAdd.Location = new Point(15, 616);
            btnAdd.MinimumSize = new Size(1, 1);
            btnAdd.Name = "btnAdd";
            btnAdd.RectColor = Color.FromArgb(70, 75, 85);
            btnAdd.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnAdd.Size = new Size(147, 37);
            btnAdd.TabIndex = 410;
            btnAdd.Text = "新 增";
            btnAdd.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnAdd.TipsText = "1";
            btnAdd.Click += btnAdd_Click;
            // 
            // ucTypeManage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 47, 55);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(uiPanel1);
            Controls.Add(groupBox1);
            Controls.Add(uiLabel1);
            Controls.Add(cboModelName);
            Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Margin = new Padding(3, 6, 3, 6);
            Name = "ucTypeManage";
            Size = new Size(665, 660);
            Load += ucModelManage_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIGroupBox groupBox1;
        private Sunny.UI.UIDataGridView dataGridView1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cboModelName;
        private Sunny.UI.UITextBox txtTypeName;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITextBox txtMark;
        private Sunny.UI.UILabel uiLabel4;
        private UIPanel uiPanel1;
        private UIButton btnEdit;
        private UIButton btnDelete;
        private UIButton btnAdd;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn ModelNo;
        private DataGridViewTextBoxColumn TypeID;
        private DataGridViewTextBoxColumn mark;
    }
}
