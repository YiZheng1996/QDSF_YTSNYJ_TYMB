using MainUI.CurrencyHelper;
using System.Drawing;
using System.Windows.Forms;

namespace MainUI
{
    public partial class frmInformation : UIForm
    {
        public frmInformation() => InitializeComponent();

        private readonly Dictionary<int, UIDigitalLabel> DicPub = [];
        private void FrmInformation_Load(object sender, EventArgs e)
        {
            InitLabel(uiPanel2);
            OPCHelper.PUBgrp.PUBGroupChanged += PUBgrp_PUBGroupChanged;
            OPCHelper.PUBgrp.Fresh();
        }

        private void InitLabel(Control control)
        {
            try
            {
                foreach (Control item in control.Controls)
                {
                    if (item is UIDigitalLabel)
                    {
                        var pan = item as UIDigitalLabel;
                        if (pan.Tag != null)
                        {
                            DicPub.Add(pan.Tag.ToInt32(), pan);
                        }
                    }
                    InitLabel(item);
                }
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error($"设备检查界面，添加控件失败：{ex.Message}", ex);
                MessageHelper.MessageOK(this, $"设备检查界面，添加控件失败：{ex.Message}");
            }
        }

        private void PUBgrp_PUBGroupChanged(object sender, int index, object value)
        {
            if (DicPub.TryGetValue(index, out UIDigitalLabel digitalLabel))
            {
                digitalLabel.Value = value.ToDouble();
            }
        }

        private void btnQ00_Click(object sender, EventArgs e)
        {
            UIButton bt = sender as UIButton;
            DialogResult o = MessageBox.Show(this, "确定清零【" + bt.Text + "计数】吗？清零后数据将不可恢复！", "系统提示", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == o)
                OPCHelper.PUBgrp[bt.Tag.ToInt32()] = 0;
            else
                return;
        }

    }
}
