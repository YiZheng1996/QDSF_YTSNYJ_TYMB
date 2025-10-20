using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.Procedure.Test
{
    /// <summary>
    /// 超负荷试验
    /// </summary>
    public class AirTest : BaseTest
    {
        public override bool Execute()
        {
            try
            {
                TestStatus(true);
                TxtTips("超负荷试验开始");
                TxtTips("超负荷试验参数：设定时间：【" + para.ProvingCTime + "】分钟  设定压力：【" + para.Overload + "】kPa");
                int time = (para.ProvingCTime * 60) / 5;
                double cfhYL = para.Overload;
                Common.AOgrp.CAO01 = para.PercentServeIn;
                DateTime T1 = DateTime.Now;
                TxtTips("正在充气中，将气压升至【" + para.Overload + "】kPa");
                while (Common.AIgrp[3] < cfhYL && IsTesting && (DateTime.Now - T1).TotalSeconds < 600)
                {
                    TxtTiming(600 - Convert.ToInt32((DateTime.Now - T1).TotalSeconds));
                    Delay(1);
                }
                if (Common.AIgrp[3] < cfhYL)
                {
                    TxtTips("超负荷试验失败，原因：未能将气压升至【" + para.Overload + "】kPa，请检查气路是否安装错误或气路存在泄漏");
                    return false;
                }
             
                Common.AOgrp.CAO01 = para.PercentServeOut;
                int sj = 0;
                T1 = DateTime.Now;
                double T2 = 0;
                int nTmep = 0;
                TxtTips("超负荷试验正在试验中");
                for (int i = 0; i < 5 && IsTesting; i++)
                {
                    do
                    {
                        sj++;
                        nTmep++;
                        TxtTiming(para.ProvingMTime * 60 - nTmep);
                        Delay(1);
                    }
                    while (sj < time && IsTesting);
                    T2 = sj / 60;
                    sj = 0;
                    SetResult(i, T2);
                }
                TestStatus(false);
                TxtTips("超负荷试验结束");
                return true;
            }
            catch (Exception ex)
            {
                TxtTips("超负荷试验失败，原因：" + ex.Message);
                return false;
            }
        }
        public void SetResult(int i, double T2)
        {
            Common.mResultAll.tga[i] = T2.ToString("f1");                       //运行时间
           
          
            Common.mResultAll.tgi[i] = Common.WSDgrp[0].ToString("f1");         //吸气温度
          
            Common.mResultAll.tgk[i] = Common.AIgrp[3].ToString("f1");    //排气压力
        }
    }
}
