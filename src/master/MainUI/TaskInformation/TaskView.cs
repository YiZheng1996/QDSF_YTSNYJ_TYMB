using AntdUI;
using MainUI.CurrencyHelper;
namespace MainUI.TaskInformation
{
    public partial class TaskView : UIForm
    {
        public TaskView() => InitializeComponent();

        MainTaskBLL taskBLL = new();

        public NewTaskModel NewTask { get; set; }

        private void TaskView_Load(object sender, EventArgs e)
        {
            NewTask = new();
            InitTableTitle();
            AddCobData(selectProjectNumber, taskBLL.GetCobProjectNumber());
            AddCobData(selectCarCode, taskBLL.GetCobCarCode());
            AddCobData(selectTrainNo, taskBLL.GetCobTrainNo());
            //table1.SetRowStyle += Table1_SetRowStyle;

            selectProjectNumber.SelectedIndex = VarHelper.ProjectNumberKey;
            selectCarCode.SelectedIndex = VarHelper.CarCodeKey;
            selectTrainNo.SelectedIndex = VarHelper.TrainNoKey;
        }

        private void InitTableTitle()
        {
            table1.Columns = [
                new Column("projectNumber","车型编码"){ Fixed = true ,Align = ColumnAlign.Center},
                new Column("trainCode","配属列号"){ Fixed = true ,Align = ColumnAlign.Center},
                new Column("carCode","配属辆号"){ Fixed = true ,Align = ColumnAlign.Center},
                new Column("trainNo","车列号"){ Fixed = true ,Align = ColumnAlign.Center},
                new Column("detailId","明细ID"){ Visible = true ,Align = ColumnAlign.Center},
                new Column("holdTaskId","施工任务ID"){ Visible = true ,Align = ColumnAlign.Center},
                new Column("holdItemId","耐压子任务ID"){ Visible = true ,Align = ColumnAlign.Center},
                new Column("stepName","步骤名称"),
                new Column("stepBom","操作区域"),
                new Column("stepContent","操作内容"),
                new Column("stepNo","操作排序"){ Visible = false},
                new Column("isOperateCell","是否操作位置"){ Visible = false},
                new Column("resultContent","结果默认内容"),
                new Column("recordType","结果记录类型"){ Visible = false},
                new Column("resultStandard","结果记录范围标准"),
                new Column("resultUnit","结果单位"),
                new Column("Btns","操作",ColumnAlign.Center){ Fixed = true , Width = "100"}
            ];
            NewTaskBLL newTask = new();
            table1.DataSource = newTask.GetNewTasks(new NewTaskModel { isComplete = 0 }).OrderByDescending(a => a.ID).Take(100);
        }

        private void Table1_CellButtonClick(object sender, TableButtonEventArgs e)
        {
            if (e.Record is NewTaskModel data)
            {
                if (AntdUI.Modal.open(new Modal.Config(this, $"请确认任务是否选择正确？", new Modal.TextLine[] {
                    new($"步骤名称：{data.stepName}\n操作步骤：{data.stepBom}\n操作内容：{data.stepContent}",AntdUI.Style.Db.Error),
                }, TType.Info)
                {
                    Width = 600,
                    OkText = "确认",
                    Keyboard = false,
                    CancelText = "取消",
                    MaskClosable = false,
                    OkType = TTypeMini.Info,
                    Font = new Font("宋体", 16),
                }) == DialogResult.OK)
                {
                    table1.Spin(new Spin.Config()
                    {
                        Text = "加载任务中...",
                        Font = new Font("宋体", 15),
                        Back = Color.FromArgb(189, 179, 172),
                    }, () =>
                    {
                        Thread.Sleep(1000);
                    }, () =>
                    {
                        Invoke(() =>
                        {
                            NewTask = data;
                            Close();
                        });
                    });
                }
            }
        }

        private int AddCobData(Select select, List<string> strings)
        {
            Invoke(() =>
            {
                select.Items.Clear();
                for (int i = 0; i < strings.Count; i++)
                    select.Items.AddRange([strings[i]]);
                return strings.Count;
            });
            return strings.Count;
        }

        private void selectProjectNumber_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            try
            {
                Invoke(() =>
                {
                    selectCarCode.Text = "--请选择--";
                    selectTrainNo.Text = "--请选择--";
                    var value = taskBLL.GetCobCarCode(selectProjectNumber.SelectedValue.ToString());
                    AddCobData(selectCarCode, value);
                });
            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(this, "选择车型编码错误：" + ex.Message);
            }
        }

        private void selectCarCode_SelectedIndexChanged(object sender, IntEventArgs e)
        {
            Invoke(() =>
            {
                try
                {
                    selectTrainNo.Text = "--请选择--";
                    AddCobData(selectTrainNo, taskBLL.GetCobTrainNo(selectProjectNumber.SelectedValue.ToString(), selectCarCode.SelectedValue.ToString()));
                }
                catch (Exception ex)
                {
                    MessageHelper.MessageOK(this, "[任务查看界面]选择配属辆号错误，请检查是否车型编码未选择！：" + ex.Message);
                }
            });

        }

        private void btnSeek_Click(object sender, EventArgs e)
        {
            try
            {
                NewTaskBLL bLL = new();
                var data = bLL.GetNewTasks(new NewTaskModel()
                {
                    isComplete = 0,
                    projectNumber = selectProjectNumber.SelectedValue?.ToString() ?? default,
                    carCode = selectCarCode.SelectedValue?.ToString() ?? default,
                    trainNo = selectTrainNo.SelectedValue?.ToString() ?? default,
                });
                table1.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(this, "查询错误：" + ex.Message);
            }

        }


        private void TaskView_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                VarHelper.ProjectNumberKey = selectProjectNumber.SelectedIndex;
                VarHelper.CarCodeKey = selectCarCode.SelectedIndex;
                VarHelper.TrainNoKey = selectTrainNo.SelectedIndex;
            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(this, "窗体关闭错误：" + ex.Message);
            }

        }
    }

}
