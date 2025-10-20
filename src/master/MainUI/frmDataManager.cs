using MainUI.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MainUI
{
    public partial class frmDataManager : UIForm
    {
        TestRecordBLL mTestRecord = new TestRecordBLL();
        public frmDataManager()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        private void frmDataManager_Load(object sender, EventArgs e)
        {
            Init();
            LoadData();
        }
        Dictionary<string, int> dicType = new Dictionary<string, int>();
        /// <summary>
        /// 初始化
        /// </summary>
        private new void Init()
        {
            try
            {
                uiDataGridView1.AutoGenerateColumns = false;
                ModelBLL bModelType = new();
                DataTable dt = bModelType.GetAllModelType();
                dtpStartBig.Value = DateTime.Now.AddDays(-3);
                dtpStartEnd.Value = DateTime.Now;
                foreach (DataRow item in dt.Rows)
                    dicType.Add(item[1].ToString(), Convert.ToInt32(item[0]));

                cboType.DisplayMember = "ModelType";
                cboType.ValueMember = "ID";
                cboType.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 选择类别时事件
        /// </summary>
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeBLL typebll = new();
            DataTable dt = typebll.GetAllKindByCon(" and b.ID =" + dicType[cboType.Text.ToString()]);
            cboModel.ValueMember = "ID";
            cboModel.DisplayMember = "Name";
            cboModel.DataSource = dt;
        }
        /// <summary>
        /// 查询方法
        /// </summary>
        private void LoadData()
        {
            string Type = "";
            string Model = "";
            string TestId = "";

            if (cboType.SelectedValue != null)
            {
                Type = dicType[cboType.Text].ToString();
            }
            if (cboModel.Text.ToString() != "")
            {
                Model = cboModel.SelectedText.ToString();
            }
            if (txtNumber.Text != "")
            {
                TestId = "%" + txtNumber.Text + "%";
            }
            DateTime dateFrom = this.dtpStartBig.Value;
            DateTime dateTo = this.dtpStartEnd.Value;


            DataTable dt = mTestRecord.FindList(Type, Model, TestId, "", dateFrom, dateTo.AddDays(1));
            uiDataGridView1.DataSource = dt;
        }
        /// <summary>
        /// 获取ID
        /// </summary>
        private int GetID(DataGridViewRow row)
        {
            int id = Convert.ToInt32(row.Cells["colID"].Value);
            return id;
        }
        /// <summary>
        /// 获取行对象
        /// </summary>
        /// <returns></returns>
        private int GetSelectedID()
        {
            if (this.uiDataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选择一条记录。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            DataGridViewRow row = this.uiDataGridView1.SelectedRows[0];
            return GetID(row);
        }
        /// <summary>
        /// 查看报表方法
        /// </summary>
        private void View()
        {
            try
            {
                int id = this.GetSelectedID();
                if (id > 0)
                {
                    DataGridViewRow row = this.uiDataGridView1.SelectedRows[0];
                    object value = row.Cells["colReportPath"].Value;
                    string filename = value.ToString();
                    string filenameNew = value + ".xlsx".ToString();
                    if (!File.Exists(filenameNew))
                    {
                        MessageBox.Show("报表文件不存在或已经删除。", "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    frmDispReport report = new(filename);
                    report.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region dataGridView事件  
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            View();
        }
        #endregion


        /// <summary>
        /// 搜索
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        /// <summary>
        /// 查看报表
        /// </summary>
        private void btnView_Click(object sender, EventArgs e)
        {
            View();
        }
        /// <summary>
        /// 删除
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = this.GetSelectedID();
            if (id == 0)
            {
                MessageBox.Show("没有可以删除的数据！");
                return;
            }
            if (MessageBox.Show("删除后无法恢复，确定要删除该条记录吗？", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                mTestRecord.DelData(id);
                this.LoadData();
            }
        }
        /// <summary>
        /// 退出
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
