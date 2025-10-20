using MainUI.Model;
using RW;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainUI.BLL
{
    public class NlogsBLL : DriverDeviceBaseBLL
    {
        public List<NlogsModel> FindList(string Level, string from, string to)
        {
            string where = " where";
            if (!string.IsNullOrEmpty(Level))
                where += " Level=" + string.Format("'{0}'", Level);
            where += $" and MessTime>=" + string.Format("'{0}'", from) + " and MessTime<=" + string.Format("'{0}'", to) + "";
            where += " order by MessTime desc";
            string sql1 = "select * from LoggerInfo" + where;
            DataTable dt = this.GetDataTable(sql1);
            List<NlogsModel> list = [];
            foreach (DataRow dr in dt.Rows)
                list.Add(GetModel(dr));
            return list;
        }

        public static NlogsModel GetModel(DataRow row)
        {
            NlogsModel N = new()
            {
                MessTime = row["MessTime"].ToDateTime(),
                Level = row["Level"].ToString(),
                Message = row["Message"].ToString(),
                UserName = row["UserName"].ToString(),
                MessageName = row["MessageName"].ToString(),
                Source = row["Source"].ToString()
            };
            return N;
        }
    }
}
