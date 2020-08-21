using CapsBallShared;
using GeoLib;
using System;

namespace CapsBallCore
{
    public class BonusAddedEventArgs
    {
        public BonusType Bonus { get; private set; }
        public Vector2 Position { get; private set; }

        public BonusAddedEventArgs(BonusType bonus, Vector2 position)
        {
            Bonus = bonus;
            Position = position;
        }
    }

    public class BonusAddedResponseHandler : IResponseHandler
    {
        public int ParamsRequiredCount => 2;

        public static event EventHandler<BonusAddedEventArgs> BonusAdded;

        public void Handle(ResponsePackage responsePackage)
        {
            BonusType bonus = (BonusType)Enum.Parse(typeof(BonusType), responsePackage.Parameters[0]);
            Vector2 position = new Vector2(int.Parse(responsePackage.Parameters[1]), int.Parse(responsePackage.Parameters[2]));
            BonusAdded?.Invoke(this, new BonusAddedEventArgs(bonus, position));
        }
    }
}
