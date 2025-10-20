using System.Speech.Synthesis;

namespace MainUI.CurrencyHelper
{
    public class SpeechHelper : IDisposable
    {
        private readonly SpeechSynthesizer synthesizer;

        public SpeechHelper() => synthesizer = new SpeechSynthesizer();

        // 播报指定的文本
        public void Speak(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException("文本不能为null或空。", nameof(text));
            }
            synthesizer.SpeakAsync(text);
        }

        // 停止当前播报
        public void Stop() => synthesizer.SpeakAsyncCancelAll();

        // 设置音量（0-100）
        public void SetVolume(int volume)
        {
            if (volume < 0 || volume > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(volume), "音量必须介于0和100之间。");
            }
            synthesizer.Volume = volume;
        }

        // 设置语速（-10 到 10）
        public void SetRate(int rate)
        {
            if (rate < -10 || rate > 10)
            {
                throw new ArgumentOutOfRangeException(nameof(rate), "语速必须介于-10和10之间。");
            }
            synthesizer.Rate = rate;
        }

        public void Dispose() => throw new NotImplementedException();
    }
}