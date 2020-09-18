using CapsBallShared;

namespace CapsBallCore
{
    public class GunLongBonus : IBonus, IWeapon
    {
        public BonusType BonusType => BonusType.GUN_LONG;
        public float ExplosionAreaRadius => 0;
        public float MaxDistance => 1000;
        public string TexturePath => "Resources/Bonuses/gunLong.png";

        public void Activate()
        {
            throw new System.NotImplementedException();
        }
    }
}
