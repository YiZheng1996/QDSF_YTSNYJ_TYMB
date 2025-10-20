using MainUI.CurrencyHelper;

namespace MainUI.TaskInformation
{
    public partial class frmAuxiliary : UIForm
    {
        public UploadResultsModel uploadResultsModel;
        public frmAuxiliary()
        {
            InitializeComponent();
            dateComMutualTime.Value = DateTime.Now;
            dateQualityTime.Value = DateTime.Now;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ComMutualResult.SelectedIndex == -1 || ComQualityResult.SelectedIndex == -1)
            {
                MessageHelper.MessageOK(this, "质检与互检未选择！"); return;
            }

            uploadResultsModel = new()
            {
                mutualResult = ComMutualResult.SelectedIndex.ToString(),
                mutualTime = dateComMutualTime.Value.ToString(),
                qualityResult = ComQualityResult.SelectedIndex.ToString(),
                qualityTime = dateQualityTime.Value.ToString(),
            };
            Close();
            DialogResult = DialogResult.OK;
        }
    }
}
