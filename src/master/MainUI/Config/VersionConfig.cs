namespace MainUI.Config
{
    public class VersionConfig : IniConfig
    {
        public VersionConfig()
          : base(Application.StartupPath + "\\config\\Version.ini")
        {
        }
        public VersionConfig(string sectionName)
            : base(Application.StartupPath + "\\config\\Version.ini")
        {
            this.SetSectionName(sectionName);
            Load();
        }
        /// <summary>
        /// 版本
        /// </summary>
        [IniKeyName("版本")]
        public string Version { get; set; }



    }
}
