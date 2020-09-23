using CapsBallShared;
using Newtonsoft.Json;
using System;

namespace CapsBallCore
{
    public class SendBallStateResponseHandler : IResponseHandler
    {
        public static event EventHandler<MovementState> BallSent;

        public int ParamsRequiredCount => 1;
        public void Handle(ResponsePackage package)
        {
            MovementState ballState = JsonConvert.DeserializeObject<MovementState>(package.Parameters[0]);
            BallSent?.Invoke(this, ballState);
        }
    }
}
