namespace MainUI.Config
{
    public class ParaConfig : IniConfig
    {
        public ParaConfig()
          : base(Application.StartupPath + "config\\Para.ini")
        {
        }
        public ParaConfig(string sectionName)
            : base(Application.StartupPath + "config\\Para.ini")
        {
            this.SetSectionName(sectionName);
            Load();
        }
        /// <summary>
        /// 报表名称
        /// </summary>
        [IniKeyName("报表名称")]
        public string RptFile
        {
            get
            {
                return Application.StartupPath + "reports\\" + "一体式新型耐压设备.xlsx";
            }
        }

        /// <summary>
        /// 回路一电压
        /// </summary>
        [IniKeyName("回路一电压")]
        public string Voltage1 { get; set; }

        /// <summary>
        /// 回路一电流
        /// </summary>
        [IniKeyName("回路一电流")]
        public string Current1 { get; set; }

        /// <summary>
        /// 回路二电压
        /// </summary>
        [IniKeyName("回路二电压")]
        public string Voltage2 { get; set; }

        /// <summary>
        /// 回路二电流
        /// </summary>
        [IniKeyName("回路二电流")]
        public string Current2 { get; set; }

        /// <summary>
        /// 回路三电压
        /// </summary>
        [IniKeyName("回路三电压")]
        public string Voltage3 { get; set; }

        /// <summary>
        /// 回路三电流
        /// </summary>
        [IniKeyName("回路三电流")]
        public string Current3 { get; set; }

        /// <summary>
        /// 回路四电压
        /// </summary>
        [IniKeyName("回路四电压")]
        public string Voltage4 { get; set; }

        /// <summary>
        /// 回路四电流
        /// </summary>
        [IniKeyName("回路四电流")]
        public string Current4 { get; set; }

        /// <summary>
        /// 试验时间
        /// </summary>
        [IniKeyName("试验时间")]
        public string TestTime { get; set; }
    }
}
