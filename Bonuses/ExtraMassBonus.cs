using System;
using System.Threading;

namespace CapsBallCore
{
    public class ExtraMassBonus : IBonus
    {
        public string TexturePath => "Resources/Bonuses/extraMass.png";

        public static Action ExtraMassStarted;
        public static Action ExtraMassEnded;

        public void Activate()
        {
            BonusStates.ExtraMassEnabled = true;
            ExtraMassStarted?.Invoke();
            Thread endingThread = new Thread(waitAndHandleDisablingBonus);
            endingThread.Start();
        }

        void waitAndHandleDisablingBonus()
        {
            Thread.Sleep(Constants.EXTRA_SKILL_DURATION_SECONDS * 1000);
            BonusStates.ExtraMassEnabled = false;
            ExtraMassEnded?.Invoke();
        }
    }
}
