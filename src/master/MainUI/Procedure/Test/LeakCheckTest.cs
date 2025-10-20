using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.Procedure.Test
{
    /// <summary>
    /// 满负荷试验
    /// </summary>
    public class LeakCheckTest : BaseTest
    {
        public override bool Execute()
        {
            try
            {
                TestStatus(true);
                TxtTips("满负荷试验开始");
                TxtTips("满负荷试验参数：设定时间：【" + para.ProvingMTime + "】分钟  设定压力：【" + para.Pressure + "】kPa");
                int time = (para.ProvingMTime * 60) / 5;
                double mfhYL = para.Pressure;
                Common.AOgrp.CAO01 = para.PercentServeIn;
                DateTime T1 = DateTime.Now;
                TxtTips("正在充气中，将气压升至【" + para.Pressure + "】kPa");
                while (Common.AIgrp[3] < mfhYL && IsTesting && (DateTime.Now - T1).TotalSeconds < 600)
                {
                    TxtTiming(600 - Convert.ToInt32((DateTime.Now - T1).TotalSeconds));
                    Delay(1);
                }
                if (Common.AIgrp[3] < mfhYL)
                {
                    TxtTips("满负荷试验失败，原因：未能将气压升至【" + para.Pressure + "】kPa，请检查气路是否安装错误或气路存在泄漏");
                    return false;
                }
                TxtTips("请检查空压机油路接头、机头端盖、螺堵等部位应无润滑油渗出，并用检漏液检查各气路接口应无气泡");
                Common.AOgrp.CAO01 = para.PercentServeOut;
                T1 = DateTime.Now;
                TxtTips("满负荷试验正在试验中");
                int sj = 0;
                int nTmep = 0;
                for (int i = 0; i < 5 && IsTesting; i++)
                {
                    do
                    {
                        sj++;
                        nTmep++;
                        TxtTiming(para.ProvingMTime * 60 - nTmep);
                        Delay(1);
                        if (sj == 300)
                        {
                            TxtTips("请检查并记录过滤器排污阀动作状态是否正常，当排污电磁阀动作时，会有油水混合物随压缩空气从电磁阀排污口排出");
                        }
                    }
                    while (sj < time && IsTesting);
                    sj = 0;
                    SetResult(i);
                }
                TestStatus(false);
                TxtTips("满负荷试验结束");
                return true;
            }
            catch (Exception ex)
            {
                TxtTips("满负荷试验失败，原因：" + ex.Message);
                return false;
            }
        }
        public void SetResult(int i)
        {
            Common.mResultAll.ta[i] = Common.AIgrp[0].ToString("f1");       //1.吸气压力
            Common.mResultAll.tb[i] = Common.WSDgrp[0].ToString("f1");          //2.吸气温度
            Common.mResultAll.tc[i] = Common.AIgrp[3].ToString("f1");     //3.排气压力
           
            Common.mResultAll.te[i] = Common.liuliangRst.ToString("f1");        //5.排气量(流量)
         
          
          
        }
    }
}
