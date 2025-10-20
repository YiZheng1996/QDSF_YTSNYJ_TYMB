using MainUI.CurrencyHelper;

namespace MainUI.Procedure.Test
{
    public class OfflineTest(CancellationToken cancellationToken) : BaseTest
    {
        public override Task<bool> Execute()
        {
            TestStatus(true);
            TxtTips("试验开始");
            NlogHelper.Default.Info($"离线试验开始：{DateTime.Now}");
            Debug.WriteLine("-------离线试验开始-------");
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

            //TODO：暂时修改处传感器釆值 VD204,原是耐压机釆值 PUBgrp[65]VD750
            ucGrid.Write("sydy" + CheckCount, maxValue.ToString());
            ucGrid.Write("sydl" + CheckCount, Math.Round(OPCHelper.PUBgrp[65].ToDouble(), 1).ToString());
            if (OPCHelper.PUBgrp[65].ToDouble() > OPCHelper.PUBgrp[1].ToDouble())
            {
                ucGrid.Write("result" + CheckCount, "不合格");
            }
            else
            {
                ucGrid.Write("result" + CheckCount, "合格");
            }
            Debug.WriteLine("-------离线试验结束-------");
            TxtTips("试验结束");
            TestStatus(false);
            return Task.FromResult(true);
        }
    }
}
