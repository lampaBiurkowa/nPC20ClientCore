using CapsBallShared;
using Newtonsoft.Json;
using System;

namespace CapsBallCore
{
    public class BonusAddedResponseHandler : IResponseHandler
    {
        public int ParamsRequiredCount => 1;

        public static event EventHandler<BonusItemData> BonusAdded;

        public void Handle(ResponsePackage package)
        {
            BonusItemData bonusData = JsonConvert.DeserializeObject<BonusItemData>(package.Parameters[0]);
            BonusAdded?.Invoke(this, bonusData);
        }
    }
}
