namespace CapsBallCore
{
    public class AmmoPowerBonus : AmmoBonus, IBonus
    {
        public AmmoPowerBonus() : base()
        {
            TexturePath = "Resources/Bonuses/ammoPower.png";
            BulletTexturePath = "Resources/Bonuses/bulletPower.png";
        }
    }
}
