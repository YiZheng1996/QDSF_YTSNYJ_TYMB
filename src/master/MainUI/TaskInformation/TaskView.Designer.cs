namespace MainUI.TaskInformation
{
    partial class TaskView
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
            selectTrainNo = new AntdUI.Select();
            label3 = new AntdUI.Label();
            uiGroupBox1 = new UIGroupBox();
            btnSeek = new AntdUI.Button();
            uiPanel1 = new UIPanel();
            uiGroupBox1.SuspendLayout();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // table1
            // 
            table1.BackColor = Color.FromArgb(235, 227, 221);
            table1.BackgroundImageLayout = ImageLayout.None;
            table1.BadgeMode = true;
            table1.ClipboardCopy = false;
            table1.ColumnBack = Color.FromArgb(239, 154, 78);
            table1.ColumnFont = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 134);
            table1.ColumnFore = Color.FromArgb(235, 227, 221);
            table1.DefaultExpand = true;
            table1.Dock = DockStyle.Fill;
            table1.Font = new Font("Microsoft YaHei UI", 14F);
            table1.ForeColor = Color.FromArgb(235, 227, 221);
            table1.ImeMode = ImeMode.NoControl;
            table1.Location = new Point(1, 1);
            table1.Name = "table1";
            table1.RightToLeft = RightToLeft.No;
            table1.RowSelectedBg = Color.FromArgb(189, 179, 172);
            table1.RowSelectedFore = Color.FromArgb(235, 227, 221);
            table1.Size = new Size(1339, 642);
            table1.TabIndex = 0;
            table1.CellButtonClick += Table1_CellButtonClick;
            // 
            // selectProjectNumber
            // 
            selectProjectNumber.BackColor = Color.FromArgb(42, 47, 55);
            selectProjectNumber.Font = new Font("Microsoft YaHei UI", 13F);
            selectProjectNumber.ForeColor = Color.FromArgb(235, 227, 221);
            selectProjectNumber.List = true;
            selectProjectNumber.Location = new Point(119, 25);
            selectProjectNumber.MaxCount = 10;
            selectProjectNumber.Name = "selectProjectNumber";
            selectProjectNumber.PlaceholderText = "--请选择--";
            selectProjectNumber.SelectionColor = Color.FromArgb(239, 154, 78);
            selectProjectNumber.Size = new Size(197, 38);
            selectProjectNumber.TabIndex = 1;
            selectProjectNumber.Text = "--请选择--";
            selectProjectNumber.TextAlign = HorizontalAlignment.Center;
            selectProjectNumber.SelectedIndexChanged += selectProjectNumber_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(235, 227, 221);
            label1.Location = new Point(5, 29);
            label1.Name = "label1";
            label1.Size = new Size(114, 40);
            label1.TabIndex = 2;
            label1.Text = "车型编码:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // selectCarCode
            // 
            selectCarCode.BackColor = Color.FromArgb(42, 47, 55);
            selectCarCode.Font = new Font("Microsoft YaHei UI", 13F);
            selectCarCode.ForeColor = Color.FromArgb(235, 227, 221);
            selectCarCode.List = true;
            selectCarCode.Location = new Point(508, 25);
            selectCarCode.MaxCount = 10;
            selectCarCode.Name = "selectCarCode";
            selectCarCode.PlaceholderText = "--请选择--";
            selectCarCode.SelectionColor = Color.FromArgb(239, 154, 78);
            selectCarCode.Size = new Size(197, 38);
            selectCarCode.TabIndex = 3;
            selectCarCode.Text = "--请选择--";
            selectCarCode.TextAlign = HorizontalAlignment.Center;
            selectCarCode.SelectedIndexChanged += selectCarCode_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(235, 227, 221);
            label2.Location = new Point(394, 34);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 4;
            label2.Text = "配属辆号:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // selectTrainNo
            // 
            selectTrainNo.BackColor = Color.FromArgb(42, 47, 55);
            selectTrainNo.Font = new Font("Microsoft YaHei UI", 13F);
            selectTrainNo.ForeColor = Color.FromArgb(235, 227, 221);
            selectTrainNo.List = true;
            selectTrainNo.Location = new Point(899, 25);
            selectTrainNo.MaxCount = 10;
            selectTrainNo.Name = "selectTrainNo";
            selectTrainNo.PlaceholderText = "--请选择--";
            selectTrainNo.SelectionColor = Color.FromArgb(239, 154, 78);
            selectTrainNo.Size = new Size(197, 38);
            selectTrainNo.TabIndex = 5;
            selectTrainNo.Text = "--请选择--";
            selectTrainNo.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(235, 227, 221);
            label3.Location = new Point(786, 34);
            label3.Name = "label3";
            label3.Size = new Size(114, 30);
            label3.TabIndex = 6;
            label3.Text = "车列号:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.BackColor = Color.FromArgb(49, 54, 64);
            uiGroupBox1.Controls.Add(btnSeek);
            uiGroupBox1.Controls.Add(selectCarCode);
            uiGroupBox1.Controls.Add(label1);
            uiGroupBox1.Controls.Add(selectProjectNumber);
            uiGroupBox1.Controls.Add(selectTrainNo);
            uiGroupBox1.Controls.Add(label2);
            uiGroupBox1.Controls.Add(label3);
            uiGroupBox1.FillColor = Color.FromArgb(49, 54, 64);
            uiGroupBox1.FillColor2 = Color.FromArgb(49, 54, 64);
            uiGroupBox1.FillDisableColor = Color.FromArgb(49, 54, 64);
            uiGroupBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiGroupBox1.Location = new Point(23, 57);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Radius = 15;
            uiGroupBox1.RectColor = Color.FromArgb(49, 54, 64);
            uiGroupBox1.RectDisableColor = Color.FromArgb(49, 54, 64);
            uiGroupBox1.Size = new Size(1340, 89);
            uiGroupBox1.TabIndex = 9;
            uiGroupBox1.Text = null;
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // btnSeek
            // 
            btnSeek.BackColor = Color.FromArgb(70, 75, 85);
            btnSeek.BackExtend = "";
            btnSeek.Font = new Font("Microsoft YaHei UI", 13F);
            btnSeek.ForeColor = Color.FromArgb(235, 227, 221);
            btnSeek.IconSvg = "SearchOutlined";
            btnSeek.Location = new Point(1172, 19);
            btnSeek.Name = "btnSeek";
            btnSeek.Size = new Size(143, 45);
            btnSeek.TabIndex = 7;
            btnSeek.Text = "搜 索";
            btnSeek.Type = AntdUI.TTypeMini.Primary;
            btnSeek.Click += btnSeek_Click;
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
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.FromArgb(49, 54, 64);
            uiPanel1.RectDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Size = new Size(1341, 644);
            uiPanel1.TabIndex = 10;
            uiPanel1.Text = "uiPanel1";
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // TaskView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(42, 47, 55);
            ClientSize = new Size(1388, 828);
            Controls.Add(uiPanel1);
            Controls.Add(uiGroupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TaskView";
            RectColor = Color.FromArgb(49, 54, 64);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "任务查看";
            TitleColor = Color.FromArgb(49, 54, 64);
            TitleFont = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            TitleForeColor = Color.FromArgb(239, 154, 78);
            ZoomScaleRect = new Rectangle(15, 15, 1388, 828);
            FormClosing += TaskView_FormClosing;
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
        private AntdUI.Select selectTrainNo;
        private UIGroupBox uiGroupBox1;
        private AntdUI.Button btnSeek;
        private UIPanel uiPanel1;
    }
}