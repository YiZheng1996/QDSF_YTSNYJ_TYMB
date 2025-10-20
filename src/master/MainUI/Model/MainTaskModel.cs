using FreeSql.DataAnnotations;

namespace MainUI.Model
{
    /// <summary>
    /// Get结果
    /// </summary>
    public class MainTaskResultModel
    {
        public string msg { get; set; }
        public string total { get; set; }
        public string state { get; set; }
        public List<MainTaskModel> list { get; set; }
    }


    [Table(Name = "MainTaskTable")]
    public class MainTaskModel
    {
        public List<holdItem> holdItems { get; set; }

        [Column(IsIdentity = true, IsPrimary = true)]
        public int ID { get; set; }

        /// <summary>
        /// 耐压任务ID
        /// </summary>
        public string holdTaskId { get; set; }

        /// <summary>
        /// 项目类型
        /// </summary>
        public string projectTypeName { get; set; }

        /// <summary>
        /// 车型编码
        /// </summary>
        public string projectNumber { get; set; }

        /// <summary>
        /// 车列号(新造厂内列编号)
        /// </summary>
        public string trainNo { get; set; }

        /// <summary>
        /// 配属列号
        /// </summary>
        public string trainCode { get; set; }

        /// <summary>
        /// 配属辆号
        /// </summary>
        public string carCode { get; set; }

        /// <summary>
        /// 班组id(即部门id)
        /// </summary>
        public string depId { get; set; }

        /// <summary>
        /// 修程类型    1015-10:新造,1015-30:三级修,1015-40:四级修,1015-50:五级修
        /// </summary>
        public string debugType { get; set; }

        /// <summary>
        /// 耐压子任务id
        /// </summary>
        public string holdItemId { get; set; }

        /// <summary>
        /// 耐压项目名称
        /// </summary>
        public string itemName { get; set; }

        /// <summary>
        /// 自检进度
        /// </summary>
        public string operateProcess { get; set; }

        /// <summary>
        /// 互检进度
        /// </summary>
        public string mutualProcess { get; set; }

        /// <summary>
        /// 质检进度
        /// </summary>
        public string qualityProcess { get; set; }
    }

    public class holdItem
    {
        /// <summary>
        /// 耐压子任务id
        /// </summary>
        public string holdItemId { get; set; }

        /// <summary>
        /// 耐压项目名称
        /// </summary>
        public string itemName { get; set; }

        /// <summary>
        /// 自检进度
        /// </summary>
        public string operateProcess { get; set; }

        /// <summary>
        /// 互检进度
        /// </summary>
        public string mutualProcess { get; set; }

        /// <summary>
        /// 质检进度
        /// </summary>
        public string qualityProcess { get; set; }
    }

}
