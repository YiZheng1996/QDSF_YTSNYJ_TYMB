using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.Procedure.Test
{
    /// <summary>
    /// 压力开关启停试验
    /// </summary>
    public class YLKGNoiseTest : BaseTest
    {
        public override bool Execute()
        {
            try
            {
                TestStatus(true);
                TxtTips("启停试验开始");
                TxtTips("启停试验参数：设定时间：【" + para.QTTime + "】分钟");
                int Time = para.QTTime * 60; //试验时间
                int addup = Time / 6;
                int ss = 0;
                int dy = 0, gy = 0; //低压时间、高压时间
                int qTt = 0, tTq = 0;//启动到停止时间、停止到启动时间
                bool isB1 = true, isB2 = true; bool isB3 = true; ;
                int qtcs = 0;
                Common.AOgrp.CAO01 = para.PercentServeIn;
                DateTime T1 = DateTime.Now;
                TxtTips("正在充气中，将气压升至【" + (para.QtDi - 50) + "】kPa");
                while (Common.AIgrp[3] <= para.QtDi - 50 && IsTesting && (DateTime.Now - T1).TotalSeconds < 600)
                {
                    TxtTiming(600 - Convert.ToInt32((DateTime.Now - T1).TotalSeconds));
                    Delay(1);
                }
                if (Common.AIgrp[3] < para.QtDi - 10)
                {
                    TxtTips("压力开关启停试验失败，原因：未能将气压升至【" + (para.QtDi - 50) + "】kPa，请检查气路是否安装错误或气路存在泄漏");
                    return false;
                }
                Stopwatch sw = new Stopwatch();
                sw.Start();
                while (ss <= 6 && IsTesting)
                {
                    TimeSpan TervalTime = sw.Elapsed;
                    int nSeconds = Convert.ToInt32(TervalTime.TotalSeconds);

                    if (Common.DIgrp.DIList[9] == true && isB1)
                    {
                        isB1 = false;
                        Common.AOgrp.CAO01 = para.PercentServeIn;
                        Common.DOgrp[2] = true;
                    }
                    if (Common.DIgrp.DIList[10] == true && isB2 == false && isB3)
                    {
                        isB3 = false;
                        dy = nSeconds;
                        qTt = dy - gy;
                    }
                    if (Common.DIgrp.DIList[9] == false && isB2)
                    {
                        isB2 = false;
                        Common.AOgrp.CAO01 = para.PercentServeOut;
                        Common.DOgrp[2] = false;
                        gy = nSeconds;
                        tTq = gy - dy;
                    }
                    if (nSeconds >= addup * ss)
                    {
                        ss++;
                    }
                    if (isB1 == false && isB2 == false)
                    {
                        isB1 = true;
                        isB2 = true;
                        isB3 = true;
                        int nTemp = ++qtcs;
                        if (nTemp % 2 == 0)
                        {
                            TxtTips("已完成【" + (nTemp / 2) + "】次启停试验");
                        }
                        SetResult(ss - 1, qTt, tTq);
                    }
                    TxtTiming(para.QTTime * 60 - nSeconds);
                    Delay(0.5);
                }
                TestStatus(false);
                TxtTips("启停试验结束");
                return true;

            }
            catch (Exception ex)
            {
                TxtTips("启停试验失败，原因：" + ex.Message);
                return false;
            }
        }
        public void SetResult(int i, double qtkPa, double xykPa)
        {
            Common.mResultAll.tq[i] = xykPa.ToString("f1");
            Common.mResultAll.tqx[i] = qtkPa.ToString("f1");
           
        }
    }
}
