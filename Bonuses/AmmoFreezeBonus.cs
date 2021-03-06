﻿using CapsBallShared;

namespace CapsBallCore
{
    public class AmmoFreezeBonus : AmmoBonus, IBonus
    {
        public const float FREEZE_DURATION_SECONDS = 5;
        public override BonusType BonusType => BonusType.AMMO_FREEZE;

        public AmmoFreezeBonus() : base()
        {
            TexturePath = "Resources/Bonuses/ammoFreeze.png";
            BulletTexturePath = "Resources/Bonuses/bulletFreeze.png";
        }
    }
}
