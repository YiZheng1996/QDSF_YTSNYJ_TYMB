using NLog;

namespace MainUI.CurrencyHelper
{
    /// <summary>
    /// 日志等级排序 自上而下，等级递增:
    /// Trace - 最常见的记录信息，一般用于普通输出
    /// Debug - 同样是记录信息，不过出现的频率要比Trace少一些，一般用来调试程序
    /// Info  - 信息类型的消息
    /// Warn  - 警告信息，一般用于比较重要的场合
    /// Error - 错误信息
    /// Fatal - 致命异常信息。一般来讲，发生致命异常之后程序将无法继续执行。
    /// </summary>
    public class NlogHelper
    {
        #region 初始化
        /// <summary>
        /// 日事件间类
        /// </summary>
        private readonly LogEventInfo _logEventInfo = new();

        /// <summary>
        /// 提供日志接口和实用程序功能
        /// </summary>
        public readonly Logger _logger = null;
        /// <summary>
        /// 自定义日志对象供外部使用
        /// </summary>
        public static NlogHelper Default { get; private set; }

        private NlogHelper(Logger logger)
        {
            logger = LogManager.GetCurrentClassLogger();
            _logger = logger;
        }

        public NlogHelper(string name) : this(LogManager.GetLogger(name)) { }

        static NlogHelper()
        {
            //获取具有当前类名称的日志程序。
            Default = new NlogHelper("Logger");
        }
        #endregion

        #region 等级分类

        #region Trace 最常见的记录信息，一般用于普通输出
        /// <summary>
        /// 最常见的记录信息，一般用于普通输出
        /// </summary>
        /// <param name="msg">跟踪信息</param>
        /// <param name="args">动态参数</param>
        public void Trace(string msg, params object[] args)
        {
            var message = string.Empty;
            if (args != null)
            {
                message = string.Format(msg, args);
            }
            InsLog(NLog.LogLevel.Trace, message);
        }

        public void Trace(string msg, Exception err)
        {
            InsLog(NLog.LogLevel.Trace, msg, err);
        }
        #endregion

        #region Debug 同样是记录信息，不过出现的频率要比Trace少一些，一般用来调试程序
        public void Debug(string msg, params object[] args)
        {
            var message = string.Empty;
            if (args != null)
                message = string.Format(msg, args);
            InsLog(NLog.LogLevel.Debug, message);
        }

        public void Debug(string msg, Exception err)
        {
            InsLog(NLog.LogLevel.Debug, msg, err);
        }
        #endregion

        #region Info 信息类型的消息
        public void Info(string msg, params object[] args)
        {
            var message = string.Empty;
            if (args != null)
            {
                message = string.Format(msg, args);
            }
            InsLog(NLog.LogLevel.Info, message);
        }

        public void Info(string msg, Exception err)
        {
            InsLog(NLog.LogLevel.Info, msg, err);
        }
        #endregion

        #region Warn 警告信息，一般用于比较重要的场合
        /// <summary>
        ///警告
        /// </summary>
        /// <param name="msg">警告信息</param>
        /// <param name="args">动态参数</param>
        public void Warn(string msg, params object[] args)
        {
            var message = string.Empty;
            if (args != null)
            {
                message = string.Format(msg, args);
            }
            InsLog(NLog.LogLevel.Warn, message);
        }
        public void Warn(string msg, Exception err)
        {
            InsLog(NLog.LogLevel.Warn, msg, err);
        }
        #endregion

        #region Error 错误信息
        /// <summary>
        /// 使用指定的参数在错误级别写入诊断消息。
        /// </summary>
        /// <param name="msg">错误信息</param>
        /// <param name="args">动态参数</param>
        public void Error(string msg, params object[] args)
        {
            var message = string.Empty;
            if (args != null)
            {
                message = string.Format(msg, args);
            }
            InsLog(NLog.LogLevel.Error, message);
        }
        /// <summary>
        /// 使用指定的参数在错误级别写入诊断消息。
        /// </summary>
        /// <param name="msg">错误信息</param>
        /// <param name="args">异常信息</param>
        public void Error(string msg, Exception err)
        {
            InsLog(NLog.LogLevel.Error, msg, err);
        }
        #endregion

        #region Fatal 致命异常信息。一般来讲，发生致命异常之后程序将无法继续执行。

        public void Fatal(string msg, params object[] args)
        {
            var message = string.Empty;
            if (args != null)
            {
                message = string.Format(msg, args);
            }
            InsLog(NLog.LogLevel.Fatal, message);
        }

        public void Fatal(string msg, Exception ex)
        {
            InsLog(NLog.LogLevel.Fatal, msg, ex);
        }
        #endregion

        #endregion

        #region 日志写入
        /// <summary>
        /// 写入日志信息
        /// </summary>
        private void InsLog(NLog.LogLevel level, string msg, Exception ex = null)
        {
            var stackTrace = string.Empty;
            if (ex != null)
            {
                stackTrace = string.Format("StackTrace:{0},Message:", ex.StackTrace);
                var exception = ex;
                do
                {
                    stackTrace += exception.Message;
                    exception = exception.InnerException;

                } while (exception != null);
            }

            _logEventInfo.Properties["UserName"] = RW.Components.User.RWUser.Current.Username;
            _logEventInfo.Level = level;
            _logEventInfo.Message = stackTrace + msg;
            _logEventInfo.Exception = ex;
            _logger.Log(_logEventInfo);
            //System.Diagnostics.Debug.WriteLine(msg + "：" + ex?.Message);
        }
        #endregion 

    }
}