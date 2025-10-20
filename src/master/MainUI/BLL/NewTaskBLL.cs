using MainUI.CurrencyHelper;

namespace MainUI.BLL;

/// <summary>
/// 中间层
/// </summary>
public class NewTaskBLL
{
    public List<NewTaskModel> GetNewTasks(NewTaskModel model) =>
        VarHelper.fsql.Select<MainTaskModel, HoldTaskModel>()
         .LeftJoin((m, h) => m.holdTaskId == h.holdTaskId && m.holdItemId == h.holdItemId)
         .WhereIf(!string.IsNullOrEmpty(model.projectNumber), (m, h) => m.projectNumber == model.projectNumber)
         .WhereIf(!string.IsNullOrEmpty(model.trainCode), (m, h) => m.trainCode == model.trainCode)
         .WhereIf(!string.IsNullOrEmpty(model.trainNo), (m, h) => m.trainNo == model.trainNo)
         .WhereIf(!string.IsNullOrEmpty(model.carCode), (m, h) => m.carCode == model.carCode)
         .WhereIf(!string.IsNullOrEmpty(model.holdTaskId), (m, h) => m.holdTaskId == model.holdTaskId)
         .WhereIf(!string.IsNullOrEmpty(model.holdItemId), (m, h) => m.holdItemId == model.holdItemId)
         .WhereIf(!string.IsNullOrEmpty(model.detailId), (m, h) => h.detailId == model.detailId)
         .Where((m, h) => h.isComplete == model.isComplete)
         .ToList((m, h) => new NewTaskModel
         {
             ID = h.ID,
             holdTaskId = m.holdTaskId,
             holdItemId = m.holdItemId,
             projectNumber = m.projectNumber,
             trainNo = m.trainNo,
             trainCode = m.trainCode,
             carCode = m.carCode,
             detailId = h.detailId,
             stepName = h.stepName,
             stepBom = h.stepBom,
             stepContent = h.stepContent,
             stepNo = h.stepNo,
             isOperateCell = h.isOperateCell,
             resultContent = h.resultContent,
             recordType = h.recordType,
             resultStandard = h.resultStandard,
             resultUnit = h.resultUnit,
             testTemperature = h.testTemperature,
             testHumidity = h.testHumidity,
             applyVoltage = h.applyVoltage,
             testValue = h.testValue,
             testProcessValues = h.testProcessValues,
             remark = h.remark,
             operatePersonName = h.operatePersonName,
             operatePerson = h.operatePerson,
             operateTime = h.operateTime,
             operateResult = h.operateResult,
             auxiliariesName1 = h.auxiliariesName1,
             auxiliariesCode1 = h.auxiliariesCode1,
             auxiliariesName2 = h.auxiliariesName2,
             auxiliariesCode2 = h.auxiliariesCode2,
             auxiliariesName3 = h.auxiliariesName3,
             auxiliariesCode3 = h.auxiliariesCode3,
             auxiliariesName4 = h.auxiliariesName4,
             auxiliariesCode4 = h.auxiliariesCode4,
             mutualPersonName = h.mutualPersonName,
             mutualPerson = h.mutualPerson,
             mutualTime = h.mutualTime,
             mutualResult = h.mutualResult,
             qualityPersonName = h.qualityPersonName,
             qualityPerson = h.qualityPerson,
             qualityTime = h.qualityTime,
             qualityResult = h.qualityResult,
         });
}
