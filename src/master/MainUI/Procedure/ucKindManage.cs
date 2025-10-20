using MainUI.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace MainUI.Procedure
{
    public partial class ucKindManage : ucBaseManagerUI
    {
        ModelBLL BLLmodelType = new ModelBLL();
        string grpTxt = "";

        public ucKindManage()
        {
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
          
            DataTable dt = BLLmodelType.GetAllModelType();
            if (dt == null)
                return;
            dataGridView1.DataSource = dt;

        }

       
       
       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string curModel = txtModelName.Text.Trim();
                if (string.IsNullOrEmpty(curModel))
                    return;

                string mark = txtChexing.Text;
                if (BLLmodelType.IsExist(curModel))
                {
                    MessageBox.Show("类型【" + txtModelName + "】已存在", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (BLLmodelType.Add(curModel, mark))
                {
                   
                    MessageBox.Show("新增成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadModelType();
                   
                }
                else
                {
                    MessageBox.Show("新增失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("新增失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string curModel = txtModelName.Text.Trim();
          
            if (string.IsNullOrEmpty(curModel))
                return;

            if (BLLmodelType.Delete(curModel, id))
            {
                MessageBox.Show("删除成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                LoadModelType();

            }
            else
            {
                MessageBox.Show("删除失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                string curModel = txtModelName.Text.Trim();
                if (string.IsNullOrEmpty(curModel))
                    return;
                string mark = txtChexing.Text;


                if (BLLmodelType.Updata(id, curModel, mark, OldName))
                {
                  
                    MessageBox.Show("修改成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadModelType();
                }
                else
                {
                    MessageBox.Show("修改失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("修改失败", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ShowCurRecord();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            ShowCurRecord();
        }
        int id = 0;
        private void ShowCurRecord()
        {
            if (dataGridView1.DataSource == null)
                return;
            if (dataGridView1.Rows.Count < 1)
                return;
            id = Convert.ToInt32( dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["name"].Value);
            string name = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ModelType"].Value.ToString(); 
            string mark = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["mark"].Value.ToString(); 
        
            txtModelName.Text = name;
            txtChexing.Text = mark;
            OldName=name;
        }
        string OldName = "";
    }
}
