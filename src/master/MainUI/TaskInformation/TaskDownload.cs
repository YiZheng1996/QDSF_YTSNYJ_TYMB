using MainUI.CurrencyHelper;
using MainUI.Model.StateModel;
using Newtonsoft.Json;
using Sunny.UI;
using System.Text;

namespace MainUI.TaskInformation
{
    internal class TaskDownload(Form form)
    {
        // 获取主任务
        public async Task<bool> GetMainTask()
        {
            try
            {
                //string json = File.ReadAllText(Application.StartupPath + "Json\\主任务JSON.txt", Encoding.UTF8);
                //var apiResponse = JsonConvert.DeserializeObject<MainTaskResultModel>(json);
                //var Taskdata = apiResponse.list;

                if (string.IsNullOrEmpty(VarHelper.deviceConfig.Authentication)) throw new Exception("设备未认证！请先认证设备");
                var restClientHelper = new RestClientHelper(VarHelper.ProductionConfig.GetMainTask);
                var apiResponse = await restClientHelper.GetAsync<MainTaskResultModel>(new
                {
                    procedureType = 7,
                    deviceNumber = VarHelper.deviceConfig.Authentication,
                    personCode = NewUsers.NewUserInfo.JobNumber,
                });
                if (apiResponse.state != "1") throw new Exception(apiResponse.msg);
                var Taskdata = apiResponse.list;
                Debug.WriteLine($"主任务获取结果: {apiResponse.msg}, state: {apiResponse.state}，total：{apiResponse.total}");
                MainTaskBLL taskBLL = new();
                MainTaskModel taskModel = new();
                for (int i = 0; i < Taskdata.Count; i++)
                {
                    taskModel = Taskdata[i];
                    for (int j = 0; j < taskModel.holdItems.Count; j++)
                    {
                        taskModel.holdItemId = taskModel.holdItems[j].holdItemId;
                        taskModel.itemName = taskModel.holdItems[j].itemName;
                        taskModel.operateProcess = taskModel.holdItems[j].operateProcess;
                        taskModel.mutualProcess = taskModel.holdItems[j].mutualProcess;
                        taskModel.qualityProcess = taskModel.holdItems[j].qualityProcess;
                    }

                    NlogHelper.Default.Fatal($"主任务下载时间：{DateTime.Now}，" +
                        $"主任务ID:{taskModel.holdTaskId}，" +
                        $"子任务ID:{taskModel.holdItemId}");
                    taskBLL.ModifyOrAddTaskTable(taskModel);
                    await GetHoldTask(Taskdata[i].holdTaskId, Taskdata[i].holdItemId);
                    Debug.WriteLine($"主任务ID:{taskModel.holdTaskId}，子任务ID:{taskModel.holdItemId}");
                }
                return true;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("主任务下载错误：", ex);
                MessageHelper.MessageOK(form, "主任务下载错误:" + ex.Message);
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

                if (string.IsNullOrEmpty(VarHelper.deviceConfig.Authentication)) throw new Exception("设备未认证！请先认证设备");
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
                Debug.WriteLine($"子任务获取结果: {apiResponse.msg}, state: {apiResponse.state}，total：{apiResponse.total}");
                HoldTaskBLL taskBLL = new();
                HoldTaskModel taskModel = new();
                for (int i = 0; i < Taskdata.Count; i++)
                {
                    taskModel = Taskdata[i];
                    taskModel.CreateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    NlogHelper.Default.Fatal($"子任务下载时间：{taskModel.CreateTime}，" +
                        $"主任务ID:{taskModel.holdTaskId}，" +
                        $"子任务ID:{taskModel.holdItemId}");
                    Debug.WriteLine($"主任务ID:{taskModel.holdTaskId}，子任务ID:{taskModel.holdItemId}");
                    taskBLL.ModifyOrAddHoldTable(taskModel);
                }
                return true;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("子任务下载错误：", ex);
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
                NlogHelper.Default.Error("任务回传失败：", ex);
                MessageHelper.MessageOK(form, "任务回传失败:" + ex.Message);
                return null;
            }
        }
    }
}
