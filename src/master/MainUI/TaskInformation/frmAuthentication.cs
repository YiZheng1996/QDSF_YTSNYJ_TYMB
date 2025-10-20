using MainUI.CurrencyHelper;
using MainUI.Model.StateModel;
using System.Net.NetworkInformation;

namespace MainUI.TaskInformation
{
    public partial class frmAuthentication : UIForm

    {
        private readonly List<string> _ListMAC = [];
        public frmAuthentication()
        {
            InitializeComponent();
        }

        private void BtnGetMAC_Click(object sender, EventArgs e)
        {
            try
            {
                selectMAC.Items.Clear(); selectMAC.Text = "--请选择--";
                NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
                foreach (NetworkInterface ni in networkInterfaces)
                {
                    if (ni.Description.Contains("VMware", StringComparison.OrdinalIgnoreCase)) continue;
                    if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                        ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                    {
                        var Name = ni.Name;
                        var macAddress = FormatMacAddress(ni.GetPhysicalAddress());
                        selectMAC.Items.Add($"网络名称：{Name}，MAC地址：{macAddress}");
                        _ListMAC.Add(macAddress);
                    }
                }
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("获取MAC地址失败：", ex);
                MessageHelper.MessageOK(this, "获取MAC地址失败：" + ex.Message);
            }
        }

        private async void BtnRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectMAC.Items.Count != 0)
                {
                    Debug.WriteLine($"请求的MAC地址为：{_ListMAC[selectMAC.SelectedIndex]}");
                    HttpClientWithPolly restClient = new(VarHelper.ProductionConfig.Empower);
                    var resource = await restClient.PostAsync<deviceStateModel>(new
                    {
                        deviceMac = _ListMAC[selectMAC.SelectedIndex],
                    });
                    if (resource.state == "1")
                    {
                        VarHelper.deviceConfig.Authentication = resource.deviceNumber;
                        VarHelper.deviceConfig.Save();
                        MessageHelper.MessageOK(this, "设备认证成功！");
                    }
                }
                else
                {
                    MessageHelper.MessageOK(this, "MAC地址为空！");
                }
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("设备认证请求失败：", ex);
                MessageHelper.MessageOK(this, "设备认证请求失败：" + ex.Message);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string FormatMacAddress(PhysicalAddress mac)
        {
            try
            {
                byte[] bytes = mac.GetAddressBytes();
                string[] hex = bytes.Select(b => b.ToString("X2")).ToArray(); // 转换为十六进制字符串并填充到两位
                return string.Join("-", hex); // 使用 "-" 符号连接每两个字符
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("MAC地址转换失败：", ex);
                MessageHelper.MessageOK(this, "MAC地址转换失败：" + ex.Message);
                return string.Empty;
            }

        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}

