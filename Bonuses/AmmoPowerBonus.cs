using CapsBallShared;

namespace CapsBallCore
{
    public class AmmoPowerBonus : AmmoBonus, IBonus
    {
        public const float BULLET_BOUNCE = 500;
        public override BonusType BonusType => BonusType.AMMO_POWER;

        public AmmoPowerBonus() : base()
        {
            TexturePath = "Resources/Bonuses/ammoPower.png";
            BulletTexturePath = "Resources/Bonuses/bulletPower.png";
        }
    }
}
