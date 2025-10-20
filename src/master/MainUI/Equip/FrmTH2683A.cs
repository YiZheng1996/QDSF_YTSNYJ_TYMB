using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MainUI.Equip
{
    public partial class FrmTH2683A : UIForm
    {
        private int testDuration; // 测试持续时间(秒)
        private int elapsedTime;  // 已经过时间(秒)
        private bool isTesting = false;
        private CancellationTokenSource cancellationTokenSource;

        public FrmTH2683A()
        {
            InitializeComponent();
        }

        private void FrmTH2683A_Load(object sender, EventArgs e)
        {
            // 初始化串口下拉列表
            LoadComPorts();

            // 初始化控件状态
            btnStopTest.Enabled = false;
            btnStartTest.Enabled = false;
            grpParams.Enabled = false;

            // 设置默认值
            lblElapsedTimeValue.Text = "00:00:00";
            txtTestResult.Text = "";
            txtResistanceValue.Text = "";
            txtTestConclusion.Text = "";
        }

        /// <summary>
        /// 加载可用串口列表
        /// </summary>
        private void LoadComPorts()
        {
            try
            {
                cmbComPort.Items.Clear();
                string[] ports = SerialPort.GetPortNames();

                if (ports.Length > 0)
                {
                    foreach (string port in ports)
                    {
                        cmbComPort.Items.Add(port);
                    }
                    cmbComPort.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("未检测到可用串口!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载串口列表失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 连接串口
        /// </summary>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbComPort.SelectedItem == null)
                {
                    MessageBox.Show("请选择串口!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string portName = cmbComPort.SelectedItem.ToString();

                // 初始化串口
                if (TH2683A._serialPort2683AB == null)
                {
                    TH2683A._serialPort2683AB = new SerialPort();
                }

                if (TH2683A._serialPort2683AB.IsOpen)
                {
                    TH2683A._serialPort2683AB.Close();
                }

                // 配置串口参数(根据TH2683A手册配置)
                TH2683A._serialPort2683AB.PortName = portName;
                TH2683A._serialPort2683AB.BaudRate = 9600;  // 根据实际设备调整
                TH2683A._serialPort2683AB.DataBits = 8;
                TH2683A._serialPort2683AB.StopBits = StopBits.One;
                TH2683A._serialPort2683AB.Parity = Parity.None;
                TH2683A._serialPort2683AB.ReadTimeout = 5000;
                TH2683A._serialPort2683AB.WriteTimeout = 5000;

                // 测试通讯
                string result = TH2683A.IsComConnect();

                if (!string.IsNullOrEmpty(result) && result != "通讯失败" && result != "串口打开失败")
                {
                    lblConnectionStatus.Text = "已连接";
                    lblConnectionStatus.ForeColor = System.Drawing.Color.Green;
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;
                    cmbComPort.Enabled = false;
                    btnStartTest.Enabled = true;
                    grpParams.Enabled = true;

                    MessageBox.Show($"连接成功!\n设备信息: {result}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lblConnectionStatus.Text = "连接失败";
                    lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show($"通讯测试失败: {result}\n请检查:\n1. 串口连接是否正常\n2. 设备是否开机\n3. 串口参数是否正确",
                        "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (TH2683A._serialPort2683AB.IsOpen)
                    {
                        TH2683A._serialPort2683AB.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"连接失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblConnectionStatus.Text = "未连接";
                lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        /// <summary>
        /// 断开串口连接
        /// </summary>
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (isTesting)
                {
                    MessageBox.Show("测试进行中,请先停止测试!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (TH2683A._serialPort2683AB != null && TH2683A._serialPort2683AB.IsOpen)
                {
                    TH2683A._serialPort2683AB.Close();
                }

                lblConnectionStatus.Text = "未连接";
                lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = false;
                cmbComPort.Enabled = true;
                btnStartTest.Enabled = false;
                grpParams.Enabled = false;

                MessageBox.Show("已断开连接", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"断开连接失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 开始测试
        /// </summary>
        private async void btnStartTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (TH2683A._serialPort2683AB == null || !TH2683A._serialPort2683AB.IsOpen)
                {
                    MessageBox.Show("请先连接设备!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 获取测试参数
                string voltage = numTestVoltage.Value.ToString();
                string time = numTestTime.Value.ToString();
                double resistanceLimit = (double)numResistanceLimit.Value;

                // 设置控件状态
                btnStartTest.Enabled = false;
                btnStopTest.Enabled = true;
                grpParams.Enabled = false;
                btnDisconnect.Enabled = false;
                isTesting = true;

                // 清空上次结果
                txtTestResult.Text = "准备测试...";
                txtResistanceValue.Text = "";
                txtTestConclusion.Text = "";

                testDuration = (int)numTestTime.Value;
                elapsedTime = testDuration;
                UpdateTimerDisplay();

                cancellationTokenSource = new CancellationTokenSource();

                // 异步执行测试
                await Task.Run(() => PerformTest(voltage, time, resistanceLimit, cancellationTokenSource.Token));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"开始测试失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetUI();
            }
        }

        /// <summary>
        /// 执行测试
        /// </summary>
        private void PerformTest(string voltage, string time, double resistanceLimit, CancellationToken token)
        {
            try
            {
                // 更新状态
                this.Invoke(new Action(() => {
                    txtTestResult.Text = "正在配置测试参数...";
                }));

                // 发送测试命令
                TH2683A.TH2683B_Test(voltage, time);

                // 更新状态
                this.Invoke(new Action(() => {
                    txtTestResult.Text = "测试中...";
                    timerTest.Start();
                }));

                // 等待测试完成,使用改进的状态查询方式
                bool testComplete = false;
                int timeout = 0;
                int maxTimeout = (int)(numTestTime.Value + 10) * 1000; // 测试时间 + 10秒余量

                while (!testComplete && timeout < maxTimeout && !token.IsCancellationRequested)
                {
                    Thread.Sleep(1000);
                    timeout += 1000;

                    try
                    {
                        // 查询测试状态
                        if (TH2683A._serialPort2683AB.IsOpen)
                        {
                            TH2683A._serialPort2683AB.DiscardInBuffer();
                            TH2683A._serialPort2683AB.DiscardOutBuffer();
                            Thread.Sleep(50);
                            TH2683A._serialPort2683AB.WriteLine("SYSTem:STATus?");
                            Thread.Sleep(500);
                            string status = TH2683A._serialPort2683AB.ReadExisting();

                            if (status.Contains("test complete"))
                            {
                                testComplete = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"查询状态异常: {ex.Message}");
                    }
                }

                if (token.IsCancellationRequested)
                {
                    this.Invoke(new Action(() => {
                        txtTestResult.Text = "测试已取消";
                        timerTest.Stop();
                        ResetUI();
                    }));
                    return;
                }

                if (!testComplete)
                {
                    this.Invoke(new Action(() => {
                        txtTestResult.Text = "测试超时";
                        timerTest.Stop();
                        MessageBox.Show("测试超时,请检查设备状态!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ResetUI();
                    }));
                    return;
                }

                // 读取测试结果
                string resistanceValue = TH2683A.TH2683B_ReadData();

                // 更新UI显示结果
                this.Invoke(new Action(() => {
                    timerTest.Stop();
                    txtTestResult.Text = "测试完成";

                    if (!string.IsNullOrEmpty(resistanceValue) && double.TryParse(resistanceValue, out double resistance))
                    {
                        txtResistanceValue.Text = $"{resistanceValue} MΩ";

                        // 判断结果
                        if (resistance >= resistanceLimit)
                        {
                            txtTestConclusion.Text = "合格 - PASS";
                            txtTestConclusion.ForeColor = System.Drawing.Color.Green;
                            txtTestConclusion.Font = new System.Drawing.Font(txtTestConclusion.Font, System.Drawing.FontStyle.Bold);
                        }
                        else
                        {
                            txtTestConclusion.Text = "不合格 - FAIL";
                            txtTestConclusion.ForeColor = System.Drawing.Color.Red;
                            txtTestConclusion.Font = new System.Drawing.Font(txtTestConclusion.Font, System.Drawing.FontStyle.Bold);
                        }
                    }
                    else
                    {
                        txtResistanceValue.Text = "读取失败";
                        txtTestConclusion.Text = "测试异常";
                        txtTestConclusion.ForeColor = System.Drawing.Color.Orange;
                        MessageBox.Show($"读取数据失败: {resistanceValue}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ResetUI();
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => {
                    timerTest.Stop();
                    txtTestResult.Text = "测试异常";
                    MessageBox.Show($"测试过程异常: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ResetUI();
                }));
            }
        }

        /// <summary>
        /// 停止测试
        /// </summary>
        private void btnStopTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定要停止测试吗?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // 取消测试任务
                    cancellationTokenSource?.Cancel();

                    // 停止计时器
                    timerTest.Stop();

                    // 发送停止命令
                    Task.Run(() => {
                        try
                        {
                            TH2683A.TestStop();
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"停止测试异常: {ex.Message}");
                        }
                    });

                    txtTestResult.Text = "测试已停止";
                    ResetUI();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"停止测试失败: {ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 定时器更新
        /// </summary>
        private void timerTest_Tick(object sender, EventArgs e)
        {
            if (elapsedTime > 0)
            {
                elapsedTime--;
                UpdateTimerDisplay();
            }
        }

        /// <summary>
        /// 更新计时显示
        /// </summary>
        private void UpdateTimerDisplay()
        {
            int hours = elapsedTime / 3600;
            int minutes = (elapsedTime % 3600) / 60;
            int seconds = elapsedTime % 60;
            lblElapsedTimeValue.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
        }

        /// <summary>
        /// 重置UI状态
        /// </summary>
        private void ResetUI()
        {
            isTesting = false;
            btnStartTest.Enabled = true;
            btnStopTest.Enabled = false;
            grpParams.Enabled = true;
            btnDisconnect.Enabled = true;
            elapsedTime = 0;
            UpdateTimerDisplay();
        }

        /// <summary>
        /// 窗体关闭事件
        /// </summary>
        private void FrmTH2683A_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (isTesting)
                {
                    if (MessageBox.Show("测试正在进行中,确定要关闭吗?", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }

                    cancellationTokenSource?.Cancel();
                    timerTest.Stop();
                }

                // 关闭串口
                if (TH2683A._serialPort2683AB != null && TH2683A._serialPort2683AB.IsOpen)
                {
                    TH2683A._serialPort2683AB.Close();
                    TH2683A._serialPort2683AB.Dispose();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"关闭窗体异常: {ex.Message}");
            }
        }
    }
}