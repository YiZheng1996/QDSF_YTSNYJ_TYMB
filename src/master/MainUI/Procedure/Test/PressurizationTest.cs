using MainUI.CurrencyHelper;
using System.Speech.Recognition;

namespace MainUI.Procedure.Test
{
    public class PressurizationTest(CancellationToken cancellationToken) : BaseTest
    {
        public override Task<bool> Execute()
        {
            //TestStatus(true);
            VarHelper.testProcessValues = "";
            var TaskState = cancellationToken.IsCancellationRequested;
            //NlogHelper.Default.Debug("-------耐压试验过程结果数组开始-------");
            Delay(90, 1000, delegate
            {
                string time = DateTime.Now.ToString();
                string voltage = OPCHelper.AIgrp[0].ToString("f1");
                string current = OPCHelper.AIgrp[1].ToString("f1");
                VarHelper.testProcessValues += $"{voltage},{current},{time};";
                if (OPCHelper.DIgrp[25]) return false;
                return OPCHelper.DIgrp[26] == false;
            }, cancellationToken);
            //NlogHelper.Default.Debug("-------耐压试验过程结果数组结束-------");
            //TestStatus(false);
            return Task.FromResult(true);
        }
    }
}
