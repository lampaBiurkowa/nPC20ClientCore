using CapsBallShared;
using Newtonsoft.Json;
using System;

namespace CapsBallCore
{
    public class SendFootballerResponseHandler : IResponseHandler
    {
        public static event EventHandler<FootballerState> FootballerSent;

        public int ParamsRequiredCount { get; } = 1;
        public void Handle(ResponsePackage package)
        {
            FootballerState footballerState = JsonConvert.DeserializeObject<FootballerState>(package.Parameters[0]);
            FootballerSent?.Invoke(this, footballerState);
        }
    }
}
