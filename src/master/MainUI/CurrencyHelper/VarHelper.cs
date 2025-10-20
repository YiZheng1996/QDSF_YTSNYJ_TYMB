using MainUI.Procedure.Mask;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace MainUI.CurrencyHelper
{
    public partial class VarHelper
    {
        public static IFreeSql fsql;
        public static SpeechHelper speech;
        public static string SoftName = "";
        public static bool NetworkState = false; //网络状态，用于接口实现,true在线
        public static bool TaskModel = false; //离线模式下，是否继续使用任务做试验
        public static string testProcessValues;  //耐压试验过程结果数组
        public static TestViewModel mTestViewModel = new();
        public static AuthenticationConfig deviceConfig;
        public static ProductionSystemConfig ProductionConfig;
        public static bool isRedoing = false;//是否连续任务标志位

        // 车型编码
        public static string LastProjectNumber { get; set; } = "";
        // 配属辆号下标
        public static string LastCarCode { get; set; } = "";
        // 车列号下标
        public static string LastTrainNo { get; set; } = "";

        static VarHelper()
        {
            speech = new SpeechHelper();
            speech.SetRate(3);
            deviceConfig = new AuthenticationConfig();
            ProductionConfig = new ProductionSystemConfig();
        }

        [GeneratedRegex(@"[^\d]*")]
        private static partial Regex MyRegex();
        //截取获取电压
        public static (int time, double voltage) GetVoltage(string str)
        {
            try
            {
                string[] strArray = str.Split((string[])(["AC", ","]), StringSplitOptions.RemoveEmptyEntries);
                string min = strArray[0].ToString();
                string min2 = strArray[1].ToString();
                string time = strArray[2].ToString();
                return (MyRegex().Replace(time, "").ToInt() * 60, MyRegex().Replace(min2, "").ToDouble());
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("截取试验电压、试验时间错误：", ex);
                MessageBox.Show("截取试验电压、试验时间错误：" + ex.Message, "系统提示！");
                return (0, -1.0);
            }
        }

        /// <summary>
        /// 截取保护电流
        /// </summary>
        /// <param name="resul"></param>
        /// <returns></returns>
        public static double GetCurrent(string resul)
        {
            if (string.IsNullOrEmpty(resul))
            {
                return 0;
            }
            string[] strArray = resul.Split((string[])([",", "<", ">"]), StringSplitOptions.RemoveEmptyEntries);
            string max = strArray[1].ToString();

            try
            {
                return max == "∞" ? 999.0 : max.ToDouble();
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("截取保护电流错误：", ex);
                MessageBox.Show("截取保护电流错误：" + ex);
            }
            return 999.0;
        }

        /// <summary>
        /// SHA512加密
        /// </summary>
        /// <param name="salt">头</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public static string SHA512Encoding(string salt, string password)
        {
            byte[] saltPasswordValue = Encoding.UTF8.GetBytes(salt + password);
            // 计算哈希值
            saltPasswordValue = MD5.HashData(saltPasswordValue);

            for (int i = 0; i < 1023; i++)//因为上面计算了一次hash,所以只需要迭代1023次
            {
                saltPasswordValue = MD5.HashData(saltPasswordValue);
            }
            return Convert.ToBase64String(saltPasswordValue);
        }

        /// <summary>
        /// 遮罩层
        /// </summary>
        /// <param name="dialog">Form</param>
        public static void ShowDialogWithOverlay(Form dialog1, Form dialog2)
        {
            LayerForm layerForm = new(dialog1, dialog2);
            layerForm.ShowDialog();
        }

        /// <summary>
        /// 量程转换
        /// </summary>
        /// <param name="input"></param>
        /// <param name="inputL">4</param>
        /// <param name="inputH">20</param>
        /// <param name="outL">0</param>
        /// <param name="outH">1000</param>
        /// <returns></returns>
        public static double AIAO_Convert(double input, double inputL, double inputH, double outL, double outH)
        {
            double rst = (outH - outL) * (input - inputL) / (inputH - inputL) + outL;
            rst = Math.Round(rst, 3);
            return rst;
        }

        private static readonly bool[] voice = new bool[20];
        public static void DeviceDetection(Form frm, int index, bool value, Control lblStatus)
        {
            if (value)
            {
                switch (index)
                {
                    case 27:
                        if (!voice[0])
                        {
                            MessageHelper.MessageOK(frm, "【急停计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[0] = true;
                        }
                        break;
                    case 28:
                        if (!voice[1])
                        {
                            MessageHelper.MessageOK(frm, "【接地报警计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[1] = true;
                        }
                        break;
                    case 29:
                        if (!voice[2])
                        {
                            MessageHelper.MessageOK(frm, "【电铃计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[2] = true;
                        }
                        break;
                    case 30:
                        if (!voice[3])
                        {
                            MessageHelper.MessageOK(frm, "【门联锁计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[3] = true;
                        }
                        break;
                    case 31:
                        if (!voice[4])
                        {
                            MessageHelper.MessageOK(frm, "【调压低限计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[4] = true;
                        }
                        break;
                    case 32:
                        if (!voice[5])
                        {
                            MessageHelper.MessageOK(frm, "【调压高限计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[5] = true;
                        }
                        break;
                    case 33:
                        if (!voice[6])
                        {
                            MessageHelper.MessageOK(frm, "【调压电机报警计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[6] = true;
                        }
                        break;
                    case 34:
                        if (!voice[7])
                        {
                            MessageHelper.MessageOK(frm, "【主接触器计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[7] = true;
                        }
                        break;
                    case 35:
                        if (!voice[8])
                        {
                            MessageHelper.MessageOK(frm, "【从接触器计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[8] = true;
                        }
                        break;
                    case 36:
                        if (!voice[9])
                        {
                            MessageHelper.MessageOK(frm, "【放电计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[9] = true;
                        }
                        break;
                    case 37:
                        if (!voice[10])
                        {
                            MessageHelper.MessageOK(frm, "【电动门锁计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[10] = true;
                        }
                        break;
                    case 38:
                        if (!voice[11])
                        {
                            MessageHelper.MessageOK(frm, "【启动按钮计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[11] = true;
                        }
                        break;
                    case 39:
                        if (!voice[12])
                        {
                            MessageHelper.MessageOK(frm, "【升压按钮计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[12] = true;
                        }
                        break;
                    case 40:
                        if (!voice[13])
                        {
                            MessageHelper.MessageOK(frm, "【降压按钮计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[13] = true;
                        }
                        break;
                    case 41:
                        if (!voice[14])
                        {
                            MessageHelper.MessageOK(frm, "【停止按钮计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[14] = true;
                        }
                        break;
                    case 42:
                        if (!voice[15])
                        {
                            MessageHelper.MessageOK(frm, "【复位按钮计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[15] = true;
                        }
                        break;
                    case 43:
                        if (!voice[16])
                        {
                            MessageHelper.MessageOK(frm, "【计时按钮计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[16] = true;
                        }
                        break;
                    case 44:
                        if (!voice[17])
                        {
                            MessageHelper.MessageOK(frm, "【计数器计数】已达到设备设定值，请更换零部件，更换完毕后，请打开【设备检查界面】对相应硬件计数进行清零！！");
                            voice[17] = true;
                        }
                        break;
                    case 45:
                        speech.Speak("试验通过");
                        lblStatus.Text = "试验通过";
                        break;
                    case 46:
                        speech.Speak("试验失败");
                        lblStatus.Text = "试验失败";
                        break;
                    case 47:
                        speech.Speak("高压输出已合闸注意安全");
                        lblStatus.Text = "高压输出已合闸注意安全";
                        break;
                    case 48:
                        speech.Speak("电机复位中");
                        lblStatus.Text = "电机复位中";
                        break;
                    case 49:
                        speech.Speak("已达到零位");
                        lblStatus.Text = "已达到零位";
                        break;
                    case 50:
                        speech.Speak("已按急停按钮请注意");
                        lblStatus.Text = "已按急停按钮请注意";
                        break;
                    case 51:
                        speech.Speak("降压放电中");
                        lblStatus.Text = "降压放电中";
                        break;
                    case 52:
                        speech.Speak("接地保护失效");
                        lblStatus.Text = "接地保护失效";
                        break;
                    case 53:
                        speech.Speak("升压器过流保护");
                        lblStatus.Text = "升压器过流保护";
                        break;

                    case 54:
                        speech.Speak("放电完成");
                        lblStatus.Text = "放电完成";
                        break;
                    case 55:
                        speech.Speak("启动试验");
                        lblStatus.Text = "启动试验";
                        break;
                    case 56:
                        speech.Speak("传感器损坏");
                        lblStatus.Text = "传感器损坏";
                        break;
                    case 57:
                        speech.Speak("门限位失效请注意");
                        lblStatus.Text = "门限位失效请注意";
                        break;
                    case 58:
                        speech.Speak("未达到设置电压");
                        lblStatus.Text = "未达到设置电压";
                        break;
                    case 59:
                        speech.Speak("仪表与传感器采值误差偏大");
                        lblStatus.Text = "仪表与传感器采值误差偏大";
                        break;
                    case 60:
                        speech.Speak("伺服过流报警");
                        lblStatus.Text = "伺服过流报警";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (index)
                {
                    default:
                        break;
                }
            }
        }
    }
}
