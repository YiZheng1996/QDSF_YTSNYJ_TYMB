namespace MainUI.BLL
{
    public class TestZhiwenBLL() : DriverDeviceBaseBLL
    {
        protected override void Init()
        {
            TableName = "Demo";
            base.Init();
        }
        public DataTable GetListByModel()
        {
            string sql = string.Format("select * from Demo");
            return this.GetDataTable(sql);
        }
        public DataTable Getgather()
        {
            string sql = string.Format("select * from Demo");
            return this.GetDataTable(sql);
        }
        /// <summary>
        /// true 表示存在；false 不存在。
        /// </summary>
        public bool IsExist(string modelName)
        {
            string sql = string.Format("select name from Model where name='{0}'", modelName);
            DataTable dt = null;
            dt =this.GetDataTable(sql);
            if (dt != null && dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public void Add(string fid, string userID)
        {
            string sql = string.Format(@"insert into Demo(fid,userID) values('{0}',{1})", fid, userID);
            Connection.ExecuteNonQuery(sql, null);
        }

        public int Del(string userID)
        {
            string sql = string.Format(@"delete from Demo where userID={0}", userID);
            int ret = base.Connection.ExecuteNonQuery(sql, null);
            return ret;
        }

        public DataTable GetFingerByUserID(string userID)
        {
            string sql = string.Format(@"select * from Demo where userID='{0}'", userID);
            return this.GetDataTable(sql);
        }
    }
}
