namespace CapsBallCore
{
    public class AmmoFreezeBonus : AmmoBonus, IBonus
    {
        public AmmoFreezeBonus() : base()
        {
            TexturePath = "Resources/Bonuses/ammoFreeze.png";
            BulletTexturePath = "Resources/Bonuses/bulletFreeze.png";
        }
    }
}
