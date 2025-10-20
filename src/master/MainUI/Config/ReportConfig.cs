namespace MainUI.Config
{
    public class ReportConfig : IniConfig
    {
        public ReportConfig()
          : base(Application.StartupPath + "\\config\\reportPath.ini")
        {
        }
        public ReportConfig(string sectionName)
            : base(Application.StartupPath + "\\config\\reportPath.ini")
        {
            this.SetSectionName(sectionName);
            Load();
        }
        /// <summary>
        /// 报表名称
        /// </summary>
        [IniKeyName("报表名称")]
        public string RptFile { get; set; }
    }
}
