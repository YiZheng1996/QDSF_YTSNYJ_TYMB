namespace MainUI
{
    public partial class frmDispReport : UIForm
    {
        private string filename;
        public frmDispReport(string file)
        {
            InitializeComponent();
            filename = file;
        }
        private void frmDispReport_Load(object sender, EventArgs e)
        {
            grpDI.Enabled = false;
            ucGrid1.LoadFile(filename);
        }
        private void BtnPrint_Click(object sender, EventArgs e)
        {
            ucGrid1.Print(filename);
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        int AlturaCount = 30;
        int rowIndex = 0;
        private bool isDow = false;
        private void btnPageUp_Click(object sender, EventArgs e)
        {
            if (isDow) { rowIndex -= AlturaCount; isDow = false; }
            rowIndex -= numericUpDown1.Value.ToInt32();
            ucGrid1.PageTurning(rowIndex);
        }

        private void btnPageDown_Click(object sender, EventArgs e)
        {
            if (!isDow) { rowIndex = AlturaCount; isDow = true; }
            rowIndex += numericUpDown1.Value.ToInt32();
            ucGrid1.PageTurning(rowIndex);
        }
    }
}
