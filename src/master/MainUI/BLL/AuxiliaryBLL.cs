using MainUI.CurrencyHelper;

namespace MainUI.BLL
{
    public class AuxiliaryBLL
    {
        public List<AuxiliaryModel> AuxiliaryModels(AuxiliaryModel model) => VarHelper.fsql.Select<AuxiliaryModel>()
            .WhereIf(!string.IsNullOrEmpty(model.qualityPerson), a => a.qualityPerson == model.qualityPerson)
            .WhereIf(!string.IsNullOrEmpty(model.mutualPerson), a => a.mutualPerson == model.mutualPerson)
            .ToList();

        public bool AddAuxiliary(AuxiliaryModel model) => VarHelper.fsql.Insert(model).ExecuteAffrows() > 0;


        public bool UpdateAuxiliary(AuxiliaryModel model) => VarHelper.fsql.Update<AuxiliaryModel>()
            .Set(a => a.auxiliariesCode1, model.auxiliariesCode1)
            .Set(a => a.auxiliariesCode2, model.auxiliariesCode2)
            .Set(a => a.auxiliariesCode3, model.auxiliariesCode3)
            .Set(a => a.auxiliariesCode4, model.auxiliariesCode4)
            .Set(a => a.auxiliariesName1, model.auxiliariesName1)
            .Set(a => a.auxiliariesName2, model.auxiliariesName2)
            .Set(a => a.auxiliariesName3, model.auxiliariesName3)
            .Set(a => a.auxiliariesName4, model.auxiliariesName4)
            .Set(a => a.mutualPersonName, model.mutualPersonName)
            .Set(a => a.mutualPerson, model.mutualPerson)
            .Set(a => a.qualityPersonName, model.qualityPersonName)
            .Set(a => a.qualityPerson, model.qualityPerson)
            .Where(a => a.ID == model.ID)
            .ExecuteAffrows() > 0;


        public bool DeleteAuxiliary(AuxiliaryModel model) => VarHelper.fsql.Delete<AuxiliaryModel>()
            .Where(a => a.ID == model.ID)
            .ExecuteAffrows() > 0;
    }
}
