namespace MainUI
{
    partial class frmSettingMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettingMain));
            treeView1 = new UITreeView();
            imageList1 = new ImageList(components);
            pnlMain = new UIPanel();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.FillColor = Color.FromArgb(49, 54, 64);
            treeView1.FillColor2 = Color.FromArgb(49, 54, 64);
            resources.ApplyResources(treeView1, "treeView1");
            treeView1.ForeColor = Color.FromArgb(235, 227, 221);
            treeView1.ForeDisableColor = Color.FromArgb(235, 227, 221);
            treeView1.HoverColor = Color.FromArgb(70, 75, 85);
            treeView1.ImageList = imageList1;
            treeView1.ItemHeight = 50;
            treeView1.Name = "treeView1";
            treeView1.RectColor = Color.FromArgb(49, 54, 64);
            treeView1.ScrollBarColor = Color.FromArgb(239, 154, 78);
            treeView1.ScrollBarRectColor = Color.FromArgb(239, 154, 78);
            treeView1.ScrollBarStyleInherited = false;
            treeView1.SelectedColor = Color.FromArgb(70, 75, 85);
            treeView1.SelectedForeColor = Color.FromArgb(235, 227, 221);
            treeView1.ShowText = false;
            treeView1.Style = UIStyle.Custom;
            treeView1.TextAlignment = ContentAlignment.MiddleCenter;
            treeView1.BeforeSelect += treeView1_BeforeSelect;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "用户管理-25+25.png");
            imageList1.Images.SetKeyName(1, "型号管理-25+25.png");
            imageList1.Images.SetKeyName(2, "参数设置-25+25.png");
            imageList1.Images.SetKeyName(3, "人员管理-25+25.png");
            imageList1.Images.SetKeyName(4, "保护参数-25+27.png");
            imageList1.Images.SetKeyName(5, "指纹.png");
            // 
            // pnlMain
            // 
            pnlMain.FillColor = Color.FromArgb(49, 54, 64);
            pnlMain.FillColor2 = Color.FromArgb(49, 54, 64);
            resources.ApplyResources(pnlMain, "pnlMain");
            pnlMain.ForeColor = Color.FromArgb(235, 227, 221);
            pnlMain.ForeDisableColor = Color.FromArgb(235, 227, 221);
            pnlMain.Name = "pnlMain";
            pnlMain.RectColor = Color.FromArgb(49, 54, 64);
            pnlMain.RectDisableColor = Color.FromArgb(49, 54, 64);
            pnlMain.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // frmSettingMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(42, 47, 55);
            resources.ApplyResources(this, "$this");
            ControlBoxFillHoverColor = Color.FromArgb(42, 47, 55);
            Controls.Add(pnlMain);
            Controls.Add(treeView1);
            ForeColor = Color.FromArgb(235, 227, 221);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSettingMain";
            RectColor = Color.FromArgb(42, 47, 55);
            ShowIcon = false;
            ShowInTaskbar = false;
            TitleColor = Color.FromArgb(49, 54, 64);
            TitleFont = new Font("思源黑体 CN Heavy", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            TitleForeColor = Color.FromArgb(239, 154, 78);
            ZoomScaleRect = new Rectangle(15, 15, 854, 666);
            Load += frmMain_Load;
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UITreeView treeView1;
        private UIPanel pnlMain;
        private ImageList imageList1;
    }
}