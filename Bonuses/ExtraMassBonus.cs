using System;
using System.Threading;

namespace CapsBallCore
{
    public class ExtraBounceBonus : IBonus
    {
        public string TexturePath => "Resources/Bonuses/extraMass.png";

        public static Action ExtraBounceStarted;
        public static Action ExtraBounceEnded;

        public void Activate()
        {
            BonusStates.ExtraMassEnabled = true;
            ExtraBounceStarted?.Invoke();
            Thread endingThread = new Thread(waitAndHandleDisablingBonus);
            endingThread.Start();
        }

        void waitAndHandleDisablingBonus()
        {
            Thread.Sleep(Constants.EXTRA_SKILL_DURATION_SECONDS * 1000);
            BonusStates.ExtraMassEnabled = false;
            ExtraBounceEnded?.Invoke();
        }
    }
}
