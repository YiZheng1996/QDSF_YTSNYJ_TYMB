namespace MainUI.Procedure.Test;

public class BaseTest
{
    [System.Runtime.InteropServices.DllImport("kernel32.dll")]
    public static extern uint GetTickCount();
    public static ParaConfig paraconfig = new();
    public delegate void TestStateHandler(bool isTesting);
    public static event TestStateHandler TestStateChanged;

    public delegate void TipsHandler(object sender, object info);
    public static event TipsHandler TipsChanged;

    public delegate void TipsTiming(object sender, int s);
    public static event TipsTiming TimingChanged;

    public delegate bool WaitCallback();

    public delegate void WaitTicked(int tick);
    public static event WaitTicked WaitTick;

    public static event WaitStepTicked WaitStepTick;
    public delegate void WaitStepTicked(int tick, string stepName);

    public static int CheckCount;
    public static Report.UcGrid ucGrid;
    public static NewTaskModel NewTask { get; set; } = new();
    public static AuxiliaryModel AuxiModel { get; set; } = new();
    public frmMainMenu frm { get; set; }
    public UcHMI Hmi { get; set; }
    public delegate void Del();
    public bool IsTesting { get; set; }

    /// <summary>
    /// 超时操作
    /// </summary>
    /// <param name="timeout">超时时间</param>
    /// <param name="breakTime">刷新频率</param>
    /// <param name="cancellationToken">绑定的ToKen</param>
    /// <param name="conditions">条件可多个，为true退出</param>
    public void Delay(int timeout, int breakTime, CancellationToken cancellationToken, params Func<bool>[] conditions)
    {
        conditions ??= [];
        bool isTesting = true;
        Stopwatch sw = Stopwatch.StartNew();
        while (sw.Elapsed.TotalSeconds < timeout && isTesting && !cancellationToken.IsCancellationRequested)
        {
            Task.Delay(breakTime).Wait();
            foreach (var condition in conditions)
            {
                if (condition()) { Debug.WriteLine("参数值：" + condition()); isTesting = false; return; }
            }
            cancellationToken.ThrowIfCancellationRequested();
        }
        sw.Reset();
    }
    public void Delay(double seconds, CancellationToken cancellationToken) => Delay(seconds, 100, delegate { return true; }, cancellationToken);
    public bool Delay(double sj, int interval, WaitCallback wait, CancellationToken cancellationToken)
    {
        int t = 0;
        double timeout = sj * 1000;
        while (t <= timeout && wait() && !cancellationToken.IsCancellationRequested)
        {
            t += interval;
            Thread.Sleep(interval);
            WaitTick?.Invoke(t);
            cancellationToken.ThrowIfCancellationRequested();
        }
        return t > timeout;
    }
    public void Delay(int seconds, string waitName) => Delay(seconds, 100, delegate { return true; }, waitName);
    public bool Delay(int sj, int interval, WaitCallback wait, string waitName)
    {
        int t = sj * 1000;
        int timeout = 0;
        while (t > timeout && wait() && IsTesting)
        {
            t -= interval;
            Thread.Sleep(interval);
            WaitStepTick?.Invoke(t, waitName);
        }
        return t <= timeout;
    }
    /// <summary>
    /// 显示已执行的时间
    /// </summary>
    public void LblTime(int time, string waitName) => WaitStepTick?.Invoke(time, waitName);
    /// <summary>
    /// 提示信息
    /// </summary>
    public void TxtTips(object str) => TipsChanged?.Invoke(this, str);
    public void TxtTiming(int s)
    {
        TimingChanged?.Invoke(this, s);
    }
    public delegate void ExcuteHandler(int index, bool value);
    /// <summary>
    /// 测试项点执行结束事件
    /// </summary>
    public static event ExcuteHandler ExcuteEnd;
    /// <summary>
    ///测试项点执行中 
    /// </summary>
    public static event ExcuteHandler Excuteing;
    public void Testend(int i, bool pd) => ExcuteEnd?.Invoke(i, pd);
    public void Testing(int i, bool pd) => Excuteing?.Invoke(i, pd);
    /// <summary>
    /// 试验状态
    /// </summary>
    public void TestStatus(bool isTest)
    {
        IsTesting = isTest;
        TestStateChanged?.Invoke(isTest);
    }

    /// <summary>
    /// 在子类中执行试验过程
    /// </summary>
    public virtual Task<bool> Execute() => Task.FromResult(true);
    /// <summary>
    /// 试验项点初始化
    /// </summary>
    public void Init()
    {
    }
}
