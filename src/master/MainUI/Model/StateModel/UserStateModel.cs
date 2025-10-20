namespace MainUI.Model.StateModel
{
    public class UserStateModel : StateModelBase
    {
        public string total { get; set; }

        public List<findPersonList> list { get; set; }
    }

    public class findPersonList
    {
        /// <summary>
        /// 人员工号
        /// </summary>
        public string personCode { get; set; }

        /// <summary>
        /// 人员姓名
        /// </summary>
        public string personName { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string password { get; set; }

        /// <summary>
        /// 班组ID
        /// </summary>
        public string depId { get; set; }

        /// <summary>
        /// 班组名称
        /// </summary>
        public string depName { get; set; }

    }
}
