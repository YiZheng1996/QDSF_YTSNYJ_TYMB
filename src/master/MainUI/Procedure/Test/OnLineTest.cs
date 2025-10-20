using MainUI.CurrencyHelper;
using Newtonsoft.Json;
namespace MainUI.Procedure.Test
{
    public class OnLineTest(CancellationToken cancellationToken) : BaseTest
    {
        public override Task<bool> Execute()
        {
            TestStatus(true);
            TxtTips("试验开始");
            var TaskState = cancellationToken.IsCancellationRequested;
            Task.Delay(1000).Wait();

            // 存储每秒采集的值
            var collectedValues = new List<double>();
            var lastRecordTime = DateTime.Now;
            Delay(90, 100, cancellationToken,
           () =>
           {
               // 检查是否到达下一秒
               var currentTime = DateTime.Now;
               if ((currentTime - lastRecordTime).TotalSeconds >= 1.0)
               {
                   // 获取当前值并存储
                   double currentValue = Math.Round(OPCHelper.AIgrp[1].ToDouble(), 1);
                   collectedValues.Add(currentValue);
                   lastRecordTime = currentTime;

                   Debug.WriteLine($"正在采集第{collectedValues.Count}秒数据: {currentValue:F1}");
               }

               return OPCHelper.DIgrp[26].ToBool();
           });

            // 获取60秒内的最大值
            double maxValue = collectedValues.Count > 0 ? collectedValues.Max() :
                Math.Round(OPCHelper.AIgrp[1].ToDouble(), 1);

            HoldTaskBLL bLL = new();
            var newtaskmodel = new NewTaskModel
            {
                ID = NewTask.ID,
                testTemperature = OPCHelper.Wsdgrp[0].ToString("f1"),
                testHumidity = OPCHelper.Wsdgrp[1].ToString("f1"),
                applyVoltage = OPCHelper.PUBgrp[0].ToString(),
                testValue = maxValue.ToString(), //TODO：暂时修改处传感器釆值 VD204,原是耐压机釆值 PUBgrp[65]VD750
                testProcessValues = VarHelper.testProcessValues,
                remark = NewTask.remark,
                operatePersonName = NewUsers.NewUserInfo.Username,
                operatePerson = NewUsers.NewUserInfo.JobNumber,
                operateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                operateResult = OPCHelper.PUBgrp[65].ToDouble() <= VarHelper.GetCurrent(NewTask.resultStandard) ? "1" : "0",
                auxiliariesName1 = AuxiModel.auxiliariesName1,
                auxiliariesCode1 = AuxiModel.auxiliariesCode1,
                auxiliariesName2 = AuxiModel.auxiliariesName2,
                auxiliariesCode2 = AuxiModel.auxiliariesCode2,
                auxiliariesName3 = AuxiModel.auxiliariesName3,
                auxiliariesCode3 = AuxiModel.auxiliariesCode3,
                auxiliariesName4 = AuxiModel.auxiliariesName4,
                auxiliariesCode4 = AuxiModel.auxiliariesCode4,
                mutualPersonName = AuxiModel.mutualPersonName,
                mutualPerson = AuxiModel.mutualPerson,
                qualityPersonName = AuxiModel.qualityPersonName,
                qualityPerson = AuxiModel.qualityPerson,
                isComplete = 1,
            };
            //TODO:需要修改 1.Nlog.config(Fatal,Info)文件名称， 2.加当前日志  3.离线试验逻辑加触发日志
            var result = bLL.TaskRedo(newtaskmodel);
            //var jsonStr = JsonConvert.SerializeObject(newtaskmodel);
            NlogHelper.Default.Info($"是否在线标志位置：{VarHelper.TaskModel}，修改结果{result}，任务完成时间：{DateTime.Now}，表ID:{newtaskmodel.ID}，" +
                $"主任务ID：{NewTask.holdTaskId}，" + $"子任务ID：{NewTask.holdItemId}，" +
                $"车型编码:{NewTask.projectNumber}，配属辆号:{NewTask.carCode}，配属列号:{NewTask.trainCode}，" +
                $"环境温度:{newtaskmodel.testTemperature}，环境湿度:{newtaskmodel.testHumidity}，结果值:{newtaskmodel.testValue}" +
                $"testProcessValues:{newtaskmodel.testProcessValues}");
            NewTaskBLL taskBLL = new();
            var DataCount = taskBLL.GetNewTasks(new NewTaskModel
            {
                holdTaskId = NewTask.holdTaskId,
                holdItemId = NewTask.holdItemId,
                isComplete = 0
            }).Count;
            if (DataCount < 1) VarHelper.isRedoing = false;
            TxtTips("试验完成");
            TestStatus(false);
            return Task.FromResult(true);
        }
    }
}
