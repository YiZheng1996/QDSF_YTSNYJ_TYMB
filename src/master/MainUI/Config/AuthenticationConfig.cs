namespace MainUI.Config
{
    public class AuthenticationConfig : IniConfig
    {
        public AuthenticationConfig()
        : base(Application.StartupPath + "config\\AuthenticationConfig.ini")
        {
            Load();
        }
        public AuthenticationConfig(string sectionName)
            : base(Application.StartupPath + "config\\AuthenticationConfig.ini")
        {
            SetSectionName(sectionName);
            Load();
        }

        /// <summary>
        /// 认证编码
        /// </summary>
        [IniKeyName("认证编码")]
        public string Authentication { get; set; }

        /// <summary>
        /// 是否开启认证功能
        /// </summary>
        [IniKeyName("是否开启认证功能")]
        public string isAuthentication { get; set; }
    }
}
