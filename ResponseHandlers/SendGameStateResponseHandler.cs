using CapsBallShared;
using GeoLib;
using Newtonsoft.Json;
using System;

namespace CapsBallCore
{
    public class SendGameStateResponseHandler : IResponseHandler
    {
        public static event EventHandler<GameState> GameStateSent;

        public int ParamsRequiredCount => 1;
        public void Handle(ResponsePackage package)
        {
            GameState gameState = JsonConvert.DeserializeObject<GameState>(package.Parameters[0]);
            CachedData.GameState = gameState;
            GameStateSent?.Invoke(this, gameState);
        }
    }
}
