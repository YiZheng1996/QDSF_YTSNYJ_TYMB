using Report;

namespace MainUI
{
    partial class frmDispReport
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
            grpDI = new UIGroupBox();
            ucGrid1 = new UcGrid();
            BtnPrint = new UIButton();
            BtnClose = new UIButton();
            btnPageUp = new UIButton();
            btnPageDown = new UIButton();
            numericUpDown1 = new NumericUpDown();
            grpDI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // grpDI
            // 
            grpDI.Controls.Add(ucGrid1);
            grpDI.FillColor = Color.FromArgb(49, 54, 64);
            grpDI.FillColor2 = Color.FromArgb(49, 54, 64);
            grpDI.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            grpDI.ForeColor = Color.FromArgb(235, 227, 221);
            grpDI.ForeDisableColor = Color.FromArgb(235, 227, 221);
            grpDI.Location = new Point(26, 61);
            grpDI.Margin = new Padding(4, 5, 4, 5);
            grpDI.MinimumSize = new Size(1, 1);
            grpDI.Name = "grpDI";
            grpDI.Padding = new Padding(0, 32, 0, 0);
            grpDI.RectColor = Color.FromArgb(49, 54, 64);
            grpDI.RectDisableColor = Color.FromArgb(49, 54, 64);
            grpDI.Size = new Size(908, 679);
            grpDI.TabIndex = 390;
            grpDI.Text = "试验报表";
            grpDI.TextAlignment = ContentAlignment.MiddleCenter;
            grpDI.TitleAlignment = HorizontalAlignment.Center;
            // 
            // ucGrid1
            // 
            ucGrid1.Dock = DockStyle.Fill;
            ucGrid1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            ucGrid1.Location = new Point(0, 32);
            ucGrid1.Margin = new Padding(4, 5, 4, 5);
            ucGrid1.Name = "ucGrid1";
            ucGrid1.Size = new Size(908, 647);
            ucGrid1.TabIndex = 0;
            // 
            // BtnPrint
            // 
            BtnPrint.Cursor = Cursors.Hand;
            BtnPrint.FillColor = Color.FromArgb(70, 75, 85);
            BtnPrint.FillColor2 = Color.FromArgb(70, 75, 85);
            BtnPrint.FillDisableColor = Color.FromArgb(70, 75, 85);
            BtnPrint.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            BtnPrint.ForeColor = Color.FromArgb(235, 227, 221);
            BtnPrint.ForeDisableColor = Color.FromArgb(235, 227, 221);
            BtnPrint.Location = new Point(588, 759);
            BtnPrint.MinimumSize = new Size(1, 1);
            BtnPrint.Name = "BtnPrint";
            BtnPrint.RectColor = Color.FromArgb(70, 75, 85);
            BtnPrint.RectDisableColor = Color.FromArgb(70, 75, 85);
            BtnPrint.Size = new Size(120, 40);
            BtnPrint.TabIndex = 392;
            BtnPrint.Text = "打  印";
            BtnPrint.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnPrint.TipsText = "1";
            BtnPrint.Click += BtnPrint_Click;
            // 
            // BtnClose
            // 
            BtnClose.Cursor = Cursors.Hand;
            BtnClose.FillColor = Color.FromArgb(70, 75, 85);
            BtnClose.FillColor2 = Color.FromArgb(70, 75, 85);
            BtnClose.FillDisableColor = Color.FromArgb(70, 75, 85);
            BtnClose.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            BtnClose.ForeColor = Color.FromArgb(235, 227, 221);
            BtnClose.ForeDisableColor = Color.FromArgb(235, 227, 221);
            BtnClose.Location = new Point(731, 759);
            BtnClose.MinimumSize = new Size(1, 1);
            BtnClose.Name = "BtnClose";
            BtnClose.RectColor = Color.FromArgb(70, 75, 85);
            BtnClose.RectDisableColor = Color.FromArgb(70, 75, 85);
            BtnClose.Size = new Size(120, 40);
            BtnClose.TabIndex = 393;
            BtnClose.Text = "退  出";
            BtnClose.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BtnClose.TipsText = "1";
            BtnClose.Click += BtnClose_Click;
            // 
            // btnPageUp
            // 
            btnPageUp.Cursor = Cursors.Hand;
            btnPageUp.FillColor = Color.FromArgb(70, 75, 85);
            btnPageUp.FillColor2 = Color.FromArgb(70, 75, 85);
            btnPageUp.FillDisableColor = Color.FromArgb(70, 75, 85);
            btnPageUp.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            btnPageUp.ForeColor = Color.FromArgb(235, 227, 221);
            btnPageUp.ForeDisableColor = Color.FromArgb(235, 227, 221);
            btnPageUp.Location = new Point(113, 759);
            btnPageUp.MinimumSize = new Size(1, 1);
            btnPageUp.Name = "btnPageUp";
            btnPageUp.RectColor = Color.FromArgb(70, 75, 85);
            btnPageUp.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnPageUp.Size = new Size(120, 40);
            btnPageUp.TabIndex = 400;
            btnPageUp.Text = "上翻";
            btnPageUp.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnPageUp.TipsText = "1";
            btnPageUp.Click += btnPageUp_Click;
            // 
            // btnPageDown
            // 
            btnPageDown.Cursor = Cursors.Hand;
            btnPageDown.FillColor = Color.FromArgb(70, 75, 85);
            btnPageDown.FillColor2 = Color.FromArgb(70, 75, 85);
            btnPageDown.FillDisableColor = Color.FromArgb(70, 75, 85);
            btnPageDown.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            btnPageDown.ForeColor = Color.FromArgb(235, 227, 221);
            btnPageDown.ForeDisableColor = Color.FromArgb(235, 227, 221);
            btnPageDown.Location = new Point(309, 759);
            btnPageDown.MinimumSize = new Size(1, 1);
            btnPageDown.Name = "btnPageDown";
            btnPageDown.RectColor = Color.FromArgb(70, 75, 85);
            btnPageDown.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnPageDown.Size = new Size(120, 40);
            btnPageDown.TabIndex = 401;
            btnPageDown.Text = "下翻";
            btnPageDown.TipsFont = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            btnPageDown.TipsText = "1";
            btnPageDown.Click += btnPageDown_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("微软雅黑", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            numericUpDown1.Location = new Point(241, 765);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(55, 27);
            numericUpDown1.TabIndex = 402;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // frmDispReport
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(42, 47, 55);
            ClientSize = new Size(956, 813);
            Controls.Add(numericUpDown1);
            Controls.Add(btnPageUp);
            Controls.Add(btnPageDown);
            Controls.Add(BtnClose);
            Controls.Add(BtnPrint);
            Controls.Add(grpDI);
            Font = new Font("微软雅黑", 9F);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDispReport";
            RectColor = Color.FromArgb(49, 54, 64);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "试验结果";
            TitleColor = Color.FromArgb(49, 54, 64);
            TitleFont = new Font("思源黑体 CN Heavy", 15F, FontStyle.Bold);
            TitleForeColor = Color.FromArgb(239, 154, 78);
            TopMost = true;
            ZoomScaleRect = new Rectangle(15, 15, 903, 724);
            Load += frmDispReport_Load;
            grpDI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UIGroupBox grpDI;
        private Sunny.UI.UIButton BtnPrint;
        private Sunny.UI.UIButton BtnClose;
        private Sunny.UI.UIButton btnPageUp;
        private Sunny.UI.UIButton btnPageDown;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private UcGrid ucGrid1;
    }
}