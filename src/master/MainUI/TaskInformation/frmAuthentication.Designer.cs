namespace MainUI.TaskInformation
{
    partial class frmAuthentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuthentication));
            label1 = new AntdUI.Label();
            selectMAC = new AntdUI.Select();
            label2 = new AntdUI.Label();
            divider2 = new AntdUI.Divider();
            uiTitlePanel1 = new UITitlePanel();
            uiPanel1 = new UIPanel();
            btnClose = new UISymbolButton();
            btnRequest = new UISymbolButton();
            btnGetMAC = new UISymbolButton();
            uiTitlePanel1.SuspendLayout();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(235, 227, 221);
            label1.Location = new Point(-16, 66);
            label1.Name = "label1";
            label1.Size = new Size(137, 31);
            label1.TabIndex = 10;
            label1.Text = "MAC地址";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // selectMAC
            // 
            selectMAC.BackColor = Color.FromArgb(49, 54, 64);
            selectMAC.Font = new Font("Microsoft YaHei UI", 13F);
            selectMAC.ForeColor = Color.FromArgb(235, 227, 221);
            selectMAC.List = true;
            selectMAC.ListAutoWidth = true;
            selectMAC.Location = new Point(131, 59);
            selectMAC.MaxCount = 10;
            selectMAC.Name = "selectMAC";
            selectMAC.PlaceholderText = "--请选择--";
            selectMAC.Size = new Size(685, 38);
            selectMAC.TabIndex = 11;
            selectMAC.Text = "--请选择--";
            selectMAC.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(235, 227, 221);
            label2.Location = new Point(0, 75);
            label2.Name = "label2";
            label2.Size = new Size(910, 170);
            label2.TabIndex = 12;
            label2.Text = "1.新接入的耐压机试验台如需跟EPE系统通信，必须先对该设备进行认证授权，只有授权通过后才能进行数据通信。\r\n2.设备认证授权时，调用认证授权接口传入设备的mac地址参数，认证成功返回该设备在EPE系统中产生的唯一编号，认证不成功返回相关错误问题描述。";
            label2.TextAlign = ContentAlignment.TopLeft;
            // 
            // divider2
            // 
            divider2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            divider2.Location = new Point(2, 178);
            divider2.Name = "divider2";
            divider2.Size = new Size(658, 23);
            divider2.TabIndex = 16;
            divider2.Text = "MAC地址操作";
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(uiPanel1);
            uiTitlePanel1.Dock = DockStyle.Bottom;
            uiTitlePanel1.FillColor = Color.FromArgb(42, 47, 55);
            uiTitlePanel1.FillColor2 = Color.FromArgb(42, 47, 55);
            uiTitlePanel1.FillDisableColor = Color.FromArgb(42, 47, 55);
            uiTitlePanel1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            uiTitlePanel1.Location = new Point(0, 252);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.RectColor = Color.FromArgb(42, 47, 55);
            uiTitlePanel1.RectDisableColor = Color.FromArgb(42, 47, 55);
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(915, 338);
            uiTitlePanel1.TabIndex = 22;
            uiTitlePanel1.Text = "MAC地址操作";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            uiTitlePanel1.TitleColor = Color.FromArgb(47, 55, 64);
            uiTitlePanel1.TitleForeColor = Color.FromArgb(239, 154, 78);
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(btnClose);
            uiPanel1.Controls.Add(btnRequest);
            uiPanel1.Controls.Add(btnGetMAC);
            uiPanel1.Controls.Add(label1);
            uiPanel1.Controls.Add(selectMAC);
            uiPanel1.FillColor = Color.FromArgb(47, 55, 64);
            uiPanel1.FillColor2 = Color.FromArgb(47, 55, 64);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(29, 51);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Radius = 15;
            uiPanel1.RectColor = Color.FromArgb(47, 55, 64);
            uiPanel1.RectDisableColor = Color.FromArgb(47, 55, 64);
            uiPanel1.Size = new Size(859, 268);
            uiPanel1.TabIndex = 22;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            uiPanel1.Click += uiPanel1_Click;
            // 
            // btnClose
            // 
            btnClose.FillColor = Color.FromArgb(70, 75, 85);
            btnClose.FillColor2 = Color.FromArgb(70, 75, 85);
            btnClose.FillDisableColor = Color.FromArgb(70, 75, 85);
            btnClose.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(235, 227, 221);
            btnClose.ForeDisableColor = Color.FromArgb(235, 227, 221);
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(635, 198);
            btnClose.MinimumSize = new Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Radius = 10;
            btnClose.RectColor = Color.FromArgb(70, 75, 85);
            btnClose.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnClose.Size = new Size(181, 38);
            btnClose.Symbol = 0;
            btnClose.TabIndex = 24;
            btnClose.Text = "退  出";
            btnClose.TipsFont = new Font("宋体", 11F);
            btnClose.Click += BtnClose_Click;
            // 
            // btnRequest
            // 
            btnRequest.FillColor = Color.FromArgb(70, 75, 85);
            btnRequest.FillColor2 = Color.FromArgb(70, 75, 85);
            btnRequest.FillDisableColor = Color.FromArgb(70, 75, 85);
            btnRequest.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            btnRequest.ForeColor = Color.FromArgb(235, 227, 221);
            btnRequest.ForeDisableColor = Color.FromArgb(235, 227, 221);
            btnRequest.Image = (Image)resources.GetObject("btnRequest.Image");
            btnRequest.Location = new Point(342, 198);
            btnRequest.MinimumSize = new Size(1, 1);
            btnRequest.Name = "btnRequest";
            btnRequest.Radius = 10;
            btnRequest.RectColor = Color.FromArgb(70, 75, 85);
            btnRequest.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnRequest.Size = new Size(181, 38);
            btnRequest.Symbol = 0;
            btnRequest.TabIndex = 23;
            btnRequest.Text = "MAC地址请求";
            btnRequest.TipsFont = new Font("宋体", 11F);
            btnRequest.Click += BtnRequest_Click;
            // 
            // btnGetMAC
            // 
            btnGetMAC.FillColor = Color.FromArgb(70, 75, 85);
            btnGetMAC.FillColor2 = Color.FromArgb(70, 75, 85);
            btnGetMAC.FillDisableColor = Color.FromArgb(70, 75, 85);
            btnGetMAC.Font = new Font("思源黑体 CN Bold", 13F, FontStyle.Bold);
            btnGetMAC.ForeColor = Color.FromArgb(235, 227, 221);
            btnGetMAC.ForeDisableColor = Color.FromArgb(235, 227, 221);
            btnGetMAC.Image = (Image)resources.GetObject("btnGetMAC.Image");
            btnGetMAC.Location = new Point(44, 198);
            btnGetMAC.MinimumSize = new Size(1, 1);
            btnGetMAC.Name = "btnGetMAC";
            btnGetMAC.Radius = 10;
            btnGetMAC.RectColor = Color.FromArgb(70, 75, 85);
            btnGetMAC.RectDisableColor = Color.FromArgb(70, 75, 85);
            btnGetMAC.Size = new Size(181, 38);
            btnGetMAC.Symbol = 0;
            btnGetMAC.TabIndex = 22;
            btnGetMAC.Text = "MAC地址获取";
            btnGetMAC.TipsFont = new Font("宋体", 11F);
            btnGetMAC.Click += BtnGetMAC_Click;
            // 
            // frmAuthentication
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(42, 47, 55);
            ClientSize = new Size(915, 590);
            ControlBox = false;
            Controls.Add(uiTitlePanel1);
            Controls.Add(label2);
            Controls.Add(divider2);
            MaximizeBox = false;
            MaximumSize = new Size(915, 590);
            MinimizeBox = false;
            Name = "frmAuthentication";
            RectColor = Color.FromArgb(47, 55, 64);
            ShowIcon = false;
            Text = "注意事项";
            TextAlignment = StringAlignment.Center;
            TitleColor = Color.FromArgb(47, 55, 64);
            TitleFont = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            TitleForeColor = Color.FromArgb(239, 154, 78);
            ZoomScaleRect = new Rectangle(15, 15, 660, 375);
            uiTitlePanel1.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Label label1;
        private AntdUI.Select selectMAC;
        private AntdUI.Label label2;
        private AntdUI.Divider divider2;
        private UITitlePanel uiTitlePanel1;
        private UIPanel uiPanel1;
        private UISymbolButton btnGetMAC;
        private UISymbolButton btnRequest;
        private UISymbolButton btnClose;
    }
}