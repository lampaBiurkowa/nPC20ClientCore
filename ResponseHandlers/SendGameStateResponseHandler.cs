using CapsBallShared;
using GeoLib;
using Newtonsoft.Json;
using System;

namespace CapsBallCore
{
    public class SendGameStateEventArgs
    {
        public GameState GameState { get; private set; }

        public SendGameStateEventArgs(GameState gameState) => GameState = gameState;
    }

    public class SendGameStateResponseHandler : IResponseHandler
    {
        public static event EventHandler<SendGameStateEventArgs> GameStateSent;

        public int ParamsRequiredCount => 1;
        public void Handle(ResponsePackage package)
        {
            GameState gameState = JsonConvert.DeserializeObject<GameState>(package.Parameters[0]);
            CachedData.GameState = gameState;
            GameStateSent?.Invoke(this, new SendGameStateEventArgs(gameState));
        }
    }
}
