﻿using System;
using System.Threading;

namespace CapsBallCore
{
    public class ExtraSpeedBonus : IBonus
    {
        public string TexturePath => "Resources/Bonuses/extraSpeed.png";

        public void Activate()
        {
            BonusStates.ExtraSpeedEnabled = true;
            Thread endingThread = new Thread(waitAndHandleDisablingBonus);
            endingThread.Start();
        }

        void waitAndHandleDisablingBonus()
        {
            Thread.Sleep(Constants.EXTRA_SKILL_DURATION_SECONDS * 1000);
            BonusStates.ExtraSpeedEnabled = false;
        }
    }
}
