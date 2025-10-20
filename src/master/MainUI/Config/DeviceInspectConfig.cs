namespace MainUI.Config
{
    public class DeviceInspectConfig : IniConfig
    {
        public DeviceInspectConfig()
          : base(Application.StartupPath + "config\\DeviceInspectConfig.ini")
        {
            Load();
        }
        public DeviceInspectConfig(string sectionName)
            : base(Application.StartupPath + "config\\DeviceInspectConfig.ini")
        {
            SetSectionName(sectionName);
            Load();
        }

        /// <summary>
        /// 急停计数
        /// </summary>
        [IniKeyName("急停计数")]
        public string EmergencyStop { get; set; }

        /// <summary>
        /// 接地报警计数
        /// </summary>
        [IniKeyName("接地报警计数")]
        public string Grounding { get; set; }

        /// <summary>
        /// 电铃计数
        /// </summary>
        [IniKeyName("电铃计数")]
        public string ElectricBell { get; set; }

        /// <summary>
        /// 门联锁计数
        /// </summary>
        [IniKeyName("门联锁计数")]
        public string Interlock { get; set; }

        /// <summary>
        /// 调压底限计数
        /// </summary>
        [IniKeyName("调压底限计数")]
        public string LowerLimit { get; set; }

        /// <summary>
        /// 调压高限计数
        /// </summary>
        [IniKeyName("调压高限计数")]
        public string HighLimit { get; set; }

        /// <summary>
        /// 调压电机报警计数
        /// </summary>
        [IniKeyName("调压电机报警计数")]
        public string ElectricalMachinery { get; set; }

        /// <summary>
        /// 主接触器计数
        /// </summary>
        [IniKeyName("主接触器计数")]
        public string MainContact { get; set; }

        /// <summary>
        /// 从接触器计数
        /// </summary>
        [IniKeyName("从接触器计数")]
        public string FromContact { get; set; }

        /// <summary>
        /// 放电次数
        /// </summary>
        [IniKeyName("放电次数")]
        public string Discharge { get; set; }


        /// <summary>
        /// 电动门锁计数
        /// </summary>
        [IniKeyName("电动门锁计数")]
        public string DoorLock { get; set; }

        /// <summary>
        /// 启动按钮计数
        /// </summary>
        [IniKeyName("启动按钮计数")]
        public string Start { get; set; }

        /// <summary>
        /// 升压按钮计数
        /// </summary>
        [IniKeyName("升压按钮计数")]
        public string Boost { get; set; }

        /// <summary>
        /// 降压按钮计数
        /// </summary>
        [IniKeyName("降压按钮计数")]
        public string StepDown { get; set; }

        /// <summary>
        /// 停止按钮计数
        /// </summary>
        [IniKeyName("停止按钮计数")]
        public string Stop { get; set; }

        /// <summary>
        /// 复位按钮计数
        /// </summary>
        [IniKeyName("复位按钮计数")]
        public string Reset { get; set; }

        /// <summary>
        /// 计时按钮计数
        /// </summary>
        [IniKeyName("计时按钮计数")]
        public string TimeBtn { get; set; }

        /// <summary>
        /// 计时器计数
        /// </summary>
        [IniKeyName("计时器计数")]
        public string TimerWare { get; set; }

    }
}
