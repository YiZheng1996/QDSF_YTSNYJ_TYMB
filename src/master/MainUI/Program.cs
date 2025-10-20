using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MainUI.CurrencyHelper;

namespace MainUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //新建实例对象
            VarHelper.fsql = new FreeSql.FreeSqlBuilder()
                 //监听SQL语句,Trace在输出选项卡中查看
                .UseMonitorCommand(cmd => Trace.WriteLine($"Sql：{cmd.CommandText}"))
                .UseConnectionString(FreeSql.DataType.Sqlite, ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString)
                .Build();

            if (!VarHelper.fsql.Ado.ExecuteConnectTest()) throw new Exception("Sqlite数据库连接失败");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin login = new();
            login.lblSoftName.Text = "一体式耐压机";
            login.Icon = new Icon("ico.ico");
            var files = Directory.GetFiles(Application.StartupPath, "ico.*");
            var f = files.Where(x => !x.Contains("ico.ico")).FirstOrDefault();
            if (f != null)
            {
                Image image = Image.FromFile(f);//登录界面和主界面的图片
                login.Logo.Image = image;
            }
            #region 单例模式
            string softname = Application.ProductName;
            VarHelper.SoftName = softname;
            bool flag = false;
            Mutex mutex = new(true, softname, out flag);
            //第一个参数:true--给调用线程赋予互斥体的初始所属权  
            //第一个参数:互斥体的名称  
            //第三个参数:返回值,如果调用线程已被授予互斥体的初始所属权,则返回true  
            if (!flag)
            {
                MessageBox.Show("只能运行一个程序！", "请确定", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(0);
            }
            #endregion
            DialogResult dr = login.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    OPCHelper.Connect();
                    frmMainMenu main = new()
                    {
                        Icon = new Icon("ico.ico")
                    };
                    if (f != null)
                    {
                        Image image = Image.FromFile(f);//登录界面和主界面的图片
                        main.Logo.Image = image;
                    }
                  
                    Application.Run(main);
                }
                catch (Exception ex)
                {
                    NlogHelper.Default.Error("初始化失败：", ex);
                    MessageBox.Show("初始化失败：" + ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
