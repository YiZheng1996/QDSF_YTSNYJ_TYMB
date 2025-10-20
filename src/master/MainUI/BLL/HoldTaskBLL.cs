using MainUI.CurrencyHelper;

namespace MainUI.BLL
{
    internal class HoldTaskBLL
    {
        // 获取所有任务
        public List<HoldTaskModel> GetHoldTasks() => VarHelper.fsql.Select<HoldTaskModel>().ToList();

        // 根据主任务ID、明细ID，获取任务是否存在
        public List<HoldTaskModel> GetHoldTasks(HoldTaskModel model) => VarHelper.fsql.Select<HoldTaskModel>()
            .Where(m => m.holdTaskId == model.holdTaskId
                     && m.holdItemId == model.holdItemId
                     && m.detailId == model.detailId)
            .ToList();

        // 新增任务
        public bool AddHoldTask(HoldTaskModel model) => VarHelper.fsql.Insert(model).ExecuteAffrows() > 0;

        // 修改任务
        public bool UpdateHoldTask(HoldTaskModel model) => VarHelper.fsql.Update<HoldTaskModel>()
            .Set(s => s.holdItemId, model.holdItemId)
            .Set(s => s.stepId, model.stepId)
            .Set(s => s.stepName, model.stepName)
            .Set(s => s.stepBom, model.stepBom)
            .Set(s => s.stepContent, model.stepContent)
            .Set(s => s.stepNo, model.stepNo)
            .Set(s => s.vhecileNo, model.vhecileNo)
            .Set(s => s.isOperateCell, model.isOperateCell)
            .Set(s => s.resultContent, model.resultContent)
            .Set(s => s.recordType, model.recordType)
            .Set(s => s.resultStandard, model.resultStandard)
            .Set(s => s.resultUnit, model.resultUnit)
            .Set(s => s.remark, model.remark)
            .Set(s => s.testTemperature, model.testTemperature)
            .Set(s => s.testHumidity, model.testHumidity)
            .Set(s => s.testValue, model.testValue)
            .Set(s => s.operatePersonName, model.operatePersonName)
            .Set(s => s.operatePerson, model.operatePerson)
            .Set(s => s.operateTime, model.operateTime)
            .Set(s => s.operateResult, model.operateResult)
            .Set(s => s.auxiliariesName1, model.auxiliariesName1)
            .Set(s => s.auxiliariesCode1, model.auxiliariesCode1)
            .Set(s => s.auxiliariesName2, model.auxiliariesName2)
            .Set(s => s.auxiliariesCode2, model.auxiliariesCode2)
            .Set(s => s.auxiliariesName3, model.auxiliariesName3)
            .Set(s => s.auxiliariesCode3, model.auxiliariesCode3)
            .Set(s => s.auxiliariesName4, model.auxiliariesName4)
            .Set(s => s.auxiliariesCode4, model.auxiliariesCode4)
            .Set(s => s.mutualPersonName, model.mutualPersonName)
            .Set(s => s.mutualPerson, model.mutualPerson)
            .Set(s => s.mutualTime, model.mutualTime)
            .Set(s => s.mutualResult, model.mutualResult)
            .Set(s => s.qualityPersonName, model.qualityPersonName)
            .Set(s => s.qualityPerson, model.qualityPerson)
            .Set(s => s.qualityTime, model.qualityTime)
            .Set(s => s.qualityResult, model.qualityResult)
            .Where(s => s.holdTaskId == model.holdTaskId && s.detailId == model.detailId)
            .ExecuteAffrows() > 0;

        // 任务获取
        public bool ModifyOrAddHoldTable(HoldTaskModel model)
        {
            var data = GetHoldTasks(model).FirstOrDefault();
            if (data == null)
            {
                //NlogHelper.Default.Fatal($"触发子任务存在：{DateTime.Now}，表ID:{data.ID}，" +
                //$"主任务ID为：{data.holdTaskId}，" +
                //$"子任务ID为：{data.holdItemId}");
            }
            return data != null ? UpdateHoldTask(model) : AddHoldTask(model);
        }

        // 任务,数据修改
        public bool TaskRedo(NewTaskModel model) => VarHelper.fsql.Update<HoldTaskModel>()
                                 .Set(a => a.testTemperature, model.testTemperature)
                                 .Set(a => a.testHumidity, model.testHumidity)
                                 .Set(a => a.applyVoltage, model.applyVoltage)
                                 .Set(a => a.testValue, model.testValue)
                                 .Set(a => a.testProcessValues, model.testProcessValues)
                                 .Set(a => a.remark, model.remark)
                                 .Set(a => a.operatePersonName, model.operatePersonName)
                                 .Set(a => a.operatePerson, model.operatePerson)
                                 .Set(a => a.operateTime, model.operateTime)
                                 .Set(a => a.operateResult, model.operateResult)
                                 .Set(a => a.auxiliariesName1, model.auxiliariesName1)
                                 .Set(a => a.auxiliariesCode1, model.auxiliariesCode1)
                                 .Set(a => a.auxiliariesName2, model.auxiliariesName2)
                                 .Set(a => a.auxiliariesCode2, model.auxiliariesCode2)
                                 .Set(a => a.auxiliariesName3, model.auxiliariesName3)
                                 .Set(a => a.auxiliariesCode3, model.auxiliariesCode3)
                                 .Set(a => a.auxiliariesName4, model.auxiliariesName4)
                                 .Set(a => a.auxiliariesCode4, model.auxiliariesCode4)
                                 .Set(a => a.mutualPersonName, model.mutualPersonName)
                                 .Set(a => a.mutualPerson, model.mutualPerson)
                                 .Set(a => a.mutualTime, model.mutualTime)
                                 .Set(a => a.mutualResult, model.mutualResult)
                                 .Set(a => a.qualityPersonName, model.qualityPersonName)
                                 .Set(a => a.qualityPerson, model.qualityPerson)
                                 .Set(a => a.qualityTime, model.qualityTime)
                                 .Set(a => a.qualityResult, model.qualityResult)
                                 .Set(a => a.isComplete, model.isComplete)
                                 .Where(a => a.ID == model.ID)
                                 .ExecuteAffrows() > 0;

        // 任务回传 数据修改
        public bool TaskBackhaul(NewTaskModel model)
        {
            return VarHelper.fsql.Update<HoldTaskModel>()
                .Set(a => a.mutualResult, model.mutualResult)
                .Set(a => a.mutualTime, model.mutualTime)
                .Set(a => a.qualityResult, model.qualityResult)
                .Set(a => a.qualityTime, model.qualityTime)
                .Set(a => a.isComplete, model.isComplete)
                .Where(a => a.ID == model.ID)
                .ExecuteAffrows() > 0;
        }
    }
}
