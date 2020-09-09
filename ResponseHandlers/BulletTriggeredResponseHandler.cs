using CapsBallShared;
using Newtonsoft.Json;
using System;

namespace CapsBallCore
{
    public class BulletTriggeredResponseHandler : IResponseHandler
    {
        public static event EventHandler<BulletState> BulletTriggered;

        public int ParamsRequiredCount => 1;
        public void Handle(ResponsePackage package)
        {
            BulletState ballState = JsonConvert.DeserializeObject<BulletState>(package.Parameters[0]);
            BulletTriggered?.Invoke(this, ballState);
        }
    }
}
