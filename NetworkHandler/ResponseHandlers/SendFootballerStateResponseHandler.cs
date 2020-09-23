using CapsBallShared;
using Newtonsoft.Json;
using System;

namespace CapsBallCore
{
    public class SendFootballerStateResponseHandler : IResponseHandler
    {
        public static event EventHandler<FootballerState> FootballerSent;

        public int ParamsRequiredCount => 1;
        public void Handle(ResponsePackage package)
        {
            FootballerState footballerState = JsonConvert.DeserializeObject<FootballerState>(package.Parameters[0]);
            FootballerSent?.Invoke(this, footballerState);
        }
    }
}
