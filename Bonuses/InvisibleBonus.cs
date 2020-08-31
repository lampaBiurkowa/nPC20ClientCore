using System.Threading;

namespace CapsBallCore
{
    public class InvisibleBonus : IBonus
    {
        public string TexturePath => "Resources/Bonuses/invisible.png";

        public void Activate()
        {
            BonusStates.InvisibleEnabled = true;
            Thread endingThread = new Thread(waitAndHandleDisablingBonus);
            endingThread.Start();
        }

        void waitAndHandleDisablingBonus()
        {
            Thread.Sleep(Constants.EXTRA_SKILL_DURATION_SECONDS * 1000);
            BonusStates.InvisibleEnabled = false;
        }
    }
}
