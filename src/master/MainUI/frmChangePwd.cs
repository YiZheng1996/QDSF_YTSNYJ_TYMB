using MainUI.CurrencyHelper;
using MainUI.Model.StateModel;

namespace MainUI
{
    public partial class FrmChangePwd : UIForm
    {
        public FrmChangePwd()
        {
            InitializeComponent();
        }

        private void frmChangePwd_Load(object sender, EventArgs e)
        {
            txtJobNumber.Text = NewUsers.NewUserInfo.JobNumber;
            txtUsername.Text = NewUsers.NewUserInfo.Username;
        }

        private async void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string password = VarHelper.SHA512Encoding(NewUsers.NewUserInfo.JobNumber, txtPassword.Text.Trim());
                string newPwd1 = VarHelper.SHA512Encoding(NewUsers.NewUserInfo.JobNumber, txtNewPwd1.Text.Trim());
                string newPwd2 = VarHelper.SHA512Encoding(NewUsers.NewUserInfo.JobNumber, txtNewPwd2.Text.Trim());

                if (string.IsNullOrEmpty(password))
                {
                    MessageHelper.MessageOK(this, "密码不能为空，请重新输入！");
                    txtPassword.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(newPwd1))
                {
                    MessageHelper.MessageOK(this, "新密码不能为空，请重新输入");
                    txtNewPwd1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(newPwd2))
                {
                    MessageHelper.MessageOK(this, "确认密码不能为空，请重新输入！");
                    txtNewPwd2.Focus();
                    return;
                }
                if (newPwd1 != newPwd2)
                {
                    MessageHelper.MessageOK(this, "两次输入的密码不正确，请重新输入！");
                    txtNewPwd1.Focus();
                    return;
                }
                if (password != NewUsers.NewUserInfo.Password)
                {
                    MessageHelper.MessageOK(this, "原始密码不正确，请重新输入！");
                    txtPassword.Focus();
                    return;
                }

                OperateUserBLL bllUser = new();
                if (VarHelper.TaskModel)
                {
                    if (await OnUpdateUserPwd(password, newPwd1))
                    {
                        NewUsers.NewUserInfo.Password = newPwd1;
                        MessageHelper.MessageOK(this, "密码修改成功，重新登录后即可生效！");
                    }
                }
                else
                {
                    if (bllUser.UpdateUserPwd(NewUsers.NewUserInfo.JobNumber, newPwd1))
                    {
                        MessageHelper.MessageOK(this, "密码修改成功，重新登录后即可生效！");
                        NewUsers.NewUserInfo.Password = newPwd1;
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageHelper.MessageOK(this, "修改失败！数据库操作失败！");
                    }
                }
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("密码修改失败：", ex);
                MessageHelper.MessageOK(this, "密码修改失败：" + ex.Message);
            }
        }

        /// <summary>
        /// 在线情况下修改密码
        /// </summary>
        /// <returns></returns>
        public async Task<bool> OnUpdateUserPwd(string TxtoldPwd, string TxtnewPwd)
        {
            OperateUserBLL bllUser = new();
            if (NewUsers.NewUserInfo.Username != "admin")
            {
                if (string.IsNullOrEmpty(VarHelper.deviceConfig.Authentication)) throw new Exception("设备未认证！请先认证设备");
                HttpClientWithPolly restClient = new(VarHelper.ProductionConfig.ChangePassword);
                try
                {
                    var resource = await restClient.PostAsync<PwdStateModel>(new
                    {
                        deviceNumber = VarHelper.deviceConfig.Authentication,
                        personCode = NewUsers.NewUserInfo.JobNumber,
                        oldPwd = TxtoldPwd,
                        newPwd = TxtnewPwd
                    });

                    if (resource.state == "1")
                    {
                        if (bllUser.UpdateUserPwd(NewUsers.NewUserInfo.JobNumber, resource.newPwd))
                        {
                            MessageHelper.MessageOK(this, "密码修改成功，重新登录后即可生效！");
                            NewUsers.NewUserInfo.Password = TxtnewPwd;
                            DialogResult = DialogResult.OK;
                            return true;
                        }
                        else
                        {
                            MessageHelper.MessageOK(this, "修改失败！数据库操作失败！");
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageHelper.MessageOK(this, "修改失败：" + ex.Message);
                    return false;
                }
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}