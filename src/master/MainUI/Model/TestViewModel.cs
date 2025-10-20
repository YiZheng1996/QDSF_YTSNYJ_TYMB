namespace MainUI.Model
{
    /// <summary>
    /// 当前测试选择型号
    /// </summary>

    public class TestViewModel
    {
        private int _TypeID;
        /// <summary>
        /// 被试品型号ID
        /// </summary>
        public int TypeID
        {
            get { return _TypeID; }
            set { _TypeID = value; }
        }

        private string _TypeName;
        /// <summary>
        /// 被试品型号
        /// </summary>
        public string TypeName
        {
            get { return _TypeName; }
            set { _TypeName = value; }
        }

        private int _ModelID;
        /// <summary>
        /// 被试品类型ID
        /// </summary>
        public int ModelID
        {
            get { return _ModelID; }
            set { _ModelID = value; }
        }

        private string _ModelName;
        /// <summary>
        /// 被试品类型
        /// </summary>
        public string ModelName
        {
            get { return _ModelName; }
            set { _ModelName = value; }
        }

        private string _Mark;
        /// <summary>
        /// 备注
        /// </summary>
        public string Mark
        {
            get { return _Mark; }
            set { _Mark = value; }
        }

        private string _TestNO;
        /// <summary>
        /// 测试编号
        /// </summary>
        public string TestNO
        {
            get { return _TestNO; }
            set { _TestNO = value; }
        }

        private string _User;
        /// <summary>
        /// 当前登录用户
        /// </summary>
        public string User
        {
            get { return _User; }
            set { _User = value; }
        }








    }
}

