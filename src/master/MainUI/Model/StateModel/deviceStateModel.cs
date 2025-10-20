

namespace MainUI.Model.StateModel
{
    public class deviceStateModel : StateModelBase
    {
        /// <summary>
        /// 1.授权成功时返回：硬件设备在EPE系统中认证的唯一认证编码  2.授权失败时返回空
        /// </summary>
        public string deviceNumber { get; set; }
    }
}
