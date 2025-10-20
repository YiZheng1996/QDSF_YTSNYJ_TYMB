using MainUI.CurrencyHelper;

namespace MainUI.Procedure.Test
{
    internal class BroadcastTest(CancellationToken cancellationToken) : BaseTest
    {
        public override Task<bool> Execute()
        {
            int sum = 0;
            var TaskState = cancellationToken.IsCancellationRequested;
            Delay(90, 1000, delegate
            {
                sum++;
                if (sum == 3)
                {
                    sum = 0;
                    VarHelper.speech.Speak("高压试验，注意安全");
                    Debug.WriteLine("高压试验，注意安全");
                }
                return OPCHelper.DIgrp[12] == true;
            }, cancellationToken);
            return Task.FromResult(true);
        }
    }
}
