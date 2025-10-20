using MainUI.CurrencyHelper;
using MainUI.Equip;
using MainUI.TaskInformation;
using System.Net;
using System.Net.Http;
using System.Security.Policy;

namespace MainUI
{
    public partial class UcHMI : UserControl
    {
        frmMainMenu frm = new();
        TaskManager taskManager = new();
        public delegate void RunStatusHandler(bool obj);
        public event RunStatusHandler EmergencyStatusChanged;
        ParaConfig paraconfig = null;
        Dictionary<int, AntdUI.Button> pairs = [];
        Dictionary<int, UIDigitalLabel> dicAI = [];
        Dictionary<UIRadioButton, UIPanel> DicRadioText = [];
        Dictionary<int, Procedure.Controls.SwitchPictureBox> dicDI = [];
        public delegate void TestStateHandler(bool isTesting);
        public event TestStateHandler TestStateChanged;
        string path2 = Application.StartupPath + @"reports\report.xlsx";
        string RptFilename = "";  //报表名称
        string RptFilePath = "";  //报表地址
        private static List<string> CompareTest = [];
        public UcHMI() => InitializeComponent();

        #region 初始化
        public void Init()
        {
            try
            {
                OPCHelper.Init();
                AddBtn();
                LoaddicDI();
                LoaddicAI();
                OPCHelper.PUBgrp.PUBGroupChanged += PUBgrp_PUBGroupChanged;
                OPCHelper.PUBgrp.Fresh();
                OPCHelper.AIgrp.AIvalueGrpChanged += AIgrp_AIvalueGrpChanged;
                OPCHelper.AIgrp.Fresh();
                OPCHelper.DIgrp.DIGroupChanged += DIgrp_DIGroupChanged;
                OPCHelper.DIgrp.Fresh();
                OPCHelper.Wsdgrp.WSDvalueGrpChaned += WSDgrp_WSDvalueGrpChaned;
                OPCHelper.Wsdgrp.Fresh();
                //OPCHelper.AOgrp.AOvalueGrpChaned += AOgrp_AOvalueGrpChanged;
                BaseTest.TestStateChanged += BaseTest_TestStateChanged;
                BaseTest.TipsChanged += BaseTest_TipsChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BaseTest_TipsChanged(object sender, object info)
        {
            AppendText(info.ToString());
        }

        private void BaseTest_TestStateChanged(bool isTesting)
        {
            Disable(isTesting);
            if (!isTesting)
            {
                IsTestEnd();
                BaseTest.NewTask = new();
            }
        }

        private void Disable(bool isTesting)
        {
            uiVoltageOut.Enabled = !isTesting;
            uiCurrentOut.Enabled = !isTesting;
            TimeSetting.Enabled = !isTesting;
            btnStopTest.Enabled = isTesting;
            btnStartTest.Enabled = !isTesting;
            PanelCurrent.Enabled = !isTesting;
            PanelTimeSetting.Enabled = !isTesting;
            btnProductSelection.Enabled = !isTesting;
            PanelLabVoltageSetting.Enabled = !isTesting;
            foreach (var item in DicRadioText) item.Key.Enabled = !isTesting;
            BtnTaskDownload.Enabled = !isTesting;
            BtnTaskSee.Enabled = !isTesting;
            BtnTaskUpload.Enabled = !isTesting;
        }

        /// <summary>
        /// 加载DI模块
        /// </summary>
        private void LoaddicDI()
        {
            dicDI.Clear();
            foreach (var item in grpDI.Controls)
            {
                if (item is Procedure.Controls.SwitchPictureBox)
                {
                    var sw = item as Procedure.Controls.SwitchPictureBox;
                    dicDI.Add(sw.Index, sw);
                }
            }
        }

        //加载AI模块
        private void LoaddicAI()
        {
            dicAI.Clear();
            AddAI(grpAI);
        }

        private void AddBtn()
        {
            pairs.Clear();
            pairs.Add(0, btnTechnology);
            pairs.Add(1, btnReport);
            pairs.Add(2, btnCamera01);
            pairs.Add(3, btnCamera02);
        }

        /// <summary>
        /// 递归查找
        /// </summary>
        /// <param name="con"></param>
        private void AddAI(Control con)
        {
            foreach (Control item in con.Controls)
            {
                if (item is UIDigitalLabel)
                {
                    var sp = item as UIDigitalLabel;
                    var Index = sp.Tag.ToInt32();
                    if (Index > 900) continue;
                    dicAI.Add(Index, sp);
                }
                AddAI(item);
            }
        }
        #endregion

        #region 事件
        //AI模块事件
        private void AIgrp_AIvalueGrpChanged(object sender, int index, double value)
        {
            if (dicAI.TryGetValue(index, out UIDigitalLabel Divalue))
                Divalue.Value = value;
            BtnColor(btnOnline, btnOffline, VarHelper.TaskModel);
        }
        private void AOgrp_AOvalueGrpChanged(object sender, int index, double value)
        {
            switch (index)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:
                    //uiCurrentLab2.Text = value.ToString();
                    break;

                default:
                    break;
            }
        }
        //DI模块事件
        private async void DIgrp_DIGroupChanged(object sender, int index, bool value)
        {
            try
            {
                if (dicDI.TryGetValue(index, out Procedure.Controls.SwitchPictureBox swLabel))
                {
                    swLabel.Switch = value;
                }
                switch (index)
                {
                    case 0:
                        if (!value) EndTest("急停按下");
                        EmergencyStatusChanged?.Invoke(value);
                        break;
                    case 1:
                        if (value) EndTest("接地信号断开");
                        break;
                    case 2:
                        if (value)
                            OPCHelper.PUBgrp[1] = 500; // 切换手动控制，默认保护电流为500mA
                        break;
                    case 4:
                        if (value) EndTest("升压器输入过流");
                        break;
                    case 5:
                        if (value) EndTest("保护电流过流");
                        break;
                    case 7:
                        if (!value) EndTest("操作台柜门打开");
                        break;
                    case 12:
                        if (value)
                            taskManager.StartTask("合闸语音播报");
                        else
                            await taskManager.StopTaskAsync("合闸语音播报");
                        break;
                    case 19:
                        if (!value) EndTest("试验停止信号");
                        break;
                    case 24:
                        istimeStart(value);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("DI模块事件报错：" + ex.Message);
            }
        }
        private async void istimeStart(bool value)
        {
            if (value)
            {
                Invoke(() =>
                {
                    timer1.ReStart();
                    AppendText("计时开始");
                    taskManager.StartTask("耐压试验过程结果数组");
                });
            }
            else
            {
                timer1.Stop();
                await taskManager.StopTaskAsync("耐压试验过程结果数组");
            }
        }
        private void EndTest(string txt)
        {
            IsTestEnd();
            AppendText(txt);
            NlogHelper.Default.Debug(txt);
        }
        private void WSDgrp_WSDvalueGrpChaned(object sender, int index, double value)
        {
            switch (index)
            {
                case 0:
                    LabTemperature.Value = value;
                    break;
                case 1:
                    LabHumidity.Value = value;
                    break;
                default:
                    break;
            }
        }
        private void PUBgrp_PUBGroupChanged(object sender, int index, object value)
        {
            switch (index)
            {
                case 0:
                    LabVoltageSetting.Value = value.ToDouble();
                    break;
                case 1:
                    uiCurrentLab.Value = value.ToDouble();
                    break;
                case 2:
                    LabTimeSetting.Value = value.ToDouble();
                    break;
                case 63:
                    LabTestTime.Value = value.ToDouble();
                    break;
                case 46:
                    IsTestEnd();
                    break;
                default:
                    break;
            }
            if (index >= 27 && index <= 60)
                VarHelper.DeviceDetection(frm, index, value.ToBool(), uiVoiceText);
        }
        #endregion

        #region 参数
        /// <summary>
        /// 读取配置文件，配置参数
        /// </summary>
        private void InitParaConfig()
        {
            try
            {
                if (VarHelper.mTestViewModel == null) return;
                paraconfig = new();
                paraconfig.SetSectionName(VarHelper.mTestViewModel.TypeName);
                paraconfig.Load();
                BaseTest.paraconfig = paraconfig;
                if (!string.IsNullOrEmpty(paraconfig.RptFile) && !VarHelper.TaskModel)
                {
                    rowIndex = 0;
                    rowIndex = 29;
                    RptFilename = paraconfig.RptFile;
                    RptFilePath = Path.GetFileNameWithoutExtension(RptFilename);
                    string RptPath = Application.StartupPath + "reports\\" + RptFilePath;
                    File.Copy(paraconfig.RptFile, path2, true);
                    ucGrid1.LoadFile(RptPath);
                    Manualparameters(paraconfig);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //刷新型号
        public void sRefresh()
        {
            if (string.IsNullOrEmpty(VarHelper.mTestViewModel.TypeName)) return;
            InitParaConfig();
            btnPrint.Enabled = true;
            btnSave.Enabled = true;
        }

        private void Manualparameters(ParaConfig paraconfig)
        {
            if (!VarHelper.TaskModel)
            {
                LoopVoltage1.Text = string.IsNullOrEmpty(paraconfig.Voltage1) ? null : $"{paraconfig.Voltage1}V";
                LoopVoltage2.Text = $"{paraconfig.Voltage2}V";
                LoopVoltage3.Text = $"{paraconfig.Voltage3}V";
                LoopVoltage4.Text = $"{paraconfig.Voltage4}V";
                LoopVoltage1.Tag = $"{paraconfig.Current1}";
                LoopVoltage2.Tag = $"{paraconfig.Current2}";
                LoopVoltage3.Tag = $"{paraconfig.Current3}";
                LoopVoltage4.Tag = $"{paraconfig.Current4}";
                LabTimeSetting.Value = paraconfig.TestTime.ToInt();
                DicRadioText.Clear();
                DicRadioText.Add(CheckLoop1, LoopVoltage1);
                DicRadioText.Add(CheckLoop2, LoopVoltage2);
                DicRadioText.Add(CheckLoop3, LoopVoltage3);
                DicRadioText.Add(CheckLoop4, LoopVoltage4);
                foreach (var item in DicRadioText) item.Key.Checked = false;
            }
        }

        #endregion

        #region 自动试验
        private void btnStartTest_Click(object sender, EventArgs e)
        {
            if (!OPCHelper.DIgrp[0]) { MessageHelper.MessageOK(frm, "请注意,急停情况下无法启动"); return; }
            if (!OPCHelper.DIgrp[7]) { MessageHelper.MessageOK(frm, "请注意,门限位失效情况下无法启动"); return; }
            if (OPCHelper.DIgrp[2]) { MessageHelper.MessageOK(frm, "请注意,请将手自动按钮切换到电脑控制"); return; }
            if (OPCHelper.DIgrp[1]) { MessageHelper.MessageOK(frm, "请注意,接地信号断开,无法开始试验"); return; }
            if (OPCHelper.DIgrp[4]) { MessageHelper.MessageOK(frm, "请注意,升压器输入过流,无法开始试验"); return; }
            if (OPCHelper.DIgrp[5]) { MessageHelper.MessageOK(frm, "请注意,保护电流过流,无法开始试验"); return; }

            if (!IsTestStart()) return;
            InitCurve();
            Disable(true);
            TestStateChanged?.Invoke(true);
        }

        private void btnStopTest_Click(object sender, EventArgs e) => IsTestEnd();

        private void Reportwrite()
        {
            try
            {
                if (string.IsNullOrEmpty(paraconfig?.RptFile)) return;
                ucGrid1.Write("cx", VarHelper.mTestViewModel.TypeName);
                ucGrid1.Write("ch", txtNumber.Text.Trim());
                ucGrid1.Write("syy", RW.Components.User.RWUser.Current.Username);
                ucGrid1.Write("jcy", RW.Components.User.RWUser.Current.Username);
                ucGrid1.Write("sysj", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("报表表头写值失败：", ex);
            }
        }

        private bool GetRadioButton()
        {
            foreach (var item in DicRadioText)
            {
                if (item.Key.Checked) return true;
            }
            return false;
        }

        private int GetRadioButtonIndex()
        {
            foreach (var item in DicRadioText)
            {
                if (item.Key.Checked) return item.Key.Tag.ToInt32();
            }
            return 0;
        }

        // 开始试验操作
        private bool IsTestStart()
        {
            taskManager.Hmi = this;
            BaseTest.ucGrid = ucGrid1;
            if (MessageHelper.MessageYes(frm, "试验即将开始,请确认线路是否接好！！！") != DialogResult.OK)
                return false;
            OPCHelper.DIgrp[24] = false;  //关闭计时
            OPCHelper.DIgrp[26] = false;  //试验开始标志位
            OPCHelper.DIgrp[25] = false;  //过流标志位
            if (VarHelper.TaskModel)
            {
                if (string.IsNullOrEmpty(BaseTest.NewTask?.holdItemId)) { MessageHelper.MessageOK(frm, "请先选择任务后开始试验！！！"); return false; }
                if (!VarHelper.isRedoing)
                {
                    frmUserSelection frmUser = new();
                    VarHelper.ShowDialogWithOverlay(frm, frmUser);
                    BaseTest.AuxiModel = new();
                    BaseTest.AuxiModel = frmUser.model;
                    VarHelper.isRedoing = true;
                }
                var (time, voltage) = VarHelper.GetVoltage(BaseTest.NewTask.stepContent);
                OPCHelper.PUBgrp[2] = time;     //时间
                OPCHelper.PUBgrp[0] = voltage;  //电压
                OPCHelper.PUBgrp[1] = VarHelper.GetCurrent(BaseTest.NewTask.resultStandard); //电流
                OPCHelper.PUBgrp[61] = true;  //试验开始
                taskManager.StartTask("在线试验");
                return true;
            }
            else
            {
                if (string.IsNullOrEmpty(VarHelper.mTestViewModel.ModelName)) { MessageHelper.MessageOK(frm, "请选择产品型号后开始试验"); return false; }
                if (!GetRadioButton()) { MessageHelper.MessageOK(frm, "回路未选择！"); return false; }
                Reportwrite();
                InitCurve(LabTimeSetting.Value);
                BaseTest.CheckCount = GetRadioButtonIndex();
                OPCHelper.PUBgrp[0] = LabVoltageSetting.Value; //电压
                OPCHelper.PUBgrp[1] = uiCurrentLab.Value;      //电流
                OPCHelper.PUBgrp[2] = LabTimeSetting.Value;    //时间
                OPCHelper.PUBgrp[61] = true;  //试验开始
                taskManager.StartTask("离线试验");
            }
            return true;
        }

        // 结束试验操作
        private async void IsTestEnd()
        {
            try
            {
                if (VarHelper.TaskModel)
                {
                    await taskManager.StopTaskAsync("在线试验");
                }
                else
                {
                    await taskManager.StopTaskAsync("离线试验");
                }
                OPCHelper.PUBgrp[61] = false;
                await taskManager.StopTaskAsync("耐压试验过程结果数组");
                Disable(false);
                TestStateChanged?.Invoke(false);
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error($"结束试验错误：{ex.Message}", ex);
                MessageHelper.MessageOK(frm, $"结束试验错误：{ex.Message}");
            }
        }

        #endregion

        #region 报表
        int AlturaCount = 29;
        int rowIndex = 0;
        private bool isDow = false;
        private void btnPageUp_Click(object sender, EventArgs e)
        {
            if (isDow) { rowIndex -= AlturaCount; isDow = false; }
            rowIndex -= LabelNumber.Value.ToInt32();
            ucGrid1.PageTurning(rowIndex);
        }
        private void btnPageDown_Click(object sender, EventArgs e)
        {
            if (!isDow) { rowIndex = AlturaCount; isDow = true; }
            rowIndex += LabelNumber.Value.ToInt32();
            ucGrid1.PageTurning(rowIndex);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ucGrid1.Print(filname);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("打印失败：" + ex.StackTrace);
                NlogHelper.Default.Fatal("打印失败：", ex);
            }

        }

        string filname;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("是否保存试验结果？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
                string rootPath = Application.StartupPath + @"Save\";
                if (!Directory.Exists(rootPath)) Directory.CreateDirectory(rootPath);
                filname = rootPath + VarHelper.mTestViewModel.ModelName + "_" + "" + "_" + string.Format("{0:yyyyMMddHHmmss}", DateTime.Now);
                TestRecordBLL recordbll = new();
                recordbll.SaveData(VarHelper.mTestViewModel.ModelID, VarHelper.mTestViewModel.TypeName, "", txtNumber.Text, "" + NewUsers.NewUserInfo.Username, DateTime.Now.ToString(), filname);
                ucGrid1.SaveAsPdf(filname, filname);
                MessageBox.Show("保存成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败:" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region 曲线控件
        UILineOption option;
        private void InitCurve(double Xdata = 60)
        {
            option = new();
            LineCurve.Option.Clear();
            option.XAxis.ShowGridLine = true;//横轴网格线
            option.YAxis.ShowGridLine = true;//纵轴网格线
            option.ToolTip.Visible = true; //悬浮标题
            option.XAxis.SetMaxValue(Xdata + 10);
            option.Title = new() { Text = "耐压曲线" };
            var series = option.AddSeries(new UILineSeries("泄漏电流", Color.FromArgb(232, 193, 160), true));
            series.Symbol = UILinePointSymbol.Square;
            series.SymbolSize = 1;

            var series2 = option.AddSeries(new UILineSeries("电压检测", Color.FromArgb(244, 117, 96)));
            series2.Symbol = UILinePointSymbol.Square;
            series2.SymbolSize = 1;

            option.XAxis.Name = "时间(S)";
            option.YAxis.Name = "电压检测(KV)";
            option.YAxis.SetMaxValue(16);
            option.Y2Axis.Name = "泄漏电流(mA)";
            option.Y2Axis.SetMaxValue(500);

            //坐标轴显示小数位数
            option.XAxis.AxisLabel.DecimalPlaces = 0;
            option.YAxis.AxisLabel.DecimalPlaces = 0;
            option.Y2Axis.AxisLabel.DecimalPlaces = 0;

            //图例样式
            option.Legend = new UILegend
            {
                Orient = UIOrient.Horizontal,
                Top = UITopAlignment.Top,
                Left = UILeftAlignment.Left
            };
            option.Legend.AddData("泄漏电流", Color.FromArgb(232, 193, 160));
            option.Legend.AddData("电压检测", Color.FromArgb(244, 117, 96));
            LineCurve.SetOption(option);
        }
        #endregion

        private void uiCurrent_Click(object sender, EventArgs e)
        {
            try
            {
                frmSetOutValue fs = new(Convert.ToDouble(uiCurrentLab.Value), "保护电流设定(0~500mA)", 500);
                VarHelper.ShowDialogWithOverlay(frm, fs);
                if (fs.DialogResult == DialogResult.OK)
                {
                    ControlHelper.ButtonClickAsync(sender, () =>
                    {
                        uiCurrentLab.Value = fs.OutValue;
                        OPCHelper.PUBgrp[1] = fs.OutValue;
                    });
                }
            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(frm, $"保护电流设定失败：{ex.Message}");
            }
        }

        private void uiVoltageOut_Click(object sender, EventArgs e)
        {
            try
            {
                frmSetOutValue fs = new(Convert.ToDouble(LabVoltageSetting.Value), "自定义电压设定(0~15000V)", 15000);
                VarHelper.ShowDialogWithOverlay(frm, fs);
                if (fs.DialogResult == DialogResult.OK)
                {
                    ControlHelper.ButtonClickAsync(sender, () =>
                    {
                        LabVoltageSetting.Value = fs.OutValue;
                        OPCHelper.PUBgrp[0] = fs.OutValue;
                    });
                }
            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(frm, $"自定义电压设定失败：{ex.Message}");
            }
        }

        private void TimeSetting_Click(object sender, EventArgs e)
        {
            try
            {
                frmSetOutValue fs = new(Convert.ToDouble(LabTimeSetting.Value), "试验时间设定(0~999s)", 999);

                VarHelper.ShowDialogWithOverlay(frm, fs);
                if (fs.DialogResult == DialogResult.OK)
                {
                    ControlHelper.ButtonClickAsync(sender, () =>
                    {
                        LabTimeSetting.Value = fs.OutValue;
                        OPCHelper.PUBgrp[2] = fs.OutValue;
                        option.XAxis.SetMaxValue(fs.OutValue);
                        LineCurve.Refresh();
                    });
                }
            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(frm, $"试验时间设定失败：{ex.Message}");
            }
        }

        private void UcHMI_Load(object sender, EventArgs e)
        {
            VarHelper.TaskModel = true;
            WriteBH();
            InitCurve();
            LoadControls(!VarHelper.TaskModel);
            OPCHelper.PUBgrp[62] = true;// ---手/自动，默认自动
            OPCHelper.DIgrp[24] = false;//关闭计时
        }

        void LoadControls(bool isModel)
        {
            btnStopTest.Enabled = false;
            CheckLoop1.Enabled = isModel;
            CheckLoop2.Enabled = isModel;
            CheckLoop3.Enabled = isModel;
            CheckLoop4.Enabled = isModel;
            txtNumber.Enabled = isModel;
            btnReport.Visible = isModel;
            btnProductSelection.Enabled = isModel;
            //BtnTaskDownload.Enabled = VarHelper.NetworkState;
            //BtnTaskSee.Enabled = VarHelper.NetworkState;
            //BtnTaskUpload.Enabled = VarHelper.NetworkState;
        }

        private string IPSubstring(string text)
        {
            int index = text.IndexOf('?');
            if (index >= 0)
            {
                string result = text[..index];
                return result;
            }
            return null;
        }
        // 保护参数下发
        private void WriteBH()
        {
            DeviceInspectConfig inspectConfig = new();
            OPCHelper.PUBgrp[9] = inspectConfig.EmergencyStop;
            OPCHelper.PUBgrp[10] = inspectConfig.Grounding;
            OPCHelper.PUBgrp[11] = inspectConfig.ElectricBell;
            OPCHelper.PUBgrp[12] = inspectConfig.Interlock;
            OPCHelper.PUBgrp[13] = inspectConfig.LowerLimit;
            OPCHelper.PUBgrp[14] = inspectConfig.HighLimit;
            OPCHelper.PUBgrp[15] = inspectConfig.ElectricalMachinery;
            OPCHelper.PUBgrp[16] = inspectConfig.MainContact;
            OPCHelper.PUBgrp[17] = inspectConfig.FromContact;
            OPCHelper.PUBgrp[18] = inspectConfig.Discharge;
            OPCHelper.PUBgrp[19] = inspectConfig.DoorLock;
            OPCHelper.PUBgrp[20] = inspectConfig.Start;
            OPCHelper.PUBgrp[21] = inspectConfig.Boost;
            OPCHelper.PUBgrp[22] = inspectConfig.StepDown;
            OPCHelper.PUBgrp[23] = inspectConfig.Stop;
            OPCHelper.PUBgrp[24] = inspectConfig.Reset;
            OPCHelper.PUBgrp[25] = inspectConfig.TimeBtn;
            OPCHelper.PUBgrp[26] = inspectConfig.TimerWare;
        }

        private void AppendText(string text)
        {
            txtTestRecord.AppendText($"{DateTime.Now:HH:mm:ss}：{text}\n");
            txtTestRecord.ScrollToCaret();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var time = OPCHelper.PUBgrp[63].ToDouble();
            var current = OPCHelper.PUBgrp[6].ToDouble();
            var voltage = OPCHelper.PUBgrp[5].ToDouble() / 1000;
            LineCurve.Option.AddData("泄漏电流", time, current);
            LineCurve.Option.AddData("电压检测", time, voltage);
            LineCurve.Refresh();
        }

        #region 信息接口

        private async void BtnTaskDownload_Click(object sender, EventArgs e)
        {
            try
            {
                // 禁用按钮
                BtnTaskDownload.Enabled = false;

                // 第一步: 先获取任务列表数据
                TaskDownload task = new(frm);

                AppendText("正在获取任务列表...");
                NlogHelper.Default.Info("开始获取任务列表");

                // 调用API获取任务数据
                var taskData = await task.GetMainTaskList();

                // 第二步: 检查是否有数据
                if (taskData == null)
                {
                    MessageHelper.MessageOK(frm, "获取任务列表失败!");
                    AppendText("任务列表获取失败");
                    return;
                }

                if (taskData.list == null || taskData.list.Count == 0)
                {
                    MessageHelper.MessageOK(frm, "没有可下载的任务!");
                    AppendText("没有可下载的任务");
                    return;
                }

                AppendText($"获取到 {taskData.list.Count} 个主任务");
                NlogHelper.Default.Info($"成功获取任务列表,共 {taskData.list.Count} 个主任务");

                // 第三步: 只有在有数据的情况下才打开选择界面
                FrmTaskSelectDownload frmSelectTask = new(taskData);
                VarHelper.ShowDialogWithOverlay(frm, frmSelectTask);

                // 第四步: 处理用户选择结果
                if (frmSelectTask.DialogResult == DialogResult.OK)
                {
                    // 用户点击了确认下载,数据已经在对话框中保存到数据库
                    int count = frmSelectTask.SelectedTasks?.Count ?? 0;
                    AppendText($"任务下载完成!共下载 {count} 个任务");
                    MessageHelper.MessageOK(frm, $"任务下载完成!共下载 {count} 个任务");
                    NlogHelper.Default.Info($"任务下载完成,共下载 {count} 个任务");
                }
                else
                {
                    // 用户取消了下载
                    AppendText("取消任务下载");
                    NlogHelper.Default.Info("用户取消了任务下载");
                }
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("任务下载失败:", ex);
                MessageHelper.MessageOK(frm, "任务下载失败:" + ex.Message);
                AppendText($"任务下载失败: {ex.Message}");
            }
            finally
            {
                // 恢复按钮(无论成功失败都会执行)
                BtnTaskDownload.Enabled = true;
            }
        }

        private void BtnTaskSee_Click(object sender, EventArgs e)
        {
            TaskView taskView = new();
            VarHelper.ShowDialogWithOverlay(frm, taskView);
            BaseTest.NewTask = new();
            BaseTest.NewTask = taskView.NewTask;
            if (string.IsNullOrEmpty(BaseTest.NewTask.stepName))
                AppendText($"取消了任务选择");
            else
                AppendText($"选择了[{BaseTest.NewTask.stepName}]任务");
        }

        private void BtnTaskUpload_Click(object sender, EventArgs e)
        {
            FrmUpload frmUpload = new();
            VarHelper.ShowDialogWithOverlay(frm, frmUpload);
        }

        // 绝缘电阻测试仪
        private void BtnInsulationTest_Click(object sender, EventArgs e)
        {
            FrmTH2683A frmTest = new();
            VarHelper.ShowDialogWithOverlay(frm, frmTest);
        }

        private void BtnTaskImport_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void BtnColor(int index)
        {
            foreach (var item in pairs)
            {
                if (item.Key == index)
                {
                    item.Value.ForeColor = Color.FromArgb(235, 227, 221);
                }
                else
                {
                    item.Value.ForeColor = Color.FromArgb(128, 128, 128);
                }
            }
        }

        private void btnTechnology_Click(object sender, EventArgs e)
        {
            tabs1.SelectedIndex = 0;
            BtnColor(tabs1.SelectedIndex);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            tabs1.SelectedIndex = 1;
            BtnColor(tabs1.SelectedIndex);
        }

        private void plus_Click(object sender, EventArgs e)
        {
            LabelNumber.Value += 5;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            LabelNumber.Value -= 5;
            if (LabelNumber.Value < 5) LabelNumber.Value = 5;
        }

        private void btnProductSelection_Click(object sender, EventArgs e)
        {
            frmSpec frmSpec = new();
            VarHelper.ShowDialogWithOverlay(frm, frmSpec);
            if (frmSpec.DialogResult == DialogResult.OK)
            {
                txtModel.Text = VarHelper.mTestViewModel.TypeName;
                sRefresh();
            }
        }

        private void CheckLoop1_CheckedChanged(object sender, EventArgs e)
        {
            var checkRad = sender as UIRadioButton;
            if (DicRadioText.TryGetValue(checkRad, out UIPanel value))
            {
                if (string.IsNullOrEmpty(value.Text)) return;
                uiCurrentLab.Value = value.Tag.ToDouble();
                LabVoltageSetting.Value = value.Text.Replace('V', ' ').ToDouble();
            }
        }

        private void btnCamera01_Click(object sender, EventArgs e)
        {
            tabs1.SelectedIndex = 2;
            BtnColor(tabs1.SelectedIndex);
        }

        private void btnCamera02_Click(object sender, EventArgs e)
        {
            tabs1.SelectedIndex = 3;
            BtnColor(tabs1.SelectedIndex);
        }

        private void btnCameraInt01_Click(object sender, EventArgs e)
        {
            try
            {
                string textIP = @"http://192.168.1.100";
                browser1 = new();
                panelCamera01.Controls.Clear();
                panelCamera01.Controls.Add(browser1);
                //browser1.ScriptErrorsSuppressed = true; //禁止弹出脚本错误窗口
                browser1.Dock = DockStyle.Fill;
                browser1.DocumentCompleted += Browser1_DocumentCompleted;
                browser1.Url = new Uri(textIP);
            }
            catch (WebException)
            {
                MessageBox.Show("未连接监控设备，请检查：\r\n1、摄像头是否开启.\r\n2、设备已连接局域网！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(frm, "打开监控一失败：" + ex.Message);
            }
        }

        private void btnColose01_Click(object sender, EventArgs e)
        {
            if (browser1 != null)
            {
                browser1.Dispose(); // 释放所有资源并关闭
                browser1 = null;
            }
        }

        private void btnCameraInt02_Click(object sender, EventArgs e)
        {
            try
            {
                string textIP = @"http://192.168.1.104";
                browser2 = new();
                panelCamera02.Controls.Clear();
                panelCamera02.Controls.Add(browser2);
                //browser2.ScriptErrorsSuppressed = true; //禁止弹出脚本错误窗口
                browser2.DocumentCompleted += Browser2_DocumentCompleted;
                browser2.Dock = DockStyle.Fill;
                browser2.Url = new Uri(textIP);
            }
            catch (WebException)
            {
                MessageBox.Show("未连接监控设备，请检查：\r\n1、摄像头是否开启.\r\n2、设备已连接局域网！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageHelper.MessageOK(frm, "打开监控二失败：" + ex.Message);
            }
        }

        private void btnColose02_Click(object sender, EventArgs e)
        {
            if (browser2 != null)
            {
                browser2.Dispose(); // 释放所有资源并关闭
                browser2 = null;
            }
        }

        WebBrowser browser2, browser1;
        private void Browser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (IPSubstring(browser1.Url.ToString()) == @"http://192.168.1.102/doc/page/login.asp")
            {
                if (browser1.ReadyState == WebBrowserReadyState.Complete)
                {
                    var document = browser1.Document;
                    if (document != null)
                    {
                        // 找到用户名输入框并设置值
                        var usernameElement = document.GetElementById("UserName");
                        usernameElement?.SetAttribute("value", "admin");
                        // 找到密码输入框并设置值
                        var passwordElement = document.GetElementById("Password");
                        passwordElement?.SetAttribute("value", "Rw24031.");
                        // 找到登录按钮并点击
                        var loginButton = document.GetElementById("btn_submit");
                        loginButton?.InvokeMember("click");
                    }
                }
            }
        }

        private void Browser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (IPSubstring(browser2.Url.ToString()) == @"http://192.168.1.104/doc/page/login.asp")
            {
                browser2.Document.GetElementById("username").SetAttribute("value", "admin");
                browser2.Document.GetElementById("password").SetAttribute("value", "Rw24031.");
                Thread.Sleep(100);
                HtmlElement ele = browser2.Document.CreateElement("script");
                ele.SetAttribute("type", "text/javascript");
                ele.SetAttribute("text", "setTimeout(function(){login();},50)");
                browser2.Document.Body.AppendChild(ele);
            }
        }

        private void btnOnline_Click(object sender, EventArgs e)
        {
            VarHelper.TaskModel = true;
            LoadControls(!VarHelper.TaskModel);
            BtnColor(btnOnline, btnOffline, VarHelper.TaskModel);
        }

        private void btnOffline_Click(object sender, EventArgs e)
        {
            VarHelper.TaskModel = false;
            LoadControls(!VarHelper.TaskModel);
            BtnColor(btnOnline, btnOffline, VarHelper.TaskModel);
        }

        private void BtnColor(UIButton btn, UIButton btn2, bool value)
        {
            Color trueColor = Color.FromArgb(82, 196, 26);
            Color falseColor = Color.FromArgb(70, 75, 85);
            btn.FillColor = btn.FillColor2 = btn.RectColor = btn.RectDisableColor = btn.FillDisableColor = btn.FillHoverColor = btn.FillPressColor = value ? trueColor : falseColor;
            btn2.FillColor = btn2.FillColor2 = btn2.RectColor = btn2.RectDisableColor = btn2.FillDisableColor = btn2.FillHoverColor = btn2.FillPressColor = !value ? trueColor : falseColor;
        }

    }
}