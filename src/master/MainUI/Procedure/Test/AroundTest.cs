using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainUI.Procedure
{
    /// <summary>
    /// 卸荷试验
    /// </summary>
    public class AroundTest : BaseTest
    {
        double[,] AirTightness = new double[3, 4];
        public override bool Execute()
        {
            try
            {
                TestStatus(true);
                TxtTips("卸荷试验试验开始");
                TxtTips("卸荷试验试验结束");
                TestStatus(false);
                return true;
            }
            catch (Exception ex)
            {
                TxtTips("卸荷试验试验失败，原因：" + ex.Message);
                return false;
            }
        }
    }
}
