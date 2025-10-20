using MainUI.CurrencyHelper;

namespace MainUI.Procedure
{
    public partial class ucUserSelection : UserControl
    {
        private Form form1 = null;
        public ucUserSelection(Form form)
        {
            form1 = form;
            InitializeComponent();
        }

        private AuxiliaryBLL bLL = new();

        private void InitData() => dataGridView1.DataSource = bLL.AuxiliaryModels(new AuxiliaryModel());

        private void ucUserSelection_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RowData();
        }

        private void RowData()
        {
            try
            {
                if (dataGridView1.DataSource == null && dataGridView1.Rows.Count < 1) return;
                txtmutualPersonName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["colmutualPersonName"].Value.ToString();
                txtmutualPerson.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["colmutualPerson"].Value.ToString();
                txtqualityPersonName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["colqualityPersonName"].Value.ToString();
                txtqualityPerson.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["colqualityPerson"].Value.ToString();
                txtauxiliariesCode1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["colauxiliariesCode1"].Value.ToString();
                txtauxiliariesCode2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["colauxiliariesCode2"].Value.ToString();
                txtauxiliariesCode3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["colauxiliariesCode3"].Value.ToString();
                txtauxiliariesCode4.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["colauxiliariesCode4"].Value.ToString();
                txtauxiliariesName1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["colauxiliariesName1"].Value.ToString();
                txtauxiliariesName2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["colauxiliariesName2"].Value.ToString();
                txtauxiliariesName3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["colauxiliariesName3"].Value.ToString();
                txtauxiliariesName4.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["colauxiliariesName4"].Value.ToString();
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("人员选择界面，选择数据错误：" + ex.Message);
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (bLL.AddAuxiliary(new AuxiliaryModel()
            {
                mutualPersonName = txtmutualPersonName.Text.Trim(),
                mutualPerson = txtmutualPerson.Text.Trim(),
                qualityPersonName = txtqualityPersonName.Text.Trim(),
                qualityPerson = txtqualityPerson.Text.Trim(),
                auxiliariesName1 = txtauxiliariesName1.Text.Trim(),
                auxiliariesCode1 = txtauxiliariesCode1.Text.Trim(),
                auxiliariesName2 = txtauxiliariesName2.Text.Trim(),
                auxiliariesCode2 = txtauxiliariesCode2.Text.Trim(),
                auxiliariesName3 = txtauxiliariesName3.Text.Trim(),
                auxiliariesCode3 = txtauxiliariesCode3.Text.Trim(),
                auxiliariesName4 = txtauxiliariesName4.Text.Trim(),
                auxiliariesCode4 = txtauxiliariesCode4.Text.Trim(),
            }))
            {
                MessageHelper.MessageOK(form1, "新增成功！");
            }
            else
            {
                MessageHelper.MessageOK(form1, "新增失败！");
            }
            InitData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) { MessageHelper.MessageOK(form1, "未能选中任何行！"); return; }
            if (MessageHelper.MessageYes(form1, "删除后数据无法复原，是否删除？") == DialogResult.OK)
            {
                if (bLL.DeleteAuxiliary(new AuxiliaryModel()
                {
                    ID = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["colID"].Value.ToInt32(),
                }))
                {
                    MessageHelper.MessageOK(form1, "删除成功！");
                }
                else
                {
                    MessageHelper.MessageOK(form1, "删除失败！");
                }
                InitData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) { MessageHelper.MessageOK(form1, "未能选中任何行！"); return; }
            if (bLL.UpdateAuxiliary(new AuxiliaryModel()
            {
                ID = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["colID"].Value.ToInt32(),
                mutualPersonName = txtmutualPersonName.Text.Trim(),
                mutualPerson = txtmutualPerson.Text.Trim(),
                qualityPersonName = txtqualityPersonName.Text.Trim(),
                qualityPerson = txtqualityPerson.Text.Trim(),
                auxiliariesName1 = txtauxiliariesName1.Text.Trim(),
                auxiliariesCode1 = txtauxiliariesCode1.Text.Trim(),
                auxiliariesName2 = txtauxiliariesName2.Text.Trim(),
                auxiliariesCode2 = txtauxiliariesCode2.Text.Trim(),
                auxiliariesName3 = txtauxiliariesName3.Text.Trim(),
                auxiliariesCode3 = txtauxiliariesCode3.Text.Trim(),
                auxiliariesName4 = txtauxiliariesName4.Text.Trim(),
                auxiliariesCode4 = txtauxiliariesCode4.Text.Trim(),
            }))
            {
                MessageHelper.MessageOK(form1, "修改成功！");
            }
            else
            {
                MessageHelper.MessageOK(form1, "修改失败！");
            }
            InitData();
        }


    }
}
