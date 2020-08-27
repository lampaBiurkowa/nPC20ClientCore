using System;
using System.Threading;

namespace CapsBallCore
{
    public class ExtraSpeedBonus : IBonus
    {
        public string TexturePath => "Resources/Bonuses/extraSpeed.png";

        public static event Action ExtraSpeedStarted;
        public static event Action ExtraSpeedEnded;

        public void Activate()
        {
            BonusStates.ExtraSpeedEnabled = true;
            Thread endingThread = new Thread(waitAndHandleDisablingBonus);
            endingThread.Start();
        }

        void waitAndHandleDisablingBonus()
        {
            Thread.Sleep(Constants.EXTRA_SKILL_DURATION_SECONDS);
            BonusStates.ExtraSpeedEnabled = false;
        }
    }
}
