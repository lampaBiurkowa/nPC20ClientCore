using CapsBallShared;

namespace CapsBallCore
{
    public class GunShortBonus : IBonus, IWeapon
    {
        public BonusType BonusType => BonusType.GUN_SHORT;
        public float ExplosionAreaRadius => 100;
        public float MaxDistance => 200;
        public string TexturePath => "Resources/Bonuses/gunShort.png";

        public void Activate()
        {
            throw new System.NotImplementedException();
        }
    }
}
