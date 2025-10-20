using MainUI.CurrencyHelper;
using MainUI.Model.StateModel;
using MainUI.TaskInformation;

namespace MainUI;
public partial class frmMainMenu : Form
{
    public UcHMI hmi = null;
    frmHardWare hard;
    [System.Runtime.InteropServices.LibraryImport("user32.dll")]
    [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
    public static partial bool ReleaseCapture();
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
    public const int WM_SYSCOMMAND = 0x0112;
    public const int SC_MOVE = 0xF010;
    public const int HTCAPTION = 0x0002;
    OpcStatusGrp opcStatus;
    public frmMainMenu()
    {
        InitializeComponent();
        timerHeartbeat.Start();
        Text = VarHelper.SoftName;
        TimerHeartbeat_Tick(null, null);
        lblTitle.Text = VarHelper.SoftName;
        CheckForIllegalCrossThreadCalls = false;
    }
    /// <summary>
    /// C#winform实现界面拖动
    /// </summary>
    private void lblTitle_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
    }
    /// <summary>
    /// 窗体加载
    /// </summary>
    private async void FrmMainMenu_Load(object sender, EventArgs e)
    {
        try
        {
            hmi = new UcHMI();
            hmi.EmergencyStatusChanged += new UcHMI.RunStatusHandler(hmi_EnmergencyStatusChanged);
            hmi.Dock = DockStyle.Fill;
            hmi.Init();
            hmi.TestStateChanged += new UcHMI.TestStateHandler(hmi_Testststechanged);
            BaseTest.TestStateChanged += BaseTest_TestStateChanged;
            opcStatus = OPCHelper.opcStatus;
            hard = new frmHardWare();
            hard.InitZeroGain();
            splitContainer1.Panel2.Controls.Add(hmi);
            RW.Components.User.BLL.UserBLL userBll = new();
            //int level = userBll.GetPermissionLevel(RW.UI.RWUser.User.Permission);
            switch (NewUsers.NewUserInfo.Permission)
            {
                case "管理员"://系统管理员
                    break;
                case "工艺员"://工程师
                    btnMainData.Visible = false;
                    break;
                case "操作员"://操作员
                    btnMainData.Visible = false;
                    btnHardwareTest.Visible = false;
                    break;
                default:
                    btnMainData.Visible = false;
                    btnHardwareTest.Visible = false;
                    break;
            }
            timerPLC.Enabled = true;
            await GetPersonnel.GetPersonnelData();
        }
        catch (Exception ex)
        {
            MessageHelper.MessageOK(this, ex.Message);
        }
    }
    private void hmi_Testststechanged(bool isTesting)
    {
        btnReports.Enabled = !isTesting;
        btnDeviceDetection.Enabled = !isTesting;
        btnHardwareTest.Enabled = !isTesting;
        btnMainData.Enabled = !isTesting;
        btnChangePwd.Enabled = !isTesting;
        btnExit.Enabled = !isTesting;
    }
    private void BaseTest_TestStateChanged(bool isTesting)
    {
        btnHardwareTest.Enabled = !isTesting;
        btnDeviceDetection.Enabled = !isTesting;
        btnMainData.Enabled = !isTesting;
        btnReports.Enabled = !isTesting;
        btnChangePwd.Enabled = !isTesting;
        btnExit.Enabled = !isTesting;
    }

    /// <summary>
    /// 显示界面时间
    /// </summary>
    private void timer1_Tick(object sender, EventArgs e)
    {
        lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    /// <summary>
    /// 急停事件
    /// </summary>
    /// <param name="obj"></param> 
    private void hmi_EnmergencyStatusChanged(bool obj)
    {
        if (!obj)
        {
            splitContainer1.Panel2.Enabled = false;
            NlogHelper.Default.Debug("急停被按下");
            picRunStatus.Image = Resources.emergent;
            btnChangePwd.Enabled = false;
            btnHardwareTest.Enabled = false;
            btnMainData.Enabled = false;
            btnReports.Enabled = false;
        }
        else
        {
            splitContainer1.Panel2.Enabled = true;
            picRunStatus.Image = Resources.noemergent;
            btnChangePwd.Enabled = true;
            btnHardwareTest.Enabled = true;
            btnMainData.Enabled = true;
            btnReports.Enabled = true;
        }
    }

    private async Task<bool> Heartbeat()
    {
        try
        {
            if (string.IsNullOrEmpty(VarHelper.deviceConfig.Authentication)) throw new Exception("设备未认证！请先认证设备");
            RestClientHelper restClient = new(VarHelper.ProductionConfig.Heartbeat);
            var resource = await restClient.GetAsync<StateModelBase>(new
            {
                deviceNumber = VarHelper.deviceConfig.Authentication,
                personCode = NewUsers.NewUserInfo.JobNumber,
            });
            return resource.state != "0";
        }
        catch (Exception ex)
        {
            NlogHelper.Default.Debug("心跳接口存在问题：", ex);
            return false;
        }

    }

    /// <summary>
    /// 硬件校准
    /// </summary>
    private void btnHardwareTest_Click(object sender, EventArgs e)
    {
        frmHardWare hard = new();
        VarHelper.ShowDialogWithOverlay(this, hard);
    }
    /// <summary>
    /// 数据管理
    /// </summary>
    private void btnMainData_Click(object sender, EventArgs e)
    {
        using (frmSettingMain main = new())
        {
            main.AddNodes("用户管理", new ucUserManager(this), 0);
            main.AddNodes("指纹管理", new ucFinger(this), 5);
            main.AddNodes("型号管理", new ucTypeManage(this), 1);
            main.AddNodes("参数管理", new ucTestParams(this), 2);
            main.AddNodes("检查人员", new ucUserSelection(this), 3);
            main.AddNodes("保护参数", new ucProtect(this), 4);
            VarHelper.ShowDialogWithOverlay(this, main);
            hmi.sRefresh();
        }
        ;
    }

    /// <summary>
    /// 历史报表
    /// </summary>
    private void btnReports_Click(object sender, EventArgs e)
    {
        frmDataManager fdm = new();
        VarHelper.ShowDialogWithOverlay(this, fdm);
    }

    /// <summary>
    /// 修改密码
    /// </summary>
    private void btnChangePwd_Click(object sender, EventArgs e)
    {
        FrmChangePwd changePwd = new();
        VarHelper.ShowDialogWithOverlay(this, changePwd);
    }
    /// <summary>
    /// 注销
    /// </summary>
    private void btnLogout_Click(object sender, EventArgs e)
    {
        Application.Restart();
    }

    /// <summary>
    /// 退出
    /// </summary>
    private void btnExit_Click(object sender, EventArgs e)
    {
        if (MessageHelper.MessageYes(this, "确定要退出试验吗？") == DialogResult.OK)
        {
            try
            {
                OPCHelper.PUBgrp[0] = 0;
                OPCHelper.PUBgrp[2] = 0;
                OPCHelper.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Application.Exit();
            }
        }
    }

    private void timerPLC_Tick(object sender, EventArgs e)
    {
        try
        {
            lblDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            tslblUser.Text = "当前登录用户：" + NewUsers.NewUserInfo.Username
                             + " 当前登录工号：" + NewUsers.NewUserInfo.JobNumber;
            //+ " 当前登录班组：" + NewUsers.NewUserInfo.depName;
            tslblPLC.Text = opcStatus.NoError ? " PLC连接正常 " : " PLC连接失败 ";
            tslblPLC.BackColor = opcStatus.NoError ? Color.FromArgb(110, 190, 40) : Color.Salmon;
            tslblHeartbeat.Text = VarHelper.NetworkState ? " 网络连接正常 " : " 网络连接错误 ";
            tslblHeartbeat.BackColor = VarHelper.NetworkState ? Color.FromArgb(110, 190, 40) : Color.Salmon;
            if (opcStatus.Simulated) tslblPLC.Text += " 仿真模式 ";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void uiImageButton1_Click(object sender, EventArgs e)
    {
        frmNLogs frmN = new();
        VarHelper.ShowDialogWithOverlay(this, frmN);
    }

    private async void TimerHeartbeat_Tick(object sender, EventArgs e)
    {
        if (VarHelper.TaskModel)
        {
            VarHelper.NetworkState = await Heartbeat();
        }
        //VarHelper.NetworkState = true;
    }

    private void btnDeviceDetection_Click(object sender, EventArgs e)
    {
        frmInformation frmInformation = new();
        VarHelper.ShowDialogWithOverlay(this, frmInformation);
    }
}
