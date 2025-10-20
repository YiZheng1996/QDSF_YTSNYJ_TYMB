using FreeSql.DataAnnotations;

namespace MainUI.Model
{
    [Table(Name = "Users")]
    public class OperateUserModel
    {
        /// <summary>
        /// 用户编号
        /// </summary>
        [Column(IsIdentity = true, IsPrimary = true)]
        public int ID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 工作人员工号
        /// </summary>
        public string JobNumber { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        public string Permission { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 班组ID
        /// </summary>
        public string depId { get; set; }

        /// <summary>
        /// 班组名称
        /// </summary>
        public string depName { get; set; }

        public void InitUser(OperateUserModel user)
        {
            depId = user.depId;
            depName = user.depName;
            Username = user.Username;
            JobNumber = user.JobNumber;
            Password = user.Password;
            Permission = user.Permission;
            ID = user.ID;
            Sort = user.Sort;
        }
    }
}
