using MainUI.CurrencyHelper;

namespace MainUI.TaskInformation
{
    public partial class frmUserSelection : UIForm
    {
        AuxiliaryBLL bLL = new();
        public AuxiliaryModel model = new();
        public frmUserSelection()
        {
            InitializeComponent();
            var data = bLL.AuxiliaryModels(new AuxiliaryModel());
            foreach (var item in data) ComMutualPerson.Items.Add(value: item.mutualPerson);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ComMutualPerson.SelectedValue?.ToString()))
            {
                MessageHelper.MessageOK(this, "未选择人员！");
                return;
            }
            Close();
        }

        private void ComMutualPerson_SelectedIndexChanged(object sender, AntdUI.IntEventArgs e)
        {
            try
            {
                var Com = sender as AntdUI.Select;
                var data = bLL.AuxiliaryModels(new AuxiliaryModel
                {
                    mutualPerson = Com.SelectedValue.ToString(),
                }).FirstOrDefault();
                model = data;
                txtmutualPersonName.Text = data.mutualPersonName;
                txtqualityPerson.Text = data.qualityPerson;
                txtqualityPersonName.Text = data.qualityPersonName;
                txtauxiliariesCode1.Text = data.auxiliariesCode1;
                txtauxiliariesName1.Text = data.auxiliariesName1;
                txtauxiliariesCode2.Text = data.auxiliariesCode2;
                txtauxiliariesName2.Text = data.auxiliariesName2;
                txtauxiliariesCode3.Text = data.auxiliariesCode3;
                txtauxiliariesName3.Text = data.auxiliariesName3;
                txtauxiliariesCode4.Text = data.auxiliariesCode4;
                txtauxiliariesName4.Text = data.auxiliariesName4;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("人员选择错误：", ex);
                MessageHelper.MessageOK(this, "人员选择错误：" + ex);
            }
        }
    }
}
