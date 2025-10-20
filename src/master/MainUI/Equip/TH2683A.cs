using System.IO.Ports;

namespace MainUI.Equip
{
    public class TH2683A
    {
        public static SerialPort _serialPort2683AB;

        /// <summary>
        ///  发送*idn?，有返回则说明通讯正常。 无返回则通讯异常。
        /// </summary>
        /// <returns></returns>
        public static string IsComConnect()
        {
            string str = "";
            try
            {
                if (!_serialPort2683AB.IsOpen)
                {
                    _serialPort2683AB.Open();
                }
                Thread.Sleep(500);
                if (_serialPort2683AB.IsOpen)
                {
                    Thread.Sleep(50);
                    _serialPort2683AB.DiscardInBuffer();
                    _serialPort2683AB.DiscardOutBuffer();
                    Thread.Sleep(50);
                    _serialPort2683AB.WriteLine("*idn?"); //查询产品信息，判断是否有返回
                    Thread.Sleep(1000);
                    str = _serialPort2683AB.ReadExisting();
                    if (!string.IsNullOrEmpty(str))
                    {
                        return "通讯正常"; // 或返回 str
                    }
                    else
                    {
                        return "通讯失败";
                    }
                }
                else
                    return "通讯失败";
            }
            catch (Exception)
            {
                return "通讯失败";
            }
        }

        public static void TH2683B_Test(string sDC, string sTime)
        {
            if (!_serialPort2683AB.IsOpen)
            {
                _serialPort2683AB.Open();
            }
            if (_serialPort2683AB.IsOpen)
            {
                Thread.Sleep(50);
                _serialPort2683AB.DiscardInBuffer();
                _serialPort2683AB.DiscardOutBuffer();
                Thread.Sleep(100);
                _serialPort2683AB.WriteLine("FUNCtion:MTIMe " + sTime); //持续时间
                Thread.Sleep(100);
                _serialPort2683AB.WriteLine("FUNCtion:DTIMe 5");       //放电时间
                Thread.Sleep(100);
                _serialPort2683AB.WriteLine("FUNCtion:CTIMe 5");      //充电时间
                Thread.Sleep(100);
                _serialPort2683AB.WriteLine("FUNCtion:OVOL " + sDC);
                Thread.Sleep(100);
                _serialPort2683AB.WriteLine("FUNCtion:MMOD SINGle");
                Thread.Sleep(100);
                TH2683B_TestStart();
            }
        }

        public static void TH2683B_TestStart()
        {
            if (!_serialPort2683AB.IsOpen)
            {
                _serialPort2683AB.Open();
            }
            Thread.Sleep(500);
            if (_serialPort2683AB.IsOpen)
            {
                Thread.Sleep(50);
                _serialPort2683AB.DiscardInBuffer();
                _serialPort2683AB.DiscardOutBuffer();
                Thread.Sleep(50);
                _serialPort2683AB.WriteLine("TRIG");
            }
        }

        public static string TH2683B_ReadData()
        {
            try
            {
                string str = "";
                //System.Threading.Thread.Sleep(10000);现场测试，需要等待10秒左右，才能读取到结果。
                //System.Threading.Thread.Sleep(10000);现场测试，需要等待10秒左右，才能读取到结果。
                //System.Threading.Thread.Sleep(10000);现场测试，需要等待10秒左右，才能读取到结果。
                //10s等待放到界面等待。
                _serialPort2683AB.DiscardInBuffer();
                _serialPort2683AB.DiscardOutBuffer();
                Thread.Sleep(1000);
                _serialPort2683AB.WriteLine("FETC?");
                Thread.Sleep(1000);
                str = _serialPort2683AB.ReadExisting();
                _serialPort2683AB.WriteLine("FUNCtion: DTIMe 5.0");
                string[] err = str.Split(',');
                string sTemp = err[0];
                sTemp = sTemp.Trim();
                if (!string.IsNullOrEmpty(sTemp))
                {
                    float fTemp = Convert.ToSingle(sTemp);
                    fTemp = fTemp / 1000000;
                    return fTemp.ToString();  // 换算后单位 MΩ
                }
                else
                {
                    return sTemp;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Debug.WriteLine("TH2683A/B通讯有误，" + ex.Message);
                return "";
            }
        }

        public static void TestStop()
        {
            try
            {
                Thread.Sleep(10000);
                _serialPort2683AB.DiscardInBuffer();
                _serialPort2683AB.DiscardOutBuffer();
                Thread.Sleep(5000);
                _serialPort2683AB.WriteLine("DISCharge");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Debug.WriteLine("TH2683A/B通讯有误，" + ex.Message);

            }
        }

    }
}
