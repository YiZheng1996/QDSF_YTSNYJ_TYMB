using AntdUI;
using MainUI.CurrencyHelper;

namespace MainUI.TaskInformation
{
    public partial class FrmEditTaskId : UIForm
    {
        public string HoldTaskId { get; set; }
        public string HoldItemId { get; set; }
        public int AffectedCount { get; set; } // 受影响的记录数

        public FrmEditTaskId(string holdTaskId, string holdItemId, int affectedCount)
        {
            InitializeComponent();

            this.HoldTaskId = holdTaskId;
            this.HoldItemId = holdItemId;
            this.AffectedCount = affectedCount;

            // 设置初始值
            txtHoldTaskId.Text = holdTaskId;
            txtHoldItemId.Text = holdItemId;

            // 设置提示信息
            lblWarning.Text = $"⚠️ 注意: 此操作将同时修改该主任务下的所有 {affectedCount} 条子任务记录,以及对应的主任务记录。";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // 验证输入
                if (string.IsNullOrWhiteSpace(txtHoldTaskId.Text))
                {
                    MessageHelper.MessageOK(this, "施工任务ID不能为空!");
                    txtHoldTaskId.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtHoldItemId.Text))
                {
                    MessageHelper.MessageOK(this, "耐压子任务ID不能为空!");
                    txtHoldItemId.Focus();
                    return;
                }

                // 检查是否有修改
                if (txtHoldTaskId.Text.Trim() == HoldTaskId &&
                    txtHoldItemId.Text.Trim() == HoldItemId)
                {
                    MessageHelper.MessageOK(this, "任务ID没有变化,无需修改!");
                    return;
                }

                // 二次确认
                string confirmMsg = $"确认要修改吗?\n\n" +
                                   $"将影响 {AffectedCount} 条子任务记录和 1 条主任务记录\n\n" +
                                   $"施工任务ID: {HoldTaskId} → {txtHoldTaskId.Text.Trim()}\n" +
                                   $"耐压子任务ID: {HoldItemId} → {txtHoldItemId.Text.Trim()}";

                if (AntdUI.Modal.open(new Modal.Config(this, "确认修改", confirmMsg, TType.Warn)
                {
                    OkText = "确认修改",
                    CancelText = "取消",
                    OkType = TTypeMini.Error
                }) != DialogResult.OK)
                {
                    return;
                }

                // 保存修改的值
                HoldTaskId = txtHoldTaskId.Text.Trim();
                HoldItemId = txtHoldItemId.Text.Trim();

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                NlogHelper.Default.Error("确认修改错误:", ex);
                MessageHelper.MessageOK(this, "确认修改错误:" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FrmEditTaskId_Load(object sender, EventArgs e)
        {
            // 窗体加载时聚焦到第一个输入框
            txtHoldTaskId.Focus();
        }
    }
}