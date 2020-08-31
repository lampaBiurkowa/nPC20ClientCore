namespace CapsBallCore
{
    public class AmmoPowerBonus : AmmoBonus, IBonus
    {
        public const float BULLET_BOUNCE = 500;

        public AmmoPowerBonus() : base()
        {
            TexturePath = "Resources/Bonuses/ammoPower.png";
            BulletTexturePath = "Resources/Bonuses/bulletPower.png";
        }
    }
}
