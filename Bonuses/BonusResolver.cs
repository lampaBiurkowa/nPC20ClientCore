using CapsBallShared;
using System.Collections.Generic;
using System.Linq;

namespace CapsBallCore
{
    public static class BonusResolver
    {
        static Dictionary<IBonus, BonusType> resolver = new Dictionary<IBonus, BonusType>();

        static BonusResolver()
        {
            resolver.Add(new AmmoFreezeBonus(), BonusType.AMMO_FREEZE);
            resolver.Add(new AmmoPowerBonus(), BonusType.AMMO_POWER);
            resolver.Add(new BilocationBonus(), BonusType.BILOCATION);
            resolver.Add(new BombBonus(), BonusType.BOMB);
            resolver.Add(new ExtraMassBonus(), BonusType.EXTRA_MASS);
            resolver.Add(new ExtraPowerBonus(), BonusType.EXTRA_POWER);
            resolver.Add(new ExtraSpeedBonus(), BonusType.EXTRA_SPEED);
            resolver.Add(new GunLongBonus(), BonusType.GUN_LONG);
            resolver.Add(new GunShortBonus(), BonusType.GUN_SHORT);
            resolver.Add(new InvasionBonus(), BonusType.INVASION);
            resolver.Add(new InvisibleBonus(), BonusType.INVISIBLE);
            resolver.Add(new ShieldBonus(), BonusType.SHIELD);
            resolver.Add(new WallBreakerBonus(), BonusType.WALL_BREAKER);
        }

        public static BonusType BonusClassToBonusType(IBonus bonus) =>
            resolver.Where(p => p.Key.GetType() == bonus.GetType()).FirstOrDefault().Value;

        public static IBonus BonusTypeToBonusClass(BonusType bonusType) =>
            resolver.Where(p => p.Value == bonusType).FirstOrDefault().Key;
    }
}