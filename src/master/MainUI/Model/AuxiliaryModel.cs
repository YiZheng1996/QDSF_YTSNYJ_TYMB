using FreeSql.DataAnnotations;

namespace MainUI.Model
{
    [Table(Name = "AuxiliaryTable")]
    public class AuxiliaryModel
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public int ID { get; set; }


        /// <summary>
        /// 辅助姓名1（结果字段）
        /// </summary>
        public string auxiliariesName1 { get; set; }

        /// <summary>
        /// 辅助人工号1（结果字段）
        /// </summary>
        public string auxiliariesCode1 { get; set; }

        /// <summary>
        /// 辅助姓名2（结果字段）
        /// </summary>
        public string auxiliariesName2 { get; set; }

        /// <summary>
        /// 辅助人工号2（结果字段）
        /// </summary>
        public string auxiliariesCode2 { get; set; }

        /// <summary>
        /// 辅助姓名3（结果字段）
        /// </summary>
        public string auxiliariesName3 { get; set; }

        /// <summary>
        /// 辅助人工号3（结果字段）
        /// </summary>
        public string auxiliariesCode3 { get; set; }

        /// <summary>
        /// 辅助姓名4（结果字段）
        /// </summary>
        public string auxiliariesName4 { get; set; }

        /// <summary>
        /// 辅助人工号4（结果字段）
        /// </summary>
        public string auxiliariesCode4 { get; set; }

        /// <summary>
        /// 互检人姓名（结果字段）
        /// </summary>
        public string mutualPersonName { get; set; }

        /// <summary>
        /// 互检人（结果字段）
        /// </summary>
        public string mutualPerson { get; set; }

        /// <summary>
        /// 质检人姓名（结果字段）
        /// </summary>
        public string qualityPersonName { get; set; }

        /// <summary>
        /// 质检人工号（结果字段）
        /// </summary>
        public string qualityPerson { get; set; }

    }
}
