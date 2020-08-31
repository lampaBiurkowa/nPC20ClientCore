using System;
using System.Threading;

namespace CapsBallCore
{
    public class ExtraPowerBonus : IBonus
    {
        public string TexturePath => "Resources/Bonuses/extraPower.png";

        public void Activate()
        {
            BonusStates.ExtraPowerEnabled = true;
            Thread endingThread = new Thread(waitAndHandleDisablingBonus);
            endingThread.Start();
        }

        void waitAndHandleDisablingBonus()
        {
            Thread.Sleep(Constants.EXTRA_SKILL_DURATION_SECONDS * 1000);
            BonusStates.ExtraPowerEnabled = false;
        }
    }
}
