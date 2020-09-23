using System;

namespace CapsBallCore
{
    public class GameStartedEventArgs
    {
        public string StarterNick { get; private set; }

        public GameStartedEventArgs(string starterNick) => StarterNick = starterNick;
    }

    public class GameStartedResponseHandler : IResponseHandler
    {
        public int ParamsRequiredCount => 1;

        public static event EventHandler<GameStartedEventArgs> GameStarted;

        public void Handle(ResponsePackage responsePackage)
        {
            string starterNick = responsePackage.Parameters[0];
            System.Console.WriteLine($"HEJEJEHEJEJEHEJEHEJEH\n\nE");
            GameStarted?.Invoke(this, new GameStartedEventArgs(starterNick));
        }
    }
}
