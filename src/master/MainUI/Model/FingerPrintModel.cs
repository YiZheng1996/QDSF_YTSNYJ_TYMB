using FreeSql.DataAnnotations;

namespace MainUI.Model
{
    [Table(Name = "Demo")]
    internal class FingerPrintModel
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public int id { get; set; }

        /// <summary>
        /// 耐压任务ID
        /// </summary>
        public string fid { get; set; }

        /// <summary>
        /// 项目类型
        /// </summary>
        public int userID { get; set; }
    }
}
