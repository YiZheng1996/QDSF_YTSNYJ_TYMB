namespace MainUI
{
    partial class frmHardWare
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            label12 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            grpAI = new UIGroupBox();
            panel3 = new Panel();
            ucCalibration2 = new Procedure.UCCalibration();
            ucCalibration9 = new Procedure.UCCalibration();
            ucCalibration3 = new Procedure.UCCalibration();
            ucCalibration4 = new Procedure.UCCalibration();
            grpAO = new UIGroupBox();
            panel2 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ucCalibration16 = new Procedure.UCCalibration();
            ucCalibration8 = new Procedure.UCCalibration();
            ucCalibration1 = new Procedure.UCCalibration();
            ucCalibration7 = new Procedure.UCCalibration();
            label7 = new Label();
            panel1.SuspendLayout();
            grpAI.SuspendLayout();
            panel3.SuspendLayout();
            grpAO.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(239, 154, 78);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 38);
            panel1.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(340, 7);
            label2.Name = "label2";
            label2.Size = new Size(66, 26);
            label2.TabIndex = 7;
            label2.Text = "增益值";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(154, 7);
            label3.Name = "label3";
            label3.Size = new Size(66, 26);
            label3.TabIndex = 7;
            label3.Text = "测定值";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(250, 7);
            label1.Name = "label1";
            label1.Size = new Size(66, 26);
            label1.TabIndex = 7;
            label1.Text = "零点值";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("思源黑体 CN Bold", 17F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(235, 227, 221);
            label12.ImeMode = ImeMode.NoControl;
            label12.Location = new Point(705, 427);
            label12.Name = "label12";
            label12.Size = new Size(481, 33);
            label12.TabIndex = 54;
            label12.Text = "计算公式：测定值 = 工程值 * 增益值 - 零点值  ";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // grpAI
            // 
            grpAI.Controls.Add(panel3);
            grpAI.FillColor = Color.FromArgb(49, 54, 64);
            grpAI.FillColor2 = Color.FromArgb(49, 54, 64);
            grpAI.FillDisableColor = Color.FromArgb(49, 54, 64);
            grpAI.Font = new Font("思源黑体 CN Bold", 17F, FontStyle.Bold);
            grpAI.ForeColor = Color.FromArgb(235, 227, 221);
            grpAI.ForeDisableColor = Color.FromArgb(235, 227, 221);
            grpAI.Location = new Point(19, 65);
            grpAI.Margin = new Padding(4, 5, 4, 5);
            grpAI.MinimumSize = new Size(1, 1);
            grpAI.Name = "grpAI";
            grpAI.Padding = new Padding(0, 32, 0, 0);
            grpAI.Radius = 15;
            grpAI.RectColor = Color.FromArgb(49, 54, 64);
            grpAI.RectDisableColor = Color.FromArgb(49, 54, 64);
            grpAI.Size = new Size(622, 652);
            grpAI.TabIndex = 382;
            grpAI.Text = "输入检测";
            grpAI.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.BackColor = Color.FromArgb(49, 54, 64);
            panel3.Controls.Add(ucCalibration2);
            panel3.Controls.Add(ucCalibration9);
            panel3.Controls.Add(ucCalibration3);
            panel3.Controls.Add(ucCalibration4);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(622, 620);
            panel3.TabIndex = 17;
            // 
            // ucCalibration2
            // 
            ucCalibration2.Font = new Font("微软雅黑", 11F);
            ucCalibration2.GainValue = 0D;
            ucCalibration2.Location = new Point(14, 55);
            ucCalibration2.Margin = new Padding(4, 5, 4, 5);
            ucCalibration2.Name = "ucCalibration2";
            ucCalibration2.Size = new Size(561, 37);
            ucCalibration2.TabIndex = 6;
            ucCalibration2.Text = "高压输出(V)";
            ucCalibration2.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration9
            // 
            ucCalibration9.Font = new Font("微软雅黑", 11F);
            ucCalibration9.GainValue = 0D;
            ucCalibration9.Index = 3;
            ucCalibration9.Location = new Point(14, 196);
            ucCalibration9.Margin = new Padding(4, 5, 4, 5);
            ucCalibration9.Name = "ucCalibration9";
            ucCalibration9.Size = new Size(561, 37);
            ucCalibration9.TabIndex = 11;
            ucCalibration9.Text = "厂房电压(V)";
            ucCalibration9.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration3
            // 
            ucCalibration3.Font = new Font("微软雅黑", 11F);
            ucCalibration3.GainValue = 0D;
            ucCalibration3.Index = 1;
            ucCalibration3.Location = new Point(14, 102);
            ucCalibration3.Margin = new Padding(4, 5, 4, 5);
            ucCalibration3.Name = "ucCalibration3";
            ucCalibration3.Size = new Size(561, 37);
            ucCalibration3.TabIndex = 7;
            ucCalibration3.Text = "泄漏电流(mA)";
            ucCalibration3.Submited += ucCalibration_AI_Submited;
            // 
            // ucCalibration4
            // 
            ucCalibration4.Font = new Font("微软雅黑", 11F);
            ucCalibration4.GainValue = 0D;
            ucCalibration4.Index = 2;
            ucCalibration4.Location = new Point(14, 149);
            ucCalibration4.Margin = new Padding(4, 5, 4, 5);
            ucCalibration4.Name = "ucCalibration4";
            ucCalibration4.Size = new Size(561, 37);
            ucCalibration4.TabIndex = 8;
            ucCalibration4.Text = "高压放电(V)";
            ucCalibration4.Submited += ucCalibration_AI_Submited;
            // 
            // grpAO
            // 
            grpAO.BackColor = Color.FromArgb(49, 54, 64);
            grpAO.Controls.Add(panel2);
            grpAO.Controls.Add(ucCalibration16);
            grpAO.Controls.Add(ucCalibration8);
            grpAO.Controls.Add(ucCalibration1);
            grpAO.Controls.Add(ucCalibration7);
            grpAO.FillColor = Color.FromArgb(49, 54, 64);
            grpAO.FillColor2 = Color.FromArgb(49, 54, 64);
            grpAO.FillDisableColor = Color.FromArgb(49, 54, 64);
            grpAO.Font = new Font("思源黑体 CN Bold", 17F, FontStyle.Bold);
            grpAO.ForeColor = Color.FromArgb(235, 227, 221);
            grpAO.Location = new Point(705, 65);
            grpAO.Margin = new Padding(4, 5, 4, 5);
            grpAO.MinimumSize = new Size(1, 1);
            grpAO.Name = "grpAO";
            grpAO.Padding = new Padding(0, 32, 0, 0);
            grpAO.RectColor = Color.FromArgb(49, 54, 64);
            grpAO.RectDisableColor = Color.FromArgb(49, 54, 64);
            grpAO.Size = new Size(585, 322);
            grpAO.TabIndex = 383;
            grpAO.Text = "输出检测";
            grpAO.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(239, 154, 78);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            panel2.Location = new Point(0, 32);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 38);
            panel2.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(235, 227, 221);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(340, 7);
            label4.Name = "label4";
            label4.Size = new Size(66, 26);
            label4.TabIndex = 7;
            label4.Text = "增益值";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(235, 227, 221);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(154, 7);
            label5.Name = "label5";
            label5.Size = new Size(66, 26);
            label5.TabIndex = 7;
            label5.Text = "测定值";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(235, 227, 221);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(250, 7);
            label6.Name = "label6";
            label6.Size = new Size(66, 26);
            label6.TabIndex = 7;
            label6.Text = "零点值";
            // 
            // ucCalibration16
            // 
            ucCalibration16.Font = new Font("微软雅黑", 11F);
            ucCalibration16.GainValue = 0D;
            ucCalibration16.Index = 3;
            ucCalibration16.Location = new Point(16, 217);
            ucCalibration16.Margin = new Padding(4, 5, 4, 5);
            ucCalibration16.Name = "ucCalibration16";
            ucCalibration16.Size = new Size(561, 37);
            ucCalibration16.TabIndex = 12;
            ucCalibration16.Text = "可调电源电压(V)";
            ucCalibration16.Visible = false;
            ucCalibration16.Submited += ucCalibration_AO_Submited;
            // 
            // ucCalibration8
            // 
            ucCalibration8.Font = new Font("微软雅黑", 11F);
            ucCalibration8.GainValue = 0D;
            ucCalibration8.Index = 2;
            ucCalibration8.Location = new Point(16, 170);
            ucCalibration8.Margin = new Padding(4, 5, 4, 5);
            ucCalibration8.Name = "ucCalibration8";
            ucCalibration8.Size = new Size(561, 37);
            ucCalibration8.TabIndex = 10;
            ucCalibration8.Text = "EP03(kPa)";
            ucCalibration8.Visible = false;
            ucCalibration8.Submited += ucCalibration_AO_Submited;
            // 
            // ucCalibration1
            // 
            ucCalibration1.Font = new Font("微软雅黑", 11F);
            ucCalibration1.GainValue = 0D;
            ucCalibration1.Location = new Point(16, 76);
            ucCalibration1.Margin = new Padding(4, 5, 4, 5);
            ucCalibration1.Name = "ucCalibration1";
            ucCalibration1.Size = new Size(561, 37);
            ucCalibration1.TabIndex = 8;
            ucCalibration1.Text = "电压设定(V)";
            ucCalibration1.Submited += ucCalibration_AO_Submited;
            // 
            // ucCalibration7
            // 
            ucCalibration7.Font = new Font("微软雅黑", 11F);
            ucCalibration7.GainValue = 0D;
            ucCalibration7.Index = 1;
            ucCalibration7.Location = new Point(16, 123);
            ucCalibration7.Margin = new Padding(4, 5, 4, 5);
            ucCalibration7.Name = "ucCalibration7";
            ucCalibration7.Size = new Size(561, 37);
            ucCalibration7.TabIndex = 9;
            ucCalibration7.Text = "EP02(kPa)";
            ucCalibration7.Visible = false;
            ucCalibration7.Submited += ucCalibration_AO_Submited;
            // 
            // label7
            // 
            label7.BackColor = Color.FromArgb(239, 154, 78);
            label7.ForeColor = Color.White;
            label7.Location = new Point(671, 62);
            label7.Name = "label7";
            label7.Size = new Size(4, 660);
            label7.TabIndex = 384;
            // 
            // frmHardWare
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(42, 47, 55);
            ClientSize = new Size(1311, 745);
            Controls.Add(label7);
            Controls.Add(grpAO);
            Controls.Add(grpAI);
            Controls.Add(label12);
            Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmHardWare";
            RectColor = Color.FromArgb(49, 54, 64);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "硬件校准";
            TitleColor = Color.FromArgb(47, 55, 64);
            TitleFont = new Font("思源黑体 CN Heavy", 15F, FontStyle.Bold);
            TitleForeColor = Color.FromArgb(239, 154, 78);
            ZoomScaleRect = new Rectangle(15, 15, 1270, 771);
            Load += frmHardWare_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpAI.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            grpAO.ResumeLayout(false);
            grpAO.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Timer timer1;
        private Sunny.UI.UIGroupBox grpAI;
        private Sunny.UI.UIGroupBox grpAO;
        private Procedure.UCCalibration ucCalibration2;
        private Procedure.UCCalibration ucCalibration4;
        private Procedure.UCCalibration ucCalibration3;
        private Procedure.UCCalibration ucCalibration1;
        private Procedure.UCCalibration ucCalibration8;
        private Procedure.UCCalibration ucCalibration7;
        private Procedure.UCCalibration ucCalibration9;
        private Procedure.UCCalibration ucCalibration16;
        private System.Windows.Forms.Panel panel3;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}