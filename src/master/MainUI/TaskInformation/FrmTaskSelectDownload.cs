using AntdUI;
using MainUI.CurrencyHelper;
namespace MainUI.TaskInformation
{
    public partial class FrmTaskSelectDownload : UIForm
    {
        public FrmTaskSelectDownload() => InitializeComponent();


        private void TaskView_Load(object sender, EventArgs e)
        {
            InitTableTitle();
        }

        private void InitTableTitle()
        {
            table1.Columns = [
                new ColumnCheck("Check"){ Fixed = true ,Checked=false},
                new Column("holdTaskId","施工任务ID"){ Visible = true ,Align = ColumnAlign.Center},
                new Column("holdItemId","耐压子任务ID"){ Visible = true ,Align = ColumnAlign.Center},
                new Column("projectNumber","车型编码"){ Fixed = true ,Align = ColumnAlign.Center},
                new Column("trainCode","配属列号"){ Fixed = true ,Align = ColumnAlign.Center},
                new Column("carCode","配属辆号"){ Fixed = true ,Align = ColumnAlign.Center},
                new Column("debugType","俢程类型"),
                new Column("depId","班组id"),
                new Column("itemName","耐压项目名称"),
                new Column("operateProcess","自检进度"),
                new Column("mutualProcess","互检进度"),
                new Column("qualityProcess","质检进度"),
            ];
            //NewTaskBLL newTask = new();
            //table1.DataSource = newTask.GetNewTasks(new NewTaskModel { isComplete = 0 }).OrderByDescending(a => a.ID).Take(100);
        }


        private void TaskView_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(this, "窗体关闭错误：" + ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //TODO: 选择任务后的处理逻辑

  
            DialogResult = DialogResult.OK;
            Close();
        }
    }

}
