using System.Threading;

namespace CapsBallCore
{
    public class WallBreakerBonus : IBonus
    {
        public string TexturePath => "Resources/Bonuses/wallBreaker.png";

        public void Activate()
        {
            BonusStates.WallBreakerEnabled = true;
            Thread endingThread = new Thread(waitAndHandleDisablingBonus);
            endingThread.Start();
        }

        void waitAndHandleDisablingBonus()
        {
            Thread.Sleep(Constants.EXTRA_SKILL_DURATION_SECONDS * 1000);
            BonusStates.WallBreakerEnabled = false;
        }
    }
}
