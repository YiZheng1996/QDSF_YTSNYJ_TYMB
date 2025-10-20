using MainUI.CurrencyHelper;

namespace MainUI.BLL
{
    internal class MainTaskBLL
    {
        public List<MainTaskModel> GetMainTasks() => VarHelper.fsql.Select<MainTaskModel>().ToList();

        //TODO:修改处
        // 查询主任务是否存在
        public List<MainTaskModel> GetMainTasks(MainTaskModel model) => VarHelper.fsql.Select<MainTaskModel>()
            .Where(m => m.holdTaskId == model.holdTaskId
                     && m.holdItemId == model.holdItemId)
            .ToList();

        public bool AddMainTasks(MainTaskModel model) => VarHelper.fsql.Insert(model).ExecuteAffrows() > 0;

        public bool UpdateMainTasks(MainTaskModel model) => VarHelper.fsql.Update<MainTaskModel>()
            .Set(m => m.holdItemId, model.holdItemId)
            .Set(m => m.projectTypeName, model.projectTypeName)
            .Set(m => m.projectNumber, model.projectNumber)
            .Set(m => m.trainNo, model.trainNo)
            .Set(m => m.trainCode, model.trainCode)
            .Set(m => m.carCode, model.carCode)
            .Set(m => m.depId, model.depId)
            .Set(m => m.debugType, model.debugType)
            .Set(m => m.itemName, model.itemName)
            .Set(m => m.operateProcess, model.operateProcess)
            .Set(m => m.mutualProcess, model.mutualProcess)
            .Set(m => m.qualityProcess, model.qualityProcess)
            .Where(w => w.holdTaskId == model.holdTaskId)
            .ExecuteAffrows() > 0;

        public bool ModifyOrAddTaskTable(MainTaskModel model)
        {
            var data = GetMainTasks(model).First();
            if (data == null)
            {
               // NlogHelper.Default.Fatal($"触发主任务存在：{DateTime.Now}，表ID:{data.ID}，" +
               //$"主任务ID为：{data.holdTaskId}，" +
               //$"子任务ID为：{data.holdItemId}");
            }
            return data != null ?
                UpdateMainTasks(model) :
                AddMainTasks(model);
        }

        /// <summary>
        /// 车型编码去重，任务查看，上载使用
        /// </summary>
        /// <returns></returns>
        public List<string> GetCobProjectNumber() => [.. VarHelper.fsql.Select<MainTaskModel>()
               .GroupBy(a => new { a.projectNumber })
               .Select(a => a.Key.projectNumber)];

        /// <summary>
        /// 配属列号去重，任务查看，上载使用
        /// </summary>
        /// <returns></returns>
        public List<string> GetCobCarCode(string projectNumber = null) => [.. VarHelper.fsql.Select<MainTaskModel>()
               .WhereIf(!string.IsNullOrEmpty(projectNumber),a => a.projectNumber == projectNumber)
               .GroupBy(a => new { a.carCode })
               .Select(a => a.Key.carCode)];

        // 去重配属列号
        public List<string> GetCobTrainNo(string projectNumber = null, string carCode = null) =>
                [.. VarHelper.fsql.Select<MainTaskModel>()
               .WhereIf(!string.IsNullOrEmpty(projectNumber),a => a.projectNumber == projectNumber)
               .WhereIf(!string.IsNullOrEmpty(carCode),a => a.carCode == carCode)
               .GroupBy(a => new { a.trainNo })
               .Select(a => a.Key.trainNo)];
    }
}
