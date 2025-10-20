using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainUI.CurrencyHelper;
using RW.Modules;

namespace MainUI.Modules
{
    public partial class PLCCalibration : BaseModule
    {
        public PLCCalibration()
        {
            InitializeComponent();
        }

        public PLCCalibration(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void InitComponts()
        {
            base.InitComponts();
            this.Driver = OPCHelper.opcAIGroup;
        }

        const int chCountAI = 4;

        const int chCountAO = 0;

        private double[] _plczeroAI = new double[chCountAI];
        private double[] _plcgainAI = new double[chCountAI];
        private double[] _plczeroAO = new double[chCountAO];
        private double[] _plcgainAO = new double[chCountAO];

        /// <summary>
        /// 返回零点值
        /// </summary>
        public double[] PlcZero
        {
            get
            { return _plczeroAI; }
        }

        public double[] Plcgain
        {
            get
            { return _plcgainAI; }
        }

        public override void Init()
        {
            for (int i = 1; i < chCountAI; i++)    //注册AI增溢键值
            {
                int temp = i;
                string opcTag = "AI.Zero" + i.ToString().PadLeft(2, '0');
                AddListening(opcTag, delegate (double value)
                {
                    _plczeroAI[temp] = value;

                });
            }

            for (int i = 1; i < chCountAI; i++)
            {
                int temp = i;
                string opcTag = "AI.Gain" + i.ToString().PadLeft(2, '0');
                AddListening(opcTag, delegate (double value)
                {
                    _plcgainAI[temp] = value;

                });
            }


            for (int i = 0; i < chCountAO; i++)    //注册AI增溢键值
            {
                int temp = i;
                string opcTag = "AO.Zero" + i.ToString().PadLeft(2, '0');
                AddListening(opcTag, delegate (double value)
                {
                    _plczeroAO[temp] = value;

                });
            }

            for (int i = 0; i < chCountAO; i++)
            {
                int temp = i;
                string opcTag = "AO.Gain" + i.ToString().PadLeft(2, '0');
                AddListening(opcTag, delegate (double value)
                {
                    _plcgainAO[temp] = value;

                });
            }
            base.Init();
        }

        /// <summary>
        /// AI零点写值操作
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void SetAIZero(int index, double value)
        {
            string opcTag = "AI.Zero" + index.ToString().PadLeft(2, '0');
            this.Write(opcTag, value);
        }


        /// <summary>
        /// AI增溢写值操作
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void SetAIGain(int index, double value)
        {
            string opcTag = "AI.Gain" + index.ToString().PadLeft(2, '0');
            this.Write(opcTag, value);
        }


        /// <summary>
        /// AO零点写值操作
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void SetAOZero(int index, double value)
        {
            string opcTag = "PUB.P03";
            this.Write(opcTag, value);
        }


        /// <summary>
        /// AO增溢写值操作
        /// </summary>
        /// <param name="index"></param>
        /// <param name="value"></param>
        public void SetAOGain(int index, double value)
        {
            string opcTag = "PUB.P04";
            this.Write(opcTag, value);
        }
    }
}
