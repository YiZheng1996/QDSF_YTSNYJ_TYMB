using RW.Driver;

namespace MainUI.CurrencyHelper
{
    public class OPCHelper
    {
        #region OPCDriver
        public static OPCDriver opcAIGroup = new();
        public static OPCDriver opcAOGroup = new();
        public static OPCDriver opcDIGroup = new();
        public static OPCDriver opcDOGroup = new();
        public static OPCDriver opcPUBGroup = new();
        public static OPCDriver opcStatusGroup = new();
        public static OPCDriver opcWsd = new();
        #endregion

        #region opcGroup
        public static OpcStatusGrp opcStatus;
        public static AIGrp AIgrp;
        public static AOGrp AOgrp;
        public static DIGrp DIgrp;
        public static DOGrp DOgrp;
        public static PUBGrp PUBgrp;
        public static PLCCalibration plcc;
        public static WSDGrp Wsdgrp;
        #endregion

        static OPCHelper()
        {
            string kepServerName = "KEPware.KEPServerEx.V4";
            opcDOGroup.ServerName = kepServerName;
            opcDOGroup.Prefix = "MicroWin.ALL_PLC.";
            opcDIGroup.ServerName = kepServerName;
            opcDIGroup.Prefix = "MicroWin.ALL_PLC.";
            opcAIGroup.ServerName = kepServerName;
            opcAIGroup.Prefix = "MicroWin.ALL_PLC.";
            opcAOGroup.ServerName = kepServerName;
            opcAOGroup.Prefix = "MicroWin.ALL_PLC.";
            opcPUBGroup.ServerName = kepServerName;
            opcPUBGroup.Prefix = "MicroWin.ALL_PLC.";
            opcStatusGroup.ServerName = kepServerName;
            opcStatusGroup.Prefix = "MicroWin.ALL_PLC.";
            opcWsd.ServerName = kepServerName;
            opcWsd.Prefix = "Modbus.WSD.";
        }

        /// <summary>
        /// OPC打开
        /// </summary>
        public static void Connect()
        {
            opcDOGroup.Connect();
            opcDIGroup.Connect();
            opcAIGroup.Connect();
            //opcAOGroup.Connect();
            opcPUBGroup.Connect();
            opcStatusGroup.Connect();
            opcWsd.Connect();
        }

        /// <summary>
        /// OPC关闭
        /// </summary>
        public static void Close()
        {
            opcDOGroup.Close();
            opcDIGroup.Close();
            opcAIGroup.Close();
            //opcAOGroup.Close();
            opcPUBGroup.Close();
            opcStatusGroup.Close();
            opcWsd.Close();
        }


        public static void Init()
        {
            AIgrp = new AIGrp();
            //AOgrp = new AOGrp();
            DIgrp = new DIGrp();
            DOgrp = new DOGrp();
            PUBgrp = new PUBGrp();
            plcc = new PLCCalibration();
            Wsdgrp = new WSDGrp();
            opcStatus = new OpcStatusGrp();

            opcStatus.Init();
            AIgrp.Init();
            //AOgrp.Init();
            DIgrp.Init();
            DOgrp.Init();
            PUBgrp.Init();
            plcc.Init();
            Wsdgrp.Init();
        }

    }
}
