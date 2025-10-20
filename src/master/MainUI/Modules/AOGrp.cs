using MainUI.CurrencyHelper;
using RW.Modules;
using System.ComponentModel;

namespace MainUI.Modules
{
    public partial class AOGrp : BaseModule
    {
        private const int AOcount = 0;
        public event ValueGroupHandler<double> AOvalueGrpChaned;
        public AOGrp()
        {
            Driver = OPCHelper.opcAOGroup;
            InitializeComponent();
        }

        public AOGrp(IContainer container)
            : base(container)
        {
            Driver = OPCHelper.opcAOGroup;
        }

        private double _cao00 = 0;
        public double CAO00 { get { return _cao00; } set { _cao00 = value; Write("AO.CAO00", value); } }

        private double _cao01 = 0;
        public double CAO01 { get { return _cao01; } set { _cao01 = value; Write("AO.CAO01", value); } }

        private double _cao02 = 0;
        public double CAO02 { get { return _cao02; } set { _cao02 = value; Write("AO.CAO02", value); } }

        public override void Init()
        {
            for (int i = 0; i < AOcount; i++)
            {
                int idx = i;
                string opcTag = "AO.CAO" + i.ToString().PadLeft(2, '0');
                AddListening(opcTag, delegate (double value)
                {
                    AOvalueGrpChaned?.Invoke(this, idx, value);
                });
            }
            base.Init();
        }
    }
}
