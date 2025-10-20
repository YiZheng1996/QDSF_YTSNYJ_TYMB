using AntdUI;

namespace MainUI.CurrencyHelper
{
    internal static class MessageHelper
    {

        public static void MessageOK(Form form, string title, string content, TType icon = TType.Success) =>
            Modal.open(new Modal.Config(form, title, content, icon)
            {
                OnButtonStyle = (id, btn) =>
                {
                    btn.BackExtend = "135, #6253E1, #04BEFE";
                },

                Width = 600,
                BtnHeight = 40,
                Keyboard = false,
                Icon = TType.Warn,
                CancelText = null,
                OkText = "知道了",
                MaskClosable = false,
                Font = new("宋体", 12),
            });

        public static void MessageOK(Form form, string content) => Modal.open(new Modal.Config(form, "系统消息", content, TType.Success)
        {
            OnButtonStyle = (id, btn) =>
            {
                btn.BackExtend = "135, #6253E1, #04BEFE";
            },

            Width = 600,
            BtnHeight = 40,
            Keyboard = false,
            Icon = TType.Warn,
            CancelText = null,
            OkText = "知道了",
            MaskClosable = false,
            Font = new("宋体", 12),
        });


        public static DialogResult MessageYes(Form form, string content)
        {
            Modal.Config config = new(form, "系统消息", content)
            {
                Width = 600,
                BtnHeight = 40,
                Keyboard = false,
                Icon = TType.Warn,
                MaskClosable = false,
                Font = new("宋体", 12),
            };
            return config.open();
        }
    }
}
