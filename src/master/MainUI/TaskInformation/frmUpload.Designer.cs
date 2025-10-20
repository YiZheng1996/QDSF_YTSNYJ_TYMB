namespace MainUI.TaskInformation
{
    partial class FrmUpload
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
            table1 = new AntdUI.Table();
            selectProjectNumber = new AntdUI.Select();
            label1 = new AntdUI.Label();
            selectCarCode = new AntdUI.Select();
            label2 = new AntdUI.Label();
            selectTrainCode = new AntdUI.Select();
            label3 = new AntdUI.Label();
            uiGroupBox1 = new UIGroupBox();
            btnSeek = new AntdUI.Button();
            btnDataBackhaul = new AntdUI.Button();
            btnColose = new AntdUI.Button();
            uiPanel1 = new UIPanel();
            uiGroupBox1.SuspendLayout();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // table1
            // 
            table1.BackColor = Color.FromArgb(235, 227, 221);
            table1.CheckSize = 20;
            table1.ClipboardCopy = false;
            table1.ColumnBack = Color.FromArgb(239, 154, 78);
            table1.ColumnFont = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold);
            table1.ColumnFore = Color.FromArgb(235, 227, 221);
            table1.DefaultExpand = true;
            table1.Dock = DockStyle.Fill;
            table1.Font = new Font("Microsoft YaHei UI", 14F);
            table1.ForeColor = Color.FromArgb(235, 227, 221);
            table1.Location = new Point(1, 1);
            table1.Name = "table1";
            table1.RowSelectedBg = Color.FromArgb(189, 179, 172);
            table1.RowSelectedFore = Color.FromArgb(235, 227, 221);
            table1.Size = new Size(1330, 594);
            table1.TabIndex = 0;
            table1.CellButtonClick += Table1_CellButtonClick;
            // 
            // selectProjectNumber
            // 
            selectProjectNumber.BackColor = Color.FromArgb(49, 54, 64);
            selectProjectNumber.Font = new Font("Microsoft YaHei UI", 13F);
            selectProjectNumber.ForeColor = Color.FromArgb(235, 227, 221);
            selectProjectNumber.List = true;
            selectProjectNumber.Location = new Point(119, 27);
            selectProjectNumber.MaxCount = 10;
            selectProjectNumber.Name = "selectProjectNumber";
            selectProjectNumber.Size = new Size(197, 38);
            selectProjectNumber.TabIndex = 1;
            selectProjectNumber.Text = "--请选择--";
            selectProjectNumber.TextAlign = HorizontalAlignment.Center;
            selectProjectNumber.SelectedIndexChanged += selectProjectNumber_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(235, 227, 221);
            label1.Location = new Point(18, 31);
            label1.Name = "label1";
            label1.Size = new Size(103, 35);
            label1.TabIndex = 2;
            label1.Text = "车型编码:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // selectCarCode
            // 
            selectCarCode.BackColor = Color.FromArgb(49, 54, 64);
            selectCarCode.Font = new Font("Microsoft YaHei UI", 13F);
            selectCarCode.ForeColor = Color.FromArgb(235, 227, 221);
            selectCarCode.List = true;
            selectCarCode.Location = new Point(508, 27);
            selectCarCode.MaxCount = 10;
            selectCarCode.Name = "selectCarCode";
            selectCarCode.Size = new Size(197, 38);
            selectCarCode.TabIndex = 3;
            selectCarCode.Text = "--请选择--";
            selectCarCode.TextAlign = HorizontalAlignment.Center;
            selectCarCode.SelectedIndexChanged += selectCarCode_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(235, 227, 221);
            label2.Location = new Point(405, 31);
            label2.Name = "label2";
            label2.Size = new Size(103, 35);
            label2.TabIndex = 4;
            label2.Text = "配属辆号:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // selectTrainCode
            // 
            selectTrainCode.BackColor = Color.FromArgb(49, 54, 64);
            selectTrainCode.Font = new Font("Microsoft YaHei UI", 13F);
            selectTrainCode.ForeColor = Color.FromArgb(235, 227, 221);
            selectTrainCode.List = true;
            selectTrainCode.Location = new Point(899, 27);
            selectTrainCode.MaxCount = 10;
            selectTrainCode.Name = "selectTrainCode";
            selectTrainCode.Size = new Size(197, 38);
            selectTrainCode.TabIndex = 5;
            selectTrainCode.Text = "--请选择--";
            selectTrainCode.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(235, 227, 221);
            label3.Location = new Point(797, 31);
            label3.Name = "label3";
            label3.Size = new Size(103, 35);
            label3.TabIndex = 6;
            label3.Text = "车列号:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(btnSeek);
            uiGroupBox1.Controls.Add(selectCarCode);
            uiGroupBox1.Controls.Add(label1);
            uiGroupBox1.Controls.Add(selectProjectNumber);
            uiGroupBox1.Controls.Add(selectTrainCode);
            uiGroupBox1.Controls.Add(label2);
            uiGroupBox1.Controls.Add(label3);
            uiGroupBox1.FillColor = Color.FromArgb(49, 54, 64);
            uiGroupBox1.FillColor2 = Color.FromArgb(49, 54, 64);
            uiGroupBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiGroupBox1.Location = new Point(23, 57);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.RectColor = Color.FromArgb(49, 54, 64);
            uiGroupBox1.RectDisableColor = Color.FromArgb(49, 54, 64);
            uiGroupBox1.Size = new Size(1332, 89);
            uiGroupBox1.TabIndex = 9;
            uiGroupBox1.Text = null;
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // btnSeek
            // 
            btnSeek.BackColor = Color.FromArgb(70, 75, 85);
            btnSeek.BackExtend = "";
            btnSeek.Font = new Font("Microsoft YaHei UI", 13F);
            btnSeek.IconSvg = "SearchOutlined";
            btnSeek.Location = new Point(1150, 21);
            btnSeek.Name = "btnSeek";
            btnSeek.Size = new Size(143, 45);
            btnSeek.TabIndex = 7;
            btnSeek.Text = "搜 索";
            btnSeek.Type = AntdUI.TTypeMini.Primary;
            btnSeek.Click += btnSeek_Click;
            // 
            // btnDataBackhaul
            // 
            btnDataBackhaul.BackColor = Color.FromArgb(70, 75, 85);
            btnDataBackhaul.Font = new Font("Microsoft YaHei UI", 13F);
            btnDataBackhaul.IconRatio = 0.9F;
            btnDataBackhaul.IconSvg = "UploadOutlined";
            btnDataBackhaul.Location = new Point(367, 768);
            btnDataBackhaul.Name = "btnDataBackhaul";
            btnDataBackhaul.Size = new Size(216, 50);
            btnDataBackhaul.TabIndex = 20;
            btnDataBackhaul.Text = "一键数据回传";
            btnDataBackhaul.Type = AntdUI.TTypeMini.Primary;
            btnDataBackhaul.Click += btnDataBackhaul_Click;
            // 
            // btnColose
            // 
            btnColose.BackColor = Color.FromArgb(70, 75, 85);
            btnColose.Font = new Font("Microsoft YaHei UI", 13F);
            btnColose.IconRatio = 0.9F;
            btnColose.IconSvg = "RollbackOutlined";
            btnColose.Location = new Point(798, 768);
            btnColose.Name = "btnColose";
            btnColose.Size = new Size(216, 50);
            btnColose.TabIndex = 21;
            btnColose.Text = "界 面 退 出";
            btnColose.Type = AntdUI.TTypeMini.Primary;
            btnColose.Click += btnColose_Click;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(table1);
            uiPanel1.FillColor = Color.FromArgb(49, 54, 64);
            uiPanel1.FillColor2 = Color.FromArgb(49, 54, 64);
            uiPanel1.FillDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(23, 164);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Padding = new Padding(1);
            uiPanel1.RectColor = Color.FromArgb(49, 54, 64);
            uiPanel1.RectDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Size = new Size(1332, 596);
            uiPanel1.TabIndex = 22;
            uiPanel1.Text = "uiPanel1";
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // FrmUpload
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(42, 47, 55);
            ClientSize = new Size(1388, 828);
            Controls.Add(uiPanel1);
            Controls.Add(btnColose);
            Controls.Add(btnDataBackhaul);
            Controls.Add(uiGroupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmUpload";
            RectColor = Color.FromArgb(49, 54, 64);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "任务回传";
            TitleColor = Color.FromArgb(49, 54, 64);
            TitleFont = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            TitleForeColor = Color.FromArgb(239, 154, 78);
            ZoomScaleRect = new Rectangle(15, 15, 1381, 820);
            Load += TaskView_Load;
            uiGroupBox1.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Table table1;
        private AntdUI.Label label1;
        private AntdUI.Select selectProjectNumber;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Select selectCarCode;
        private AntdUI.Select selectTrainCode;
        private UIGroupBox uiGroupBox1;
        private AntdUI.Button btnSeek;
        private AntdUI.Button btnDataBackhaul;
        private AntdUI.Button btnColose;
        private UIPanel uiPanel1;
    }
}