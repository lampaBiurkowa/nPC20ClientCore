using System;

namespace CapsBallCore
{
    public abstract class AmmoBonus
    {
        public int RemainigItems { get; protected set; }

        const int CAPACITY_BIG = 10;
        const int CAPACITY_SMALL = 5;

        public AmmoBonus()
        {
            Random random = new Random();
            RemainigItems = random.Next(0, 2) == 1 ? CAPACITY_BIG : CAPACITY_SMALL;
        }
    }
}
