namespace MainUI.Procedure.User
{
    partial class ucUserManager
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUserManager));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            btnAdd = new UIButton();
            btnDelete = new UIButton();
            btnEdit = new UIButton();
            btnBelow = new UIButton();
            btnUp = new UIButton();
            dataGridView1 = new UIDataGridView();
            grpDI = new UIGroupBox();
            colID = new DataGridViewTextBoxColumn();
            colSort = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colJobNumber = new DataGridViewTextBoxColumn();
            colPermission = new DataGridViewTextBoxColumn();
            colPassword = new DataGridViewTextBoxColumn();
            coldepName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpDI.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FillColor = Color.FromArgb(70, 75, 85);
            btnAdd.FillColor2 = Color.FromArgb(70, 75, 85);
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.ForeColor = Color.FromArgb(235, 227, 221);
            btnAdd.Name = "btnAdd";
            btnAdd.RectColor = Color.FromArgb(70, 75, 85);
            btnAdd.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnAdd.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnAdd.TipsText = "1";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FillColor = Color.FromArgb(70, 75, 85);
            btnDelete.FillColor2 = Color.FromArgb(70, 75, 85);
            resources.ApplyResources(btnDelete, "btnDelete");
            btnDelete.ForeColor = Color.FromArgb(235, 227, 221);
            btnDelete.Name = "btnDelete";
            btnDelete.RectColor = Color.FromArgb(70, 75, 85);
            btnDelete.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnDelete.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnDelete.TipsText = "1";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FillColor = Color.FromArgb(70, 75, 85);
            btnEdit.FillColor2 = Color.FromArgb(70, 75, 85);
            resources.ApplyResources(btnEdit, "btnEdit");
            btnEdit.ForeColor = Color.FromArgb(235, 227, 221);
            btnEdit.Name = "btnEdit";
            btnEdit.RectColor = Color.FromArgb(70, 75, 85);
            btnEdit.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnEdit.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnEdit.TipsText = "1";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnBelow
            // 
            btnBelow.Cursor = Cursors.Hand;
            btnBelow.FillColor = Color.FromArgb(70, 75, 85);
            btnBelow.FillColor2 = Color.FromArgb(70, 75, 85);
            resources.ApplyResources(btnBelow, "btnBelow");
            btnBelow.Name = "btnBelow";
            btnBelow.RectColor = Color.FromArgb(70, 75, 85);
            btnBelow.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnBelow.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnBelow.TipsText = "1";
            btnBelow.Click += btnBelow_Click;
            // 
            // btnUp
            // 
            btnUp.Cursor = Cursors.Hand;
            btnUp.FillColor = Color.FromArgb(70, 75, 85);
            btnUp.FillColor2 = Color.FromArgb(70, 75, 85);
            resources.ApplyResources(btnUp, "btnUp");
            btnUp.Name = "btnUp";
            btnUp.RectColor = Color.FromArgb(70, 75, 85);
            btnUp.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnUp.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnUp.TipsText = "1";
            btnUp.Click += btnUp_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(49, 54, 64);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(235, 227, 221);
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
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colID, colSort, colUsername, colJobNumber, colPermission, colPassword, coldepName });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(220, 236, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(42, 47, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RectColor = Color.FromArgb(49, 54, 64);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(243, 249, 255);
            dataGridViewCellStyle4.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(49, 54, 64);
            dataGridViewCellStyle5.Font = new Font("思源黑体 CN Bold", 12F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(235, 227, 221);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(235, 227, 221);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(49, 54, 64);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.ScrollBarBackColor = Color.FromArgb(49, 54, 64);
            dataGridView1.ScrollBarStyleInherited = false;
            dataGridView1.SelectedIndex = -1;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.StripeEvenColor = Color.FromArgb(49, 54, 64);
            dataGridView1.StripeOddColor = Color.FromArgb(49, 54, 64);
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // grpDI
            // 
            grpDI.BackColor = Color.FromArgb(42, 47, 55);
            grpDI.Controls.Add(dataGridView1);
            grpDI.Controls.Add(btnEdit);
            grpDI.Controls.Add(btnUp);
            grpDI.Controls.Add(btnDelete);
            grpDI.Controls.Add(btnBelow);
            grpDI.Controls.Add(btnAdd);
            grpDI.FillColor = Color.FromArgb(42, 47, 55);
            grpDI.FillColor2 = Color.FromArgb(42, 47, 55);
            grpDI.FillDisableColor = Color.FromArgb(42, 47, 55);
            resources.ApplyResources(grpDI, "grpDI");
            grpDI.ForeColor = Color.FromArgb(235, 227, 221);
            grpDI.Name = "grpDI";
            grpDI.RectColor = Color.FromArgb(42, 47, 55);
            grpDI.RectDisableColor = Color.FromArgb(42, 47, 55);
            grpDI.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            resources.ApplyResources(colID, "colID");
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colSort
            // 
            colSort.DataPropertyName = "Sort";
            resources.ApplyResources(colSort, "colSort");
            colSort.Name = "colSort";
            colSort.ReadOnly = true;
            // 
            // colUsername
            // 
            colUsername.DataPropertyName = "Username";
            resources.ApplyResources(colUsername, "colUsername");
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            // 
            // colJobNumber
            // 
            colJobNumber.DataPropertyName = "JobNumber";
            resources.ApplyResources(colJobNumber, "colJobNumber");
            colJobNumber.Name = "colJobNumber";
            colJobNumber.ReadOnly = true;
            // 
            // colPermission
            // 
            colPermission.DataPropertyName = "Permission";
            resources.ApplyResources(colPermission, "colPermission");
            colPermission.Name = "colPermission";
            colPermission.ReadOnly = true;
            // 
            // colPassword
            // 
            colPassword.DataPropertyName = "Password";
            resources.ApplyResources(colPassword, "colPassword");
            colPassword.Name = "colPassword";
            colPassword.ReadOnly = true;
            // 
            // coldepName
            // 
            coldepName.DataPropertyName = "depName";
            resources.ApplyResources(coldepName, "coldepName");
            coldepName.Name = "coldepName";
            coldepName.ReadOnly = true;
            // 
            // ucUserManager
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(42, 47, 55);
            Controls.Add(grpDI);
            resources.ApplyResources(this, "$this");
            Name = "ucUserManager";
            Load += ucUserManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpDI.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIButton btnEdit;
        private Sunny.UI.UIButton btnDelete;
        private Sunny.UI.UIButton btnAdd;
        private Sunny.UI.UIButton btnUp;
        private Sunny.UI.UIButton btnBelow;
        private Sunny.UI.UIDataGridView dataGridView1;
        private UIGroupBox grpDI;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colSort;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colJobNumber;
        private DataGridViewTextBoxColumn colPermission;
        private DataGridViewTextBoxColumn colPassword;
        private DataGridViewTextBoxColumn coldepName;
    }
}
