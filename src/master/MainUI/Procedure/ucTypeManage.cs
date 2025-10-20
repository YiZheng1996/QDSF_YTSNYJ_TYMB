using MainUI.CurrencyHelper;

namespace MainUI.Procedure
{
    public partial class ucTypeManage : ucBaseManagerUI
    {
        TypeBLL bll = new();
        string grpTxt = "";
        private Form form { get; }
        public ucTypeManage(Form form)
        {
            this.form = form;
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void ucModelManage_Load(object sender, EventArgs e)
        {
            grpTxt = groupBox1.Text;
            LoadModelType();

        }
        private void LoadModelType()
        {
            ModelBLL BLLmodelType = new();
            DataTable dt = BLLmodelType.GetAllModelType();
            if (dt == null)
                return;

            cboModelName.DisplayMember = "ModelType";
            cboModelName.ValueMember = "ID";
            cboModelName.DataSource = dt;
        }
        private void LoadModel(int typeid)
        {
            DataTable dt = bll.GetAllKind(typeid);

            if (dt == null)
                return;
            dataGridView1.DataSource = dt;
            txtTypeName.Text = "";
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string curModel = txtTypeName.Text.Trim();
                if (string.IsNullOrEmpty(curModel))
                    return;
                int typeid = Convert.ToInt32(cboModelName.SelectedValue.ToString());
                string mark = txtMark.Text;
                if (bll.IsExist(typeid, curModel, mark))
                {
                    MessageHelper.MessageOK(form, "型号【" + curModel + "】已存在");
                    return;
                }
                if (bll.Add(curModel, typeid, mark, LXname))
                {

                    MessageHelper.MessageOK(form, "新增成功");
                    LoadModel(typeid);
                }
                else
                {
                    MessageHelper.MessageOK(form, "新增失败");
                }
            }
            catch (Exception)
            {
                MessageHelper.MessageOK(form, "新增失败");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (bll.Delete(modelid, cboModelName.Text, modelname))
                {

                    MessageHelper.MessageOK(form, "删除成功");
                    LoadModel(id);
                }
                else
                {
                    MessageHelper.MessageOK(form, "删除失败");
                }
            }
            catch (Exception)
            {

                MessageHelper.MessageOK(form, "删除失败");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                ParaConfig paraconfig = new();
                paraconfig.SetSectionName(modelname);
                paraconfig.Load();
                string a = paraconfig.RptFile;
                string curModel = txtTypeName.Text.Trim();
                if (string.IsNullOrEmpty(curModel))
                    return;
                int typeid = Convert.ToInt32(cboModelName.SelectedValue.ToString());
                string mark = txtMark.Text;

                if (bll.Update(modelid, curModel, typeid, mark, (cboModelName.Text), (modelname)))
                {
                    paraconfig.SetSectionName(curModel);
                    //paraconfig.RptFile = a;
                    paraconfig.Save();
                    MessageHelper.MessageOK(form, "修改成功");

                    LoadModel(id);
                }
                else
                {
                    MessageHelper.MessageOK(form, "修改失败");

                }
            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(form, "修改失败" + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowCurRecord();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //ShowCurRecord();
        }
        int modelid = 0;
        string modelname = "";
        private void ShowCurRecord()
        {
            if (dataGridView1.DataSource == null)
                return;
            if (dataGridView1.Rows.Count < 1)
                return;
            modelid = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ModelNo"].Value);
            modelname = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["name"].Value.ToString();
            string mark = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["mark"].Value.ToString();
            txtTypeName.Text = modelname;
            txtMark.Text = mark;

        }
        int id = 0;
        private void cboModelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTypeName.Text = "";
            txtMark.Text = "";
            id = Convert.ToInt32(cboModelName.SelectedValue.ToString());
            LoadModel(id);

            LXname = cboModelName.Text;
        }
        string LXname = "";

        private void uiButton1_Click(object sender, EventArgs e)
        {
            //frmConfigDialog conf = new frmConfigDialog();
            //for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            //{
            //    string testItem = this.dataGridView1.Rows[i].Cells["colName"].Value.ToString();
            //    IniFileConfig config = new IniFileConfig(testItem);
            //    config.Filename = string.Format(Application.StartupPath + "\\proc\\{0}\\{1}\\{2}.ini", this.cmbProductType.Text, SpecificSymbol(this.cmbProductModel.Text), testItem);
            //    config.Load();
            //    conf.Add(config);
            //}
            //conf.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowCurRecord();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ShowCurRecord();
        }

    }
}
