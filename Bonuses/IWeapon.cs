using CapsBallShared;

namespace CapsBallCore
{
    public interface IWeapon
    {
        BonusType BonusType { get; }
        float ExplosionAreaRadius { get; }
        float MaxDistance { get; }
    }
}
