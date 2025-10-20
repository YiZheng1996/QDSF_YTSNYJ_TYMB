using MainUI.CurrencyHelper;
using System.Text;

namespace MainUI
{
    public partial class frmSpec : UIForm
    {
        public frmSpec()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSpec_Load(object sender, EventArgs e)
        {
            btnGet.Enabled = false;
            uiButton3.Enabled = false;
            uiDataGridView1.AutoGenerateColumns = false;
            uiDataGridView1.ReadOnly = true;
            BindModels();
        }
        ModelBLL pbll = new();
        Dictionary<string, int> dicType = [];
        /// <summary>
        /// 获取被试品类别列表
        /// </summary>
        private void BindModels()
        {
            DataTable dt = pbll.GetAllModelType();
            foreach (DataRow item in dt.Rows)
            {
                cboModel.Items.Add(item[1].ToString());
                dicType.Add(item[1].ToString(), Convert.ToInt32(item[0]));
            }
            //cboModel.SelectedIndex = 0;
        }
        /// <summary>
        /// 上翻
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.Rows.Count > 0)
            {
                if (this.uiDataGridView1.CurrentRow.Index > 0)
                {
                    int i = uiDataGridView1.Rows.GetPreviousRow(uiDataGridView1.CurrentRow.Index, DataGridViewElementStates.None);//获取原选定上一行索引
                    uiDataGridView1.Rows[i].Selected = true; //选中整行
                    uiDataGridView1.CurrentCell = uiDataGridView1[1, i];//指针上移
                }
            }
        }
        /// <summary>
        /// 下翻
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.Rows.Count > 0)
            {
                if (this.uiDataGridView1.CurrentRow.Index < this.uiDataGridView1.Rows.Count - 1)
                {
                    int i = uiDataGridView1.Rows.GetNextRow(uiDataGridView1.CurrentRow.Index, DataGridViewElementStates.None);//获取原选定下一行索引
                    uiDataGridView1.Rows[i].Selected = true; //选中整行
                    uiDataGridView1.CurrentCell = uiDataGridView1[1, i];//指针下移
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GetModel();
        }

        public void GetModel()
        {
            VarHelper.mTestViewModel.TypeID = Convert.ToInt32(uiDataGridView1.Rows[uiDataGridView1.CurrentRow.Index].Cells["colID"].Value);//得到当前选择的型号ID
            VarHelper.mTestViewModel.ModelName = uiDataGridView1.Rows[uiDataGridView1.CurrentRow.Index].Cells["TypeName"].Value.ToString();//得到当前选择的型号类别
            VarHelper.mTestViewModel.TypeName = uiDataGridView1.Rows[uiDataGridView1.CurrentRow.Index].Cells["colUsername"].Value.ToString();//得到当前选择的型号名称
            VarHelper.mTestViewModel.ModelID = dicType[cboModel.Text.ToString()];//得到当前选择的类型ID
            VarHelper.mTestViewModel.Mark = uiDataGridView1.Rows[uiDataGridView1.CurrentRow.Index].Cells["colPassword"].Value.ToString();//得到当前选择的备注

            Close();
            Dispose();
        }

        public DataTable GetData(int TypeId, string ModelName)
        {
            TypeBLL modelBll = new();
            StringBuilder sb = new();
            if (TypeId >= 0)
            {
                sb.AppendFormat(" and b.ID ={0}", TypeId);
            }
            if (ModelName != "")
            {
                sb.AppendFormat(" and Name like '%" + ModelName + "%'");
            }
            DataTable dt = modelBll.GetAllKindByCon(sb.ToString());
            return dt;
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                int typeid = -1;
                string model = cboType.Text;
                if (cboModel.Text == null)
                {
                    typeid = -1;
                }
                else
                    typeid = dicType[cboModel.Text.ToString()];
                VarHelper.mTestViewModel.ModelID = typeid;
                if (cboType.SelectedValue == null)
                {
                    model = "";
                }

                DataTable dt = GetData(typeid, model);
                uiDataGridView1.DataSource = dt;
                uiButton3.Enabled = true;
                //DataTable dt = GetData(dicType[cboType.SelectedValue.ToString()], cboModel.Text);
                //uiDataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_Spec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                GetModel();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error(ex.Message);
            }
        }

        private void cboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //if (dicType.Count < 1) return;
                TypeBLL bModel = new();
                DataTable dt2 = bModel.GetAllKindByCon(" and b.ID =" + dicType[cboModel.Text.ToString()]);
                cboType.ValueMember = "ID";
                cboType.DisplayMember = "Name";
                cboType.DataSource = dt2;
                btnGet.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
