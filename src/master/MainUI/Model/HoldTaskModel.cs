using FreeSql.DataAnnotations;

namespace MainUI.Model
{
    internal class HoldTaskResultModel
    {
        public string msg { get; set; }
        public string total { get; set; }
        public string state { get; set; }

        /// <summary>
        /// 数据集合
        /// </summary>
        public List<HoldTaskModel> list { get; set; }
    }


    [Table(Name = "HoldTaskTable")]
    internal class HoldTaskModel
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public int ID { get; set; }

        /// <summary>
        /// 耐压操作步骤ID(注:工艺数据)
        /// </summary>
        public string stepId { get; set; }

        /// <summary>
        /// 耐压任务ID
        /// </summary>
        public string holdTaskId { get; set; }

        /// <summary>
        /// 耐压子任务ID
        /// </summary>
        public string holdItemId { get; set; }

        /// <summary>
        /// 耐压任务明细id， 子任务唯一列
        /// </summary>
        public string detailId { get; set; }

        /// <summary>
        /// 耐压步骤名称
        /// </summary>
        public string stepName { get; set; }

        /// <summary>
        /// 耐压操作区域
        /// </summary>
        public string stepBom { get; set; }

        /// <summary>
        /// 耐压操作内容
        /// </summary>
        public string stepContent { get; set; }

        /// <summary>
        /// 耐压操作排序
        /// </summary>
        public string stepNo { get; set; }

        /// <summary>
        /// 配属辆号（该耐压工步试验对应的车辆号），TC01
        /// </summary>
        public string vhecileNo { get; set; }

        /// <summary>
        /// 是否操作位置，0:否 1:是（表示‘ＤＣ１1０V回路’耐压试验在‘TC01’车上做试验）
        /// </summary>
        public string isOperateCell { get; set; }

        /// <summary>
        /// 结果默认内容，mA表示单位，<>里的内容代表最小值到最大值的区间范围，用逗号隔开,  格式：[0A<10,100>mA] 
        /// </summary>
        public string resultContent { get; set; }

        /// <summary>
        /// 结果记录类型，1签认,2数据,3影像
        /// </summary>
        public string recordType { get; set; }

        /// <summary>
        /// 结果记录范围标准   "<10,100>"
        /// </summary>
        public string resultStandard { get; set; }

        /// <summary>
        /// 结果单位,结果值是数值类型的有单位,没有则为空    mA
        /// </summary>
        public string resultUnit { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 环境温度
        /// </summary>
        public string testTemperature { get; set; }

        /// <summary>
        /// 湿度
        /// </summary>
        public string testHumidity { get; set; }

        /// <summary>
        /// 实际施加电压（V）
        /// </summary>
        public string applyVoltage { get; set; }

        /// <summary>
        /// 结果值
        /// </summary>
        public string testValue { get; set; }

        /// <summary>
        /// 耐压试验过程结果数组
        /// </summary>
        public string testProcessValues { get; set; }

        /// <summary>
        /// 操作人姓名（结果字段）  "张三"
        /// </summary>
        public string operatePersonName { get; set; }

        /// <summary>
        /// 操作人（结果字段）  工号： "024343322"
        /// </summary>
        public string operatePerson { get; set; }

        /// <summary>
        /// 操作时间（结果字段）
        /// </summary>
        public string operateTime { get; set; }

        /// <summary>
        /// 自检结果（结果字段,0不合格1合格）
        /// </summary>
        public string operateResult { get; set; }

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
        /// 互检时间（结果字段）
        /// </summary>
        public string mutualTime { get; set; }

        /// <summary>
        /// 互检结果（结果字段, 0不合格1合格）
        /// </summary>
        public string mutualResult { get; set; }

        /// <summary>
        /// 质检人姓名（结果字段）
        /// </summary>
        public string qualityPersonName { get; set; }

        /// <summary>
        /// 质检人工号（结果字段）
        /// </summary>
        public string qualityPerson { get; set; }

        /// <summary>
        /// 质检时间（结果字段）
        /// </summary>
        public string qualityTime { get; set; }

        /// <summary>
        /// 质检结果（结果字段, 0不合格1合格）
        /// </summary>
        public string qualityResult { get; set; }

        /// <summary>
        /// 是否完成任务，0：下载完成任务状态，1：试验完成后任务状态，2：上传完成后状态
        /// </summary>
        public int isComplete { get; set; } = 0;

        /// <summary>
        /// 创建时间
        /// </summary>
        public string CreateTime { get; set; }
    }

}
