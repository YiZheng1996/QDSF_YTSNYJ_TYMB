using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using MainUI.CurrencyHelper;
using RW.Modules;

namespace MainUI.Modules
{
    /// <summary>
    /// 控制下位机动作点位
    /// </summary>
    public partial class PUBGrp : BaseModule
    {
        public PUBGrp()
        {
            this.Driver = OPCHelper.opcPUBGroup;
            InitializeComponent();
        }
        public PUBGrp(IContainer container)
            : base(container)
        {
            this.Driver = OPCHelper.opcPUBGroup;
            InitializeComponent();
        }
        /// <summary>
        /// 对象索引器，电磁阀数组
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this[int index]
        {
            get
            {
                return pubList[index];
            }
            set
            {
                string tag = index.ToString().PadLeft(2, '0');
                this.Write("PUB.P" + tag, value);
            }
        }
        public void Fresh()
        {
            for (int i = 0; i < pubList.Length; i++)
            {
                PUBGroupChanged?.Invoke(this, i, pubList[i]);
            }
        }
        private object[] pubList = new object[PUBcnt];

        private const int PUBcnt = 85;
        public event ValueGroupHandler<object> PUBGroupChanged;

        public override void Init()
        {
            for (int i = 0; i < PUBcnt; i++)
            {
                int idx = i; // 循环中的i需要用临时变量存储。
                string opcTag = "PUB.P" + i.ToString().PadLeft(2, '0');
                AddListening(opcTag, delegate (object value)
                {
                    pubList[idx] = value;
                    PUBGroupChanged?.Invoke(this, idx, value);
                });
            }
            base.Init();
        }

    }
}
