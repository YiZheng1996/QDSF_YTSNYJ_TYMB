using MainUI.CurrencyHelper;

namespace MainUI.Procedure
{
    public partial class ucTestParams : ucBaseManagerUI
    {
        private Form form { get; }
        ParaConfig paraconfig = new();
        public ucTestParams(Form form)
        {
            this.form = form;
            InitializeComponent();
        }

        /// <summary>
        /// 数据初始化
        /// </summary>
        private void LoadConfig()
        {
            try
            {
                paraconfig = new ParaConfig();
                paraconfig.SetSectionName(txtModel.Text);
                paraconfig.Load();
                txtRpt.Text = paraconfig.RptFile;
                txtVoltage1.Text = paraconfig.Voltage1;
                txtVoltage2.Text = paraconfig.Voltage2;
                txtVoltage3.Text = paraconfig.Voltage3;
                txtVoltage4.Text = paraconfig.Voltage4;
                txtCurrent1.Text = paraconfig.Current1;
                txtCurrent2.Text = paraconfig.Current2;
                txtCurrent3.Text = paraconfig.Current3;
                txtCurrent4.Text = paraconfig.Current4;
                txtTestTime.Text = paraconfig.TestTime;

            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(form, ex.Message);
            }
        }
        /// <summary>
        /// 确定
        /// </summary>
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtModel.Text))
                {
                    MessageHelper.MessageOK(form, "请选择产品后保存");
                    return;
                }

                paraconfig.SetSectionName(txtModel.Text);
                //paraconfig.RptFile = txtRpt.Text;
                paraconfig.Voltage1 = txtVoltage1.Text;
                paraconfig.Voltage2 = txtVoltage2.Text;
                paraconfig.Voltage3 = txtVoltage3.Text;
                paraconfig.Voltage4 = txtVoltage4.Text;
                paraconfig.Current1 = txtCurrent1.Text;
                paraconfig.Current2 = txtCurrent2.Text;
                paraconfig.Current3 = txtCurrent3.Text;
                paraconfig.Current4 = txtCurrent4.Text;
                paraconfig.TestTime = txtTestTime.Text;

                paraconfig.Save();
                MessageHelper.MessageOK(form, "保存成功。");
            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(form, "保存失败。" + ex.Message);
            }
        }
        /// <summary>
        /// 重置
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtModel.Text))
                LoadConfig();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new()
            {
                InitialDirectory = Application.StartupPath + "reports\\",
                Filter = "Excel2007+|*.xlsx"
            };
            openFile.ShowDialog();
            if (string.IsNullOrEmpty(openFile.FileName) == false)
            {
                string path = openFile.FileName;
                string[] str = path.Split('\\');
                txtRpt.Text = str[^1];
            }
        }

        //产品选择
        private void btnProductSelection_Click(object sender, EventArgs e)
        {
            frmSpec fs = new();
            fs.ShowDialog();
            if (fs.DialogResult == DialogResult.OK)
            {
                txtType.Text = VarHelper.mTestViewModel.ModelName;
                txtModel.Text = VarHelper.mTestViewModel.TypeName;
                LoadConfig();
            }
        }

        private void uiButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtRpt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnParameter_Click(object sender, EventArgs e)
        {
            tabs1.SelectedIndex = 0;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            tabs1.SelectedIndex = 1;
        }
    }
}
