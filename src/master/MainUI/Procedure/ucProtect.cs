using MainUI.CurrencyHelper;
using System.Windows.Forms;

namespace MainUI.Procedure
{
    public partial class ucProtect : ucBaseManagerUI
    {
        public ucProtect(Form form)
        {
            this.form = form;
            InitializeComponent();
        }

        DeviceInspectConfig inspectConfig = new();

        private Form form { get; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            inspectConfig.EmergencyStop = txtEmergencyStop.Text;
            inspectConfig.Grounding = txtGrounding.Text;
            inspectConfig.ElectricBell = txtElectricBell.Text;
            inspectConfig.Interlock = txtInterlock.Text;
            inspectConfig.LowerLimit = txtLowerLimit.Text;
            inspectConfig.HighLimit = txtHighLimit.Text;
            inspectConfig.ElectricalMachinery = txtElectricalMachinery.Text;
            inspectConfig.MainContact = txtMainContact.Text;
            inspectConfig.FromContact = txtFromContact.Text;
            inspectConfig.Discharge = txtDischarge.Text;
            inspectConfig.DoorLock = txtDoorLock.Text;
            inspectConfig.Start = txtStart.Text;
            inspectConfig.Boost = txtBoost.Text;
            inspectConfig.StepDown = txtStepDown.Text;
            inspectConfig.Stop = txtStop.Text;
            inspectConfig.Reset = txtReset.Text;
            inspectConfig.TimeBtn = txtTimeBtn.Text;
            inspectConfig.TimerWare = txtTimer.Text;
            inspectConfig.Save();
            MessageHelper.MessageOK(form, "保存成功！");
        }

        private void ucProtect_Load(object sender, EventArgs e)
        {
            inspectConfig.Load();
            txtEmergencyStop.Text = inspectConfig.EmergencyStop;
            txtGrounding.Text = inspectConfig.Grounding;
            txtElectricBell.Text = inspectConfig.ElectricBell;
            txtInterlock.Text = inspectConfig.Interlock;
            txtLowerLimit.Text = inspectConfig.LowerLimit;
            txtHighLimit.Text = inspectConfig.HighLimit;
            txtElectricalMachinery.Text = inspectConfig.ElectricalMachinery;
            txtMainContact.Text = inspectConfig.MainContact;
            txtFromContact.Text = inspectConfig.FromContact;
            txtDischarge.Text = inspectConfig.Discharge;
            txtDoorLock.Text = inspectConfig.DoorLock;
            txtStart.Text = inspectConfig.Start;
            txtBoost.Text = inspectConfig.Boost;
            txtStepDown.Text = inspectConfig.StepDown;
            txtStop.Text = inspectConfig.Stop;
            txtReset.Text = inspectConfig.Reset;
            txtTimeBtn.Text = inspectConfig.TimeBtn;
            txtTimer.Text = inspectConfig.TimerWare;
        }
    }
}
