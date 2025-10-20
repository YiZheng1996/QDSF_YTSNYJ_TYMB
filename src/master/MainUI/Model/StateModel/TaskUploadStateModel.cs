using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.Model.StateModel
{
    public class TaskUploadStateModel : StateModelBase
    {
        public string total { get; set; }
    }

    public class TaskUploadModel
    {
        /// <summary>
        /// 工序类型
        /// 1：下料2：预组  3：配线4：布线5：接线6：导通7：耐压 8: 高压试验
        /// 默认7
        /// </summary>
        public string procedureType { get; set; }

        /// <summary>
        /// 唯一认证编码
        /// </summary>
        public string deviceNumber { get; set; }

        /// <summary>
        /// 登录人员员工号
        /// </summary>
        public string personCode { get; set; }

        /// <summary>
        /// 耐压施工任务id
        /// </summary>
        public string holdTaskId { get; set; }

        /// <summary>
        /// 耐压施工子任务id
        /// </summary>
        public string holdItemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<TaskUploadList> list { get; set; }
    }

    public class TaskUploadList
    {
        /// <summary>
        /// 耐压任务明细id， 子任务唯一列
        /// </summary>
        public string detailId { get; set; }

        /// <summary>
        /// 环境温度
        /// </summary>
        public string testTemperature { get; set; }

        /// <summary>
        /// 湿度
        /// </summary>
        public string testHumidity { get; set; }

        /// <summary>
        /// 实际施加电压   ---------试验过程赋值
        /// </summary>
        public string applyVoltage { get; set; }

        /// <summary>
        /// 结果值          ---------试验过程赋值
        /// </summary>
        public string testValue { get; set; }

        /// <summary>
        /// 耐压试验过程结果数组     ---------试验过程赋值
        /// </summary>
        public string testProcessValues { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }

        /// <summary>
        /// 操作人姓名（结果字段）
        /// </summary>
        public string operatePersonName { get; set; }
        /// <summary>
        /// 操作人（结果字段）
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
        /// 质检人（结果字段）
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
    }
}
