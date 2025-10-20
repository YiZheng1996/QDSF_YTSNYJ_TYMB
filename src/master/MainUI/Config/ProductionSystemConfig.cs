namespace MainUI.Config
{
    public class ProductionSystemConfig : IniConfig
    {
        public ProductionSystemConfig()
          : base(Application.StartupPath + "\\config\\ProductionSystemConfig.ini")
        {
            Load();
        }
        public ProductionSystemConfig(string sectionName)
            : base(Application.StartupPath + "\\config\\ProductionSystemConfig.ini")
        {
            SetSectionName(sectionName);
            Load();
        }

        /// <summary>
        /// 设备授权验证接口
        /// </summary>
        [IniKeyName("设备授权验证接口")]
        public string Empower { get; set; }

        /// <summary>
        /// 心跳接口
        /// </summary>
        [IniKeyName("心跳接口")]
        public string Heartbeat { get; set; }

        /// <summary>
        /// 人员同步接口
        /// </summary>
        [IniKeyName("人员同步接口")]
        public string personnel { get; set; }

        /// <summary>
        /// 修改密码接口
        /// </summary>
        [IniKeyName("修改密码接口")]
        public string ChangePassword { get; set; }

        /// <summary>
        /// 车型数据接口
        /// </summary>
        [IniKeyName("车型数据接口")]
        public string VehicleData { get; set; }

        /// <summary>
        /// 车列数据接口
        /// </summary>
        [IniKeyName("车列数据接口")]
        public string TrainData { get; set; }

        /// <summary>
        /// 获取耐压任务接口
        /// </summary>
        [IniKeyName("获取耐压任务接口")]
        public string GetMainTask { get; set; }

        /// <summary>
        /// 耐压任务明细接口
        /// </summary>
        [IniKeyName("耐压任务明细接口")]
        public string GetHoldTask { get; set; }

        /// <summary>
        /// 耐压任务结果回传接口
        /// </summary>
        [IniKeyName("耐压任务结果回传接口")]
        public string ResultFeedback { get; set; }

        /// <summary>
        /// 业务字典数据接口
        /// </summary>
        [IniKeyName("业务字典数据接口")]
        public string BusinessDictionary { get; set; }

        /// <summary>
        /// 耐压任务异常试验数据上传接口
        /// </summary>
        [IniKeyName("耐压任务异常试验数据上传接口")]
        public string AbnormalData { get; set; }
    }
}
