using MainUI.CurrencyHelper;
using MainUI.Model.StateModel;

namespace MainUI.TaskInformation
{
    internal class GetPersonnel
    {
        public static async Task<bool> GetPersonnelData()
        {
            try
            {
                if (string.IsNullOrEmpty(VarHelper.deviceConfig.Authentication)) throw new Exception("设备未认证！请先认证设备");
                OperateUserBLL bLL = new();
                RestClientHelper restClient = new(VarHelper.ProductionConfig.personnel);
                var resource = await restClient.GetAsync<UserStateModel>(new
                {
                    deviceNumber = VarHelper.deviceConfig.Authentication,
                    personCode = NewUsers.NewUserInfo.JobNumber,
                });
                if (resource != null)
                {
                    for (int i = 0; i < resource.list.Count; i++)
                    {
                        bLL.ModifyOrAddUserTable(new OperateUserModel
                        {
                            JobNumber = resource.list[i].personCode,
                            Username = resource.list[i].personName,
                            Password = resource.list[i].password,
                            depId = resource.list[i].depId,
                            depName = resource.list[i].depName,
                            Permission = "操作员",
                        });
                    }
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("人员同步出错：", ex);
                return false;
            }
        }
    }
}
