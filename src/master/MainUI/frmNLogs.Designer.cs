namespace MainUI
{
    partial class frmNLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNLogs));
            lstViewNlg = new System.Windows.Forms.ListView();
            imageList1 = new System.Windows.Forms.ImageList(components);
            uiLabel1 = new Sunny.UI.UILabel();
            cboType = new Sunny.UI.UIComboBox();
            dtpStartBig = new Sunny.UI.UIDatePicker();
            uiLabel4 = new Sunny.UI.UILabel();
            btnSearch = new Sunny.UI.UIButton();
            btnClose = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // lstViewNlg
            // 
            lstViewNlg.BackColor = System.Drawing.Color.FromArgb(243, 249, 255);
            lstViewNlg.FullRowSelect = true;
            lstViewNlg.GridLines = true;
            lstViewNlg.Location = new System.Drawing.Point(3, 92);
            lstViewNlg.Name = "lstViewNlg";
            lstViewNlg.Size = new System.Drawing.Size(984, 474);
            lstViewNlg.SmallImageList = imageList1;
            lstViewNlg.TabIndex = 0;
            lstViewNlg.UseCompatibleStateImageBehavior = false;
            lstViewNlg.View = System.Windows.Forms.View.Details;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "提示-trace.png");
            imageList1.Images.SetKeyName(1, "搜索-DEBUG.png");
            imageList1.Images.SetKeyName(2, "info-fill.png");
            imageList1.Images.SetKeyName(3, "黄色提示-WARN.png");
            imageList1.Images.SetKeyName(4, "红色感叹号-ERROR.png");
            imageList1.Images.SetKeyName(5, "红色停止-FATAL.png");
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new System.Drawing.Point(15, 49);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(93, 23);
            uiLabel1.TabIndex = 74;
            uiLabel1.Text = "日志等级:";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboType
            // 
            cboType.DataSource = null;
            cboType.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            cboType.FillColor = System.Drawing.Color.White;
            cboType.FilterMaxCount = 50;
            cboType.Font = new System.Drawing.Font("微软雅黑", 12F);
            cboType.ItemHoverColor = System.Drawing.Color.FromArgb(155, 200, 255);
            cboType.Items.AddRange(new object[] { "Trace", "Debug", "Info ", "Warn ", "Error", "Fatal" });
            cboType.ItemSelectForeColor = System.Drawing.Color.FromArgb(235, 243, 255);
            cboType.Location = new System.Drawing.Point(110, 46);
            cboType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cboType.MinimumSize = new System.Drawing.Size(63, 0);
            cboType.Name = "cboType";
            cboType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            cboType.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            cboType.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom;
            cboType.Size = new System.Drawing.Size(165, 29);
            cboType.SymbolSize = 24;
            cboType.TabIndex = 73;
            cboType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            cboType.Watermark = "请选择";
            // 
            // dtpStartBig
            // 
            dtpStartBig.FillColor = System.Drawing.Color.White;
            dtpStartBig.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            dtpStartBig.Location = new System.Drawing.Point(406, 46);
            dtpStartBig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            dtpStartBig.MaxLength = 10;
            dtpStartBig.MinimumSize = new System.Drawing.Size(63, 0);
            dtpStartBig.Name = "dtpStartBig";
            dtpStartBig.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            dtpStartBig.Size = new System.Drawing.Size(165, 29);
            dtpStartBig.SymbolDropDown = 61555;
            dtpStartBig.SymbolNormal = 61555;
            dtpStartBig.SymbolSize = 24;
            dtpStartBig.TabIndex = 392;
            dtpStartBig.Text = "2024-07-19";
            dtpStartBig.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            dtpStartBig.Value = new System.DateTime(2024, 7, 19, 0, 0, 0, 0);
            dtpStartBig.Watermark = "";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiLabel4.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new System.Drawing.Point(316, 49);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new System.Drawing.Size(97, 23);
            uiLabel4.TabIndex = 391;
            uiLabel4.Text = "记录时间:";
            uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSearch.Font = new System.Drawing.Font("微软雅黑", 11F);
            btnSearch.Location = new System.Drawing.Point(599, 42);
            btnSearch.MinimumSize = new System.Drawing.Size(1, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(120, 40);
            btnSearch.TabIndex = 393;
            btnSearch.Text = "搜索";
            btnSearch.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnSearch.TipsText = "1";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClose.Font = new System.Drawing.Font("微软雅黑", 11F);
            btnClose.Location = new System.Drawing.Point(405, 572);
            btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(160, 35);
            btnClose.TabIndex = 394;
            btnClose.Text = "退  出";
            btnClose.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            btnClose.TipsText = "1";
            btnClose.Click += btnClose_Click;
            // 
            // frmNLogs
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(990, 614);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(btnSearch);
            Controls.Add(dtpStartBig);
            Controls.Add(uiLabel4);
            Controls.Add(uiLabel1);
            Controls.Add(cboType);
            Controls.Add(lstViewNlg);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNLogs";
            Padding = new System.Windows.Forms.Padding(0, 29, 0, 0);
            ShowIcon = false;
            Text = "日志显示";
            TitleHeight = 29;
            ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            Load += frmNLogs_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListView lstViewNlg;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cboType;
        private Sunny.UI.UIDatePicker dtpStartBig;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton btnSearch;
        private Sunny.UI.UIButton btnClose;
        private System.Windows.Forms.ImageList imageList1;
    }
}