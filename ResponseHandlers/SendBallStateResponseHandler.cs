using CapsBallShared;
using Newtonsoft.Json;
using System;

namespace CapsBallCore
{
    public class SendBallStateResponseHandler : IResponseHandler
    {
        public static event EventHandler<BallState> BallSent;

        public int ParamsRequiredCount => 1;
        public void Handle(ResponsePackage package)
        {
            BallState ballState = JsonConvert.DeserializeObject<BallState>(package.Parameters[0]);
            BallSent?.Invoke(this, ballState);
        }
    }
}
