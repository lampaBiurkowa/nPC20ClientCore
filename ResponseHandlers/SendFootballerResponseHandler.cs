using GeoLib;
using System;

namespace CapsBallCore
{
    public class SendFootballerEventArgs
    {
        public string PlayerNick { get; private set; }
        public Vector2 Position { get; private set; }
        public Vector2 Velocity { get; private set; }

        public SendFootballerEventArgs(string playerNick, Vector2 position, Vector2 velocity)
        {
            PlayerNick = playerNick;
            Position = position;
            Velocity = velocity;
        }
    }

    public class SendFootballerResponseHandler : IResponseHandler
    {
        public static event EventHandler<SendFootballerEventArgs> FootballerSent;

        public int ParamsRequiredCount { get; } = 5;
        public void Handle(ResponsePackage package)
        {
            string playerNick = package.Parameters[0];
            Vector2 position = new Vector2(int.Parse(package.Parameters[1]), int.Parse(package.Parameters[2]));
            Vector2 velocity = new Vector2(int.Parse(package.Parameters[3]), int.Parse(package.Parameters[4]));

            FootballerSent?.Invoke(this, new SendFootballerEventArgs(playerNick, position, velocity));
        }
    }
}
