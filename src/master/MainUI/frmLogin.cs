using MainUI.CurrencyHelper;
using MainUI.TaskInformation;
using RW.EventLog;

namespace MainUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        ucFinger finger = new();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        //public 
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            FingerprInt();
            txtJobNumber.Focus();
            btnAuthentication.Visible = VarHelper.deviceConfig.isAuthentication == "是";
        }

        private void FingerprInt()
        {
            try
            {
                //初始化指纹仪：
                int rst = new ucFinger().Init();
                if (rst == 0)
                {
                    lblMessage.Text = "指纹仪初始化完毕，请按指纹";
                    //VarHelper.speech.Speak("指纹仪初始化完毕，请按指纹");
                }
                if (rst != 0)
                {
                    lblMessage.Text = "指纹仪初始化失败，请使用密码登录";
                    //VarHelper.speech.Speak("指纹仪初始化失败，请使用密码登录！");
                    return;
                }
                // 打开
                finger.Open();
                Thread.Sleep(100);
                //加内存
                finger.LoadFingerToMemory();
                Thread.Sleep(100);
                //启动登录指纹扫描线程，比对
                finger.ThreadFingerLogin();
                //监控指纹匹配返回信息
                finger.LoginChanged += new ucFinger.LoginHandler(finger_LoginChanged);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("指纹仪初始化失败：" + ex.Message);
                //VarHelper.speech.Speak("初始化失败！");
                lblMessage.Text = "初始化失败！";
                finger.bIsTimeToDie = false; //重新启动指纹对比
            }
        }

        void finger_LoginChanged(int userid)
        {
            try
            {
                //指纹匹配失败。 返回-1，
                //指纹匹配成功。返回用户ID。
                if (userid != -1)
                {
                    OperateUserBLL bLL = new();
                    //用户权限赋值；
                    var user = bLL.SelectUser(new OperateUserModel { ID = userid });
                    if (user != null) NewUsers.NewUserInfo.InitUser(user);
                    IsFingerLogin = true;
                    Invoke(() =>
                    {
                        txtJobNumber.Text = NewUsers.NewUserInfo.JobNumber;
                        txtPassword.Text = NewUsers.NewUserInfo.Password;
                        LogOn();
                    });
                }
                else
                {
                    Invoke(() =>
                    {
                        lblMessage.Text = "指纹登录失败，请先录入指纹，已录入则请重按指纹！";
                        //VarHelper.speech.Speak("指纹登录失败，请先录入指纹，已录入则请重按指纹！");
                        finger.bIsTimeToDie = false; //重新启动指纹对比 
                    });
                }
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("指纹登录失败：" + ex);
                //VarHelper.speech.Speak("指纹登录失败，请先录入指纹，已录入则请重按指纹！");
                lblMessage.Text = "指纹登录失败，请先录入指纹，已录入则请重按指纹！";
                finger.bIsTimeToDie = false; //重新启动指纹对比
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool IsFingerLogin = false; //是否为指纹登录
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            IsFingerLogin = false;
            LogOn();
        }

        private void LogOn()
        {
            OperateUserBLL bLL = new();
            string jobNumber = txtJobNumber.Text.Trim();
            string password = string.Empty;
            if (!IsFingerLogin)
            {
                password = VarHelper.SHA512Encoding(jobNumber, txtPassword.Text.Trim());
            }
            else
            {
                password = txtPassword.Text.Trim();
            }

            if (string.IsNullOrEmpty(jobNumber))
            {
                lblMessage.Text = "请输入要登录的工号!";
                lblMessage.Visible = true;
                txtJobNumber.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "密码不能为空，请重新输入!";
                lblMessage.Visible = true;
                txtPassword.Focus();
                return;
            }

            var DataCount = bLL.SelectUserID(jobNumber);
            if (DataCount == null)
            {
                lblMessage.Text = "工号不存在，请重新输入!";
                lblMessage.Visible = true;
                txtPassword.Focus();
                return;
            }

            var user = bLL.SelectUser(new OperateUserModel { ID = DataCount.ID });
            if (user != null)
            {
                if (user.Password != password)
                {
                    lblMessage.Text = "密码错误，请重新输入!";
                    lblMessage.Visible = true;
                    txtPassword.Focus();
                    return;
                }
                else
                {
                    finger.bIsTimeToDie = true; // 停止登录扫描指纹线程
                    NewUsers.NewUserInfo.InitUser(user);
                    EventLogHelper.Log(EventLogType.Normal, "工号" + NewUsers.NewUserInfo.JobNumber + "登录。");
                    DialogResult = DialogResult.OK;
                    Close();
                    finger.CloseFinger();
                }
            }
            else
            {
                lblMessage.Text = "未找到该用户!";
                lblMessage.Visible = true;
                return;
            }
        }

        private void btnAuthentication_Click(object sender, EventArgs e)
        {
            frmAuthentication frm = new();
            frm.ShowDialog();
        }

    }
}