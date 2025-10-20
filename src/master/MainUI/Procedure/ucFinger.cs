using libzkfpcsharp;
using MainUI.CurrencyHelper;
using System.Runtime.InteropServices;

namespace MainUI.Procedure
{
    public partial class ucFinger : ucBaseManagerUI
    {
        public bool bIsTimeToDie = false;
        bool IsRegister = false;
        int RegisterCount = 0;
        public IntPtr mDevHandle = IntPtr.Zero;
        public IntPtr mDBHandle = IntPtr.Zero;
        public IntPtr FormHandle = IntPtr.Zero;
        int cbCapTmp = 2048;
        int cbRegTmp = 0;
        int iFid = 1;
        byte[][] RegTmps = new byte[3][];
        byte[] RegTmp = new byte[2048];
        public byte[] CapTmp = new byte[2048];
        private int mfpWidth = 0;
        private int mfpHeight = 0;
        byte[] FPBuffer;
        const int MESSAGE_CAPTURED_OK = 0x0400 + 6;
        const int REGISTER_FINGER_COUNT = 3;
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        RW.Components.User.BLL.UserBLL bllUser = null;
        private OperateUserBLL bLL = new();
        public ucFinger()
        {
            InitializeComponent();
        }
        private Form form { get; }
        public ucFinger(Form form)
        {
            this.form = form;
            InitializeComponent();
        }
        private void ucFinger_Load(object sender, EventArgs e)
        {
            //注册参数设置界面的关闭事件，关闭时释放指纹仪资源。
            if (ParentForm != null)
                ParentForm.FormClosed += new FormClosedEventHandler(ParentForm_FormClosed);
            FormHandle = Handle;
            LoadUserInfo();
            int rst = -1;
            rst = Init();
            if (rst != 0)
            {
                return;
            }
            Open();
            ThreadFingerRegister();
        }
        void ParentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.CloseFinger();
        }
        /// <summary>
        /// 进行初始化库
        /// </summary>
        public int Init()
        {
            int ret = zkfperrdef.ZKFP_ERR_OK;
            if ((ret = zkfp2.Init()) == zkfperrdef.ZKFP_ERR_OK)
            {
                textRes.Text += "初始化成功！";
            }
            else
            {
                textRes.Text += "Initialize fail, ret=" + Msg(ret) + "!";
            }
            return ret;
        }
        /// <summary>
        /// 绑定用户下拉框
        /// </summary>
        private void LoadUserInfo()
        {
            bllUser = new();
            var ds = bLL.GetUsers();
            cboUsername.DataSource = ds;
            cboUsername.DisplayMember = "Username";
            cboUsername.ValueMember = "ID";
        }
        private void ThreadFingerRegister()
        {
            Thread captureThread = new(new ThreadStart(DoCapture))
            {
                IsBackground = true
            };
            captureThread.Start();
        }
        private void DoCapture()
        {
            while (!bIsTimeToDie)
            {
                cbCapTmp = 2048;
                int ret = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
                if (ret == zkfp.ZKFP_ERR_OK)
                {
                    SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero);
                }
                Thread.Sleep(200);
            }
        }
        /// <summary>
        /// 打开连接
        /// </summary>
        public void Open()
        {
            int ret = zkfp.ZKFP_ERR_OK;
            //连接设备OpenDevice(填写指纹器数量索引从0开始（设备索引(0~n,n 为设备数-1)）)
            if (IntPtr.Zero == (mDevHandle = zkfp2.OpenDevice(0)))
            {
                MessageBox.Show("OpenDevice fail " + " \n (OpenDevice失败)");
                return;
            }
            if (IntPtr.Zero == (mDBHandle = zkfp2.DBInit()))
            {
                MessageBox.Show("Init DB fail " + " \n (初始化数据库失败)");
                zkfp2.CloseDevice(mDevHandle);
                mDevHandle = IntPtr.Zero;
                return;
            }
            RegisterCount = 0;
            cbRegTmp = 0;
            iFid = 1;
            for (int i = 0; i < 3; i++)
            {
                RegTmps[i] = new byte[2048];
            }
            byte[] paramValue = new byte[4];
            int size = 4;
            zkfp2.GetParameters(mDevHandle, 1, paramValue, ref size);
            zkfp2.ByteArray2Int(paramValue, ref mfpWidth);
            size = 4;
            zkfp2.GetParameters(mDevHandle, 2, paramValue, ref size);
            zkfp2.ByteArray2Int(paramValue, ref mfpHeight);
            FPBuffer = new byte[mfpWidth * mfpHeight];
            bIsTimeToDie = false;
            textRes.Text += "\r\nOpen succ " + " \n (连接成功)";
        }
        /// <summary>
        /// 关闭设备
        /// </summary>
        public void CloseFinger()
        {
            bIsTimeToDie = true;
            RegisterCount = 0;
            Thread.Sleep(100);
            zkfp2.CloseDevice(mDevHandle);
            Thread.Sleep(100);
            zkfp2.Terminate();
        }

        /// <summary>
        /// 消息返回
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string Msg(int num)
        {
            if (num == 1)
            {
                return "已经初始化";
            }
            else if (num == 0)
            {
                return "操作成功";
            }
            else if (num == -1)
            {
                return "初始化算法库失败";
            }
            else if (num == -2)
            {
                return "初始化采集库失败";
            }
            else if (num == -3)
            {
                return "无设备连接";
            }
            else if (num == -4)
            {
                return "接口暂不支持";
            }
            else if (num == -5)
            {
                return "无效参数";
            }
            else if (num == -6)
            {
                return "打开设备失败";
            }
            else if (num == -7)
            {
                return "无效句柄";
            }
            else if (num == -8)
            {
                return "取像失败";
            }
            else if (num == -9)
            {
                return "提取指纹模板失败";
            }
            else if (num == -10)
            {
                return "中断";
            }
            else if (num == -11)
            {
                return "内存不足";
            }
            else if (num == -12)
            {
                return "当前正在采集";
            }
            else if (num == -13)
            {
                return "添加指纹模板失败";
            }
            else if (num == -14)
            {
                return "删除指纹失败";
            }
            else if (num == -17)
            {
                return "操作失败";
            }
            else if (num == -18)
            {
                return "取消采集";
            }
            else if (num == -20)
            {
                return "比对指纹失败";
            }
            else if (num == -22)
            {
                return "合并登记指纹模板失败";
            }
            else if (num == -23)
            {
                return "设备未打开";
            }
            else if (num == -24)
            {
                return "未初始化";
            }
            else if (num == -25)
            {
                return "设备已打开";
            }
            return "";
        }

        private void btnAddFinger_Click(object sender, EventArgs e)
        {
            if (!IsRegister)
            {
                IsRegister = true;
                RegisterCount = 0;
                cbRegTmp = 0;
                textRes.Text = "Please press your finger 3 times! " + " \n (请按你的手指3次!)";
            }
        }

        private void btnDelFinger_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboUsername.SelectedValue == null)
                {
                    MessageBox.Show("请先选择需要删除指纹的用户。");
                    return;
                }
                string userID = cboUsername.SelectedValue.ToString();
                int rst = deleteFinger(userID);
                textRes.Text = "删除指纹成功！";

            }
            catch (Exception ex)
            {
                string err = "删除指纹出错，" + ex.Message;
                MessageBox.Show(err);
            }
        }

        TestZhiwenBLL zw = new();
        public int deleteFinger(string userID)
        {
            DataTable dt = zw.GetFingerByUserID(userID);
            if (dt == null)
                return 0;
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("当前用户没有录入指纹信息!");
                return 0;
            }
            int ret = zw.Del(userID);
            LoadFingerToMemory();
            return ret;
        }
        /// <summary>
        /// 内存中指纹编号，用户ID
        /// </summary>
        Dictionary<int, int> dicUserID = [];
        /// <summary>
        /// 将数据库中的指纹信息写入内存，为了与录入的指纹匹配
        /// </summary>
        public void LoadFingerToMemory()
        {
            DataTable dt = zw.Getgather();
            if (dt == null)
                return;
            int cnt = dt.Rows.Count;
            if (cnt < 1)
                return;
            //先清空内存中所有指纹模板
            zkfp2.DBClear(mDBHandle);
            int cnts = 0;
            dicUserID.Clear();
            //将数据库中的指纹记录（ID，特征码）逐条添加到内存。
            for (int i = 0; i < cnt; i++)
            {
                DataRow row = dt.Rows[i];
                string fid = row["fid"].ToString();
                int userid = Convert.ToInt32(row["userID"].ToString());
                RegTmp = zkfp.Base64String2Blob(fid);
                int ret = zkfp2.DBAdd(mDBHandle, i + 1, RegTmp);
                dicUserID.Add(i + 1, userid);
                if (ret == 0) cnts++;
            }
            if (cnt == cnts)
            {
                Debug.WriteLine("指纹信息写入内存成功。");
            }
        }
        /// <summary>
        /// 启动登录指纹扫描线程
        /// </summary>
        public void ThreadFingerLogin()
        {
            Thread ThreadLogin = new(new ThreadStart(DoCaptureLogin))
            {
                IsBackground = true
            };
            ThreadLogin.Start();
        }
        public delegate void LoginHandler(int userid);
        public event LoginHandler LoginChanged;
        private void DoCaptureLogin()
        {
            while (!bIsTimeToDie)
            {
                cbCapTmp = 2048;
                int ret = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
                if (ret == zkfp.ZKFP_ERR_OK)
                {
                    int rst = zkfp.ZKFP_ERR_OK;
                    int fid = 0, score = 0;
                    string str = "";
                    rst = zkfp2.DBIdentify(mDBHandle, CapTmp, ref fid, ref score);
                    if (zkfp.ZKFP_ERR_OK == rst)
                    {
                        str = "Identify succ, fid= " + fid + ",score=" + score + "!" + " \n 识别成功,指纹ID=" + fid + ",准确率" + score + "!";

                        int userid = dicUserID[fid];
                        LoginChanged?.Invoke(userid);
                    }
                    else
                    {
                        str = "Identify fail, ret= " + ret + " \n 识别失败,ret=" + rst + "!";
                        LoginChanged?.Invoke(-1);
                    }
                }
                Thread.Sleep(100);
            }
        }
        protected override void DefWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case MESSAGE_CAPTURED_OK:
                    {
                        Debug.WriteLine("触发采集指纹值改变事件");
                        MemoryStream ms = new();
                        BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, ref ms);
                        Bitmap bmp = new(ms);
                        this.picFPImg.Image = bmp;
                        if (IsRegister)
                        {
                            int ret = zkfp.ZKFP_ERR_OK;
                            int fid = 0, score = 0;
                            //进行1:N 识别
                            ret = zkfp2.DBIdentify(mDBHandle, CapTmp, ref fid, ref score);
                            if (zkfp.ZKFP_ERR_OK == ret)
                            {
                                textRes.Text = "This finger was already register by " + fid + "!" + " \n 这个手指已经被登记在册了" + fid + "!";
                                return;
                            }
                            if (RegisterCount > 0 && zkfp2.DBMatch(mDBHandle, CapTmp, RegTmps[RegisterCount - 1]) <= 0)
                            {
                                textRes.Text = "Please press the same finger 3 times for the enrollment" + " \n 添加时请按同一个手指3次";
                                return;
                            }
                            Array.Copy(CapTmp, RegTmps[RegisterCount], cbCapTmp);
                            String strBase64 = zkfp2.BlobToBase64(CapTmp, cbCapTmp);
                            byte[] blob = zkfp2.Base64ToBlob(strBase64);
                            RegisterCount++;
                            if (RegisterCount >= REGISTER_FINGER_COUNT)
                            {
                                RegisterCount = 0;
                                if (zkfp.ZKFP_ERR_OK == (ret = zkfp2.DBMerge(mDBHandle, RegTmps[0], RegTmps[1], RegTmps[2], RegTmp, ref cbRegTmp)))
                                {
                                    iFid++;
                                    textRes.Text += "enroll succ" + " 登记成功！";
                                    //进行添加到数据库中
                                    string Fid = "";
                                    zkfp.Blob2Base64String(RegTmp, RegTmp.Length, ref Fid);
                                    string userid = cboUsername.SelectedValue.ToString();
                                    zw.Add(Fid, userid);
                                    LoadFingerToMemory();
                                }
                                else
                                {
                                    textRes.Text = "enroll fail, error code=" + Msg(ret) + " \n 注册失败,错误代码=" + Msg(ret) + "!";
                                }
                                IsRegister = false;
                                return;
                            }
                            else
                            {
                                textRes.Text = "You need to press the " + (REGISTER_FINGER_COUNT - RegisterCount) + " times fingerprint" + " \n 你需要按下 " + (REGISTER_FINGER_COUNT - RegisterCount) + " 次指纹!";
                            }
                        }
                        else
                        {
                            int ret = zkfp.ZKFP_ERR_OK;
                            int fid = 0, score = 0;
                            ret = zkfp2.DBIdentify(mDBHandle, CapTmp, ref fid, ref score);
                            if (zkfp.ZKFP_ERR_OK == ret)
                            {
                                textRes.Text = "Identify succ, fid= " + fid + ",score=" + score + "!" + " \n 识别成功,指纹ID=" + fid + ",准确率" + score + "!";
                                return;
                            }
                            else
                            {
                                textRes.Text = "Identify fail, ret= " + ret + " \n 识别失败,ret=" + ret + "!";
                                if (cbRegTmp <= 0)
                                {
                                    textRes.Text = "Please register your finger first!" + " \n 请先注册您的手指!";
                                    return;
                                }
                                return;
                            }
                        }
                        ScrollToCaret();
                    }
                    break;

                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }
        /// <summary>
        /// 获取到最新滚动
        /// </summary>
        public void ScrollToCaret()
        {
            textRes.ScrollToCaret();
            textRes.Focus();
            textRes.Select(textRes.TextLength, 0);
            textRes.ScrollToCaret();
        }

        private void cboUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var ds = bLL.GetUsers(cboUsername.Text.Trim()).First();
                if (ds != null) txtJobNumber.Text = ds.JobNumber;
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("指纹下拉人员选择失败：", ex);
            }
        }
    }
}
