using CapsBallShared;

namespace CapsBallCore
{
    public class BombBonus : IBonus, IWeapon
    {
        public BonusType BonusType => BonusType.BOMB;
        public float ExplosionAreaRadius => 500;
        public float MaxDistance => 0;
        public string TexturePath => "Resources/Bonuses/bomb.png";

        public void Activate()
        {
            throw new System.NotImplementedException();
        }
    }
}
