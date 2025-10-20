namespace MainUI.TaskInformation
{
    partial class FrmTaskSelectDownload
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
            uiPanel1 = new UIPanel();
            btnConfirm = new AntdUI.Button();
            btnCancel = new AntdUI.Button();
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
            table1.Size = new Size(1339, 703);
            table1.TabIndex = 0;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(table1);
            uiPanel1.FillColor = Color.FromArgb(49, 54, 64);
            uiPanel1.FillColor2 = Color.FromArgb(49, 54, 64);
            uiPanel1.FillDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(23, 59);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Padding = new Padding(1);
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.FromArgb(49, 54, 64);
            uiPanel1.RectDisableColor = Color.FromArgb(49, 54, 64);
            uiPanel1.Size = new Size(1341, 705);
            uiPanel1.TabIndex = 10;
            uiPanel1.Text = "uiPanel1";
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(70, 75, 85);
            btnConfirm.BackExtend = "";
            btnConfirm.Font = new Font("Microsoft YaHei UI", 13F);
            btnConfirm.ForeColor = Color.FromArgb(235, 227, 221);
            btnConfirm.IconSvg = "SearchOutlined";
            btnConfirm.Location = new Point(1061, 772);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(143, 45);
            btnConfirm.TabIndex = 11;
            btnConfirm.Text = "确认下载";
            btnConfirm.Type = AntdUI.TTypeMini.Primary;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(70, 75, 85);
            btnCancel.BackExtend = "";
            btnCancel.Font = new Font("Microsoft YaHei UI", 13F);
            btnCancel.ForeColor = Color.FromArgb(235, 227, 221);
            btnCancel.IconSvg = "SearchOutlined";
            btnCancel.Location = new Point(1221, 772);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 45);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "取 消";
            btnCancel.Type = AntdUI.TTypeMini.Primary;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmTaskSelectDownload2
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(42, 47, 55);
            ClientSize = new Size(1388, 828);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(uiPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTaskSelectDownload2";
            RectColor = Color.FromArgb(49, 54, 64);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "任务下载选择";
            TitleColor = Color.FromArgb(49, 54, 64);
            TitleFont = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            TitleForeColor = Color.FromArgb(239, 154, 78);
            ZoomScaleRect = new Rectangle(15, 15, 1388, 828);
            FormClosing += TaskView_FormClosing;
            Load += TaskView_Load;
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Table table1;
        private UIPanel uiPanel1;
        private AntdUI.Button btnConfirm;
        private AntdUI.Button btnCancel;
    }
}