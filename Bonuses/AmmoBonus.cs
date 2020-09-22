using CapsBallShared;
using System;

namespace CapsBallCore
{
    public abstract class AmmoBonus : IBonus
    {
        public abstract BonusType BonusType { get; }
        public string BulletTexturePath { get; protected set; }
        public int RemainigItemsCount { get; protected set; }
        public string TexturePath { get; protected set; }

        const int CAPACITY_BIG = 10;
        const int CAPACITY_SMALL = 5;

        public AmmoBonus() => Renew();

        public void Activate() => RemainigItemsCount--;

        public void Renew()
        {
            Random random = new Random();
            RemainigItemsCount = random.Next(0, 2) == 1 ? CAPACITY_BIG : CAPACITY_SMALL;
        }
    }
}
