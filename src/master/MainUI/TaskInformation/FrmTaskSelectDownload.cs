using AntdUI;
using MainUI.CurrencyHelper;

namespace MainUI.TaskInformation
{
    public partial class FrmTaskSelectDownload : UIForm
    {
        // 存储展示用的任务列表(带Check属性)
        private List<TaskDisplayModel> displayTasks = new List<TaskDisplayModel>();

        // 存储用户选中的任务
        public List<MainTaskModel> SelectedTasks { get; private set; } = new List<MainTaskModel>();

        // 存储从外部传入的任务数据
        private MainTaskResultModel taskData;

        // 构造函数 - 接收任务数据
        public FrmTaskSelectDownload(MainTaskResultModel data)
        {
            InitializeComponent();
            this.taskData = data;
        }

        private void TaskView_Load(object sender, EventArgs e)
        {
            InitTableTitle();
            LoadTaskList();
        }

        private void InitTableTitle()
        {
            table1.Columns = [
                new ColumnCheck("Check"){ Fixed = true, Checked = false },
                new Column("holdTaskId", "施工任务ID"){ Visible = true, Align = ColumnAlign.Center, Width = "10%" },
                new Column("holdItemId", "耐压子任务ID"){ Visible = true, Align = ColumnAlign.Center, Width = "10%" },
                new Column("projectNumber", "车型编码"){ Fixed = true, Align = ColumnAlign.Center, Width = "8%" },
                new Column("trainCode", "配属列号"){ Fixed = true, Align = ColumnAlign.Center, Width = "8%" },
                new Column("carCode", "配属辆号"){ Fixed = true, Align = ColumnAlign.Center, Width = "8%" },
                new Column("debugType", "修程类型"){ Align = ColumnAlign.Center, Width = "8%" },
                new Column("itemName", "耐压项目名称"){ Align = ColumnAlign.Center, Width = "15%" },
                new Column("operateProcess", "自检进度"){ Align = ColumnAlign.Center, Width = "8%" },
                new Column("mutualProcess", "互检进度"){ Align = ColumnAlign.Center, Width = "8%" },
                new Column("qualityProcess", "质检进度"){ Align = ColumnAlign.Center, Width = "8%" },
            ];
        }

        // 加载任务列表(从传入的数据中加载,不再调用API)
        private void LoadTaskList()
        {
            try
            {
                if (taskData == null || taskData.list == null || taskData.list.Count == 0)
                {
                    MessageHelper.MessageOK(this, "没有可下载的任务!");
                    return;
                }

                // 展开任务列表(因为一个主任务可能有多个子任务)
                displayTasks.Clear();
                foreach (var task in taskData.list)
                {
                    if (task.holdItems != null && task.holdItems.Count > 0)
                    {
                        // 为每个holdItem创建一个显示项
                        foreach (var item in task.holdItems)
                        {
                            var displayTask = new TaskDisplayModel
                            {
                                Check = false, // 默认不选中
                                holdTaskId = task.holdTaskId,
                                projectTypeName = task.projectTypeName,
                                projectNumber = task.projectNumber,
                                trainNo = task.trainNo,
                                trainCode = task.trainCode,
                                carCode = task.carCode,
                                depId = task.depId,
                                debugType = task.debugType,
                                holdItemId = item.holdItemId,
                                itemName = item.itemName,
                                operateProcess = item.operateProcess,
                                mutualProcess = item.mutualProcess,
                                qualityProcess = item.qualityProcess,
                                // 保存原始holdItems用于后续下载
                                OriginalHoldItems = [item]
                            };
                            displayTasks.Add(displayTask);
                        }
                    }
                }

                // 绑定到表格
                table1.DataSource = displayTasks;

                NlogHelper.Default.Info($"加载任务列表成功,共 {displayTasks.Count} 个任务可选择");
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("加载任务列表失败:", ex);
                MessageHelper.MessageOK(this, "加载任务列表失败:" + ex.Message);
            }
        }

        private void TaskView_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // 窗体关闭时的清理工作
            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(this, "窗体关闭错误:" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SelectedTasks.Clear();
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // 获取选中的任务
                SelectedTasks.Clear();

                if (displayTasks == null || displayTasks.Count == 0)
                {
                    MessageHelper.MessageOK(this, "任务列表为空!");
                    return;
                }

                // 收集选中的任务
                var selectedItems = displayTasks.Where(t => t.Check).ToList();

                if (selectedItems.Count == 0)
                {
                    MessageHelper.MessageOK(this, "请至少选择一个任务进行下载!");
                    return;
                }

                // 确认下载
                if (MessageHelper.MessageYes(this, $"确定下载选中的 {selectedItems.Count} 个任务吗?") != DialogResult.OK)
                {
                    return;
                }

                // 转换为MainTaskModel进行下载
                var tasksToDownload = new List<MainTaskModel>();
                foreach (var item in selectedItems)
                {
                    var mainTask = new MainTaskModel
                    {
                        holdTaskId = item.holdTaskId,
                        projectTypeName = item.projectTypeName,
                        projectNumber = item.projectNumber,
                        trainNo = item.trainNo,
                        trainCode = item.trainCode,
                        carCode = item.carCode,
                        depId = item.depId,
                        debugType = item.debugType,
                        holdItemId = item.holdItemId,
                        itemName = item.itemName,
                        operateProcess = item.operateProcess,
                        mutualProcess = item.mutualProcess,
                        qualityProcess = item.qualityProcess,
                        holdItems = item.OriginalHoldItems
                    };
                    tasksToDownload.Add(mainTask);
                }

                // 显示下载进度提示
                NlogHelper.Default.Info($"开始下载选中的 {selectedItems.Count} 个任务");

                // 执行下载(保存到数据库)
                TaskDownload taskDownload = new(this);
                bool result = await taskDownload.GetMainTaskSelective(tasksToDownload);

                if (result)
                {
                    SelectedTasks = tasksToDownload;
                    //MessageHelper.MessageOK(this, $"任务下载成功!共下载 {selectedItems.Count} 个任务");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageHelper.MessageOK(this, "任务下载失败!");
                }
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("确认下载错误:", ex);
                MessageHelper.MessageOK(this, "确认下载错误:" + ex.Message);
            }
        }
    }

    // 用于表格显示的模型(包含Check属性)
    internal class TaskDisplayModel
    {
        public bool Check { get; set; }
        public string holdTaskId { get; set; }
        public string projectTypeName { get; set; }
        public string projectNumber { get; set; }
        public string trainNo { get; set; }
        public string trainCode { get; set; }
        public string carCode { get; set; }
        public string depId { get; set; }
        public string debugType { get; set; }
        public string holdItemId { get; set; }
        public string itemName { get; set; }
        public string operateProcess { get; set; }
        public string mutualProcess { get; set; }
        public string qualityProcess { get; set; }

        // 保存原始数据用于下载
        public List<holdItem> OriginalHoldItems { get; set; }
    }
}