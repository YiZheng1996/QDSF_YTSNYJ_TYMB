using Microsoft.Data.Sqlite;
using RW.Components.Core.BLL;
using RW.Data;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.BLL
{
    public class DriverDeviceBaseBLL : BaseBLL
    {
        protected override void Init()
        {
            Connection = new SqliteConnection();
            ConnectionString = @"Data Source=TestBed.db;";
            base.Init();
        }
    }
}
