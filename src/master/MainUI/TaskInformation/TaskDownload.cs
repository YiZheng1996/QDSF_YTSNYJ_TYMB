using MainUI.CurrencyHelper;
using MainUI.Model.StateModel;
using Newtonsoft.Json;
using Sunny.UI;
using System.Text;

namespace MainUI.TaskInformation
{
    internal class TaskDownload(Form form)
    {
        // 获取主任务列表(不下载到数据库,仅用于展示)
        public async Task<MainTaskResultModel> GetMainTaskList()
        {
            try
            {
                //string json = File.ReadAllText(Application.StartupPath + "Json\\主任务JSON.txt", Encoding.UTF8);
                //var apiResponse = JsonConvert.DeserializeObject<MainTaskResultModel>(json);
                //var Taskdata = apiResponse.list;

                if (string.IsNullOrEmpty(VarHelper.deviceConfig.Authentication))
                    throw new Exception("设备未认证!请先认证设备");

                var restClientHelper = new RestClientHelper(VarHelper.ProductionConfig.GetMainTask);
                var apiResponse = await restClientHelper.GetAsync<MainTaskResultModel>(new
                {
                    procedureType = 7,
                    deviceNumber = VarHelper.deviceConfig.Authentication,
                    personCode = NewUsers.NewUserInfo.JobNumber,
                });

                if (apiResponse.state != "1") throw new Exception(apiResponse.msg);

                Debug.WriteLine($"主任务列表获取结果: {apiResponse.msg}, state: {apiResponse.state},total:{apiResponse.total}");

                return apiResponse;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("主任务列表获取错误:", ex);
                MessageHelper.MessageOK(form, "主任务列表获取错误:" + ex.Message);
                return null;
            }
        }

        // 新增:选择性下载主任务(只下载选中的任务)
        public async Task<bool> GetMainTaskSelective(List<MainTaskModel> selectedTasks)
        {
            try
            {
                if (selectedTasks == null || selectedTasks.Count == 0)
                {
                    MessageHelper.MessageOK(form, "请选择要下载的任务!");
                    return false;
                }

                MainTaskBLL taskBLL = new();

                for (int i = 0; i < selectedTasks.Count; i++)
                {
                    var taskModel = selectedTasks[i];

                    // 处理holdItems
                    for (int j = 0; j < taskModel.holdItems.Count; j++)
                    {
                        taskModel.holdItemId = taskModel.holdItems[j].holdItemId;
                        taskModel.itemName = taskModel.holdItems[j].itemName;
                        taskModel.operateProcess = taskModel.holdItems[j].operateProcess;
                        taskModel.mutualProcess = taskModel.holdItems[j].mutualProcess;
                        taskModel.qualityProcess = taskModel.holdItems[j].qualityProcess;
                    }

                    NlogHelper.Default.Fatal($"选择性主任务下载时间:{DateTime.Now}," +
                        $"主任务ID:{taskModel.holdTaskId}," +
                        $"子任务ID:{taskModel.holdItemId}");

                    // 保存到数据库
                    taskBLL.ModifyOrAddTaskTable(taskModel);

                    // 下载对应的子任务
                    await GetHoldTask(taskModel.holdTaskId, taskModel.holdItemId);

                    Debug.WriteLine($"选择下载 - 主任务ID:{taskModel.holdTaskId},子任务ID:{taskModel.holdItemId}");
                }

                return true;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("选择性主任务下载错误:", ex);
                MessageHelper.MessageOK(form, "选择性主任务下载错误:" + ex.Message);
                return false;
            }
        }

        // 获取子任务
        public async Task<bool> GetHoldTask(string TaskId, string ItemId)
        {
            try
            {
                //string json = File.ReadAllText(Application.StartupPath + "Json\\子任务.txt", Encoding.UTF8);
                //var apiResponse = JsonConvert.DeserializeObject<HoldTaskResultModel>(json);
                //var Taskdata = apiResponse.list;

                if (string.IsNullOrEmpty(VarHelper.deviceConfig.Authentication))
                    throw new Exception("设备未认证!请先认证设备");

                var restClientHelper = new RestClientHelper(VarHelper.ProductionConfig.GetHoldTask);
                var apiResponse = await restClientHelper.GetAsync<HoldTaskResultModel>(new
                {
                    procedureType = 7,
                    deviceNumber = VarHelper.deviceConfig.Authentication,
                    personCode = NewUsers.NewUserInfo.JobNumber,
                    holdTaskId = TaskId,
                    holdItemId = ItemId,
                });

                if (apiResponse.state != "1") throw new Exception(apiResponse.msg);
                var Taskdata = apiResponse.list;

                Debug.WriteLine($"子任务获取结果: {apiResponse.msg}, state: {apiResponse.state},total:{apiResponse.total}");

                HoldTaskBLL taskBLL = new();
                HoldTaskModel taskModel = new();

                for (int i = 0; i < Taskdata.Count; i++)
                {
                    taskModel = Taskdata[i];
                    taskModel.CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    NlogHelper.Default.Fatal($"子任务下载时间:{taskModel.CreateTime}," +
                        $"主任务ID:{taskModel.holdTaskId}," +
                        $"子任务ID:{taskModel.holdItemId}");

                    Debug.WriteLine($"主任务ID:{taskModel.holdTaskId},子任务ID:{taskModel.holdItemId}");
                    taskBLL.ModifyOrAddHoldTable(taskModel);
                }
                return true;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("子任务下载错误:", ex);
                MessageHelper.MessageOK(form, "子任务下载错误:" + ex.Message);
                return false;
            }
        }

        // 任务回传
        public async Task<TaskUploadStateModel> TaskBackhaul(string json)
        {
            try
            {
                var restClientHelper = new RestClientHelper(VarHelper.ProductionConfig.ResultFeedback);
                var apiResponse = await restClientHelper.PostAsync<TaskUploadStateModel>(json);
                return apiResponse;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("任务回传失败:", ex);
                MessageHelper.MessageOK(form, "任务回传失败:" + ex.Message);
                return null;
            }
        }
    }
}