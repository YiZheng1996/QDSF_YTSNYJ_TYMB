namespace MainUI.TaskInformation
{
    partial class FrmEditTaskId
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblWarning = new AntdUI.Label();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            txtHoldTaskId = new AntdUI.Input();
            txtHoldItemId = new AntdUI.Input();
            btnConfirm = new AntdUI.Button();
            panel1 = new AntdUI.Panel();
            btnCancel = new AntdUI.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblWarning
            // 
            lblWarning.BackColor = Color.FromArgb(255, 245, 230);
            lblWarning.Font = new Font("Microsoft YaHei UI", 11F);
            lblWarning.ForeColor = Color.FromArgb(200, 100, 0);
            lblWarning.Location = new Point(20, 20);
            lblWarning.Name = "lblWarning";
            lblWarning.Padding = new Padding(10);
            lblWarning.Size = new Size(510, 60);
            lblWarning.TabIndex = 0;
            lblWarning.Text = "⚠️ 注意: 此操作将同时修改该主任务下的所有 X 条子任务记录";
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(235, 227, 221);
            label1.Location = new Point(20, 160);
            label1.Name = "label1";
            label1.Size = new Size(150, 35);
            label1.TabIndex = 1;
            label1.Text = "施工任务ID:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(235, 227, 221);
            label2.Location = new Point(20, 220);
            label2.Name = "label2";
            label2.Size = new Size(150, 35);
            label2.TabIndex = 2;
            label2.Text = "耐压子任务ID:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHoldTaskId
            // 
            txtHoldTaskId.BackColor = Color.FromArgb(49, 54, 64);
            txtHoldTaskId.Font = new Font("Microsoft YaHei UI", 13F);
            txtHoldTaskId.ForeColor = Color.Wheat;
            txtHoldTaskId.Location = new Point(180, 160);
            txtHoldTaskId.Name = "txtHoldTaskId";
            txtHoldTaskId.PlaceholderText = "请输入施工任务ID";
            txtHoldTaskId.Size = new Size(340, 35);
            txtHoldTaskId.TabIndex = 3;
            // 
            // txtHoldItemId
            // 
            txtHoldItemId.BackColor = Color.FromArgb(49, 54, 64);
            txtHoldItemId.Font = new Font("Microsoft YaHei UI", 13F);
            txtHoldItemId.ForeColor = Color.FromArgb(235, 227, 221);
            txtHoldItemId.Location = new Point(180, 220);
            txtHoldItemId.Name = "txtHoldItemId";
            txtHoldItemId.PlaceholderText = "请输入耐压子任务ID";
            txtHoldItemId.Size = new Size(340, 35);
            txtHoldItemId.TabIndex = 4;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(70, 75, 85);
            btnConfirm.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Bold);
            btnConfirm.ForeColor = Color.FromArgb(235, 227, 221);
            btnConfirm.Location = new Point(105, 297);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(140, 45);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "确 定";
            btnConfirm.Type = AntdUI.TTypeMini.Primary;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 245, 230);
            panel1.Controls.Add(lblWarning);
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 90);
            panel1.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(70, 75, 85);
            btnCancel.Font = new Font("Microsoft YaHei UI", 13F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(235, 227, 221);
            btnCancel.Location = new Point(313, 297);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 45);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "取 消";
            btnCancel.Type = AntdUI.TTypeMini.Primary;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmEditTaskId
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(42, 47, 55);
            ClientSize = new Size(550, 365);
            Controls.Add(btnCancel);
            Controls.Add(panel1);
            Controls.Add(btnConfirm);
            Controls.Add(txtHoldItemId);
            Controls.Add(txtHoldTaskId);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEditTaskId";
            RectColor = Color.FromArgb(49, 54, 64);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "修改任务ID (批量操作)";
            TitleColor = Color.FromArgb(49, 54, 64);
            TitleFont = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            TitleForeColor = Color.FromArgb(239, 154, 78);
            ZoomScaleRect = new Rectangle(15, 15, 550, 310);
            Load += FrmEditTaskId_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private AntdUI.Label lblWarning;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input txtHoldTaskId;
        private AntdUI.Input txtHoldItemId;
        private AntdUI.Button btnConfirm;
        private AntdUI.Panel panel1;
        private AntdUI.Button btnCancel;
    }
}