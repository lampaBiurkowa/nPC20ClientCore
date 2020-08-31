using GeoLib;
using System;

namespace CapsBallCore
{
    public class SendFootballerEventArgs
    {
        public bool Invisible { get; private set; }
        public string PlayerNick { get; private set; }
        public Vector2 Position { get; private set; }
        public float Rotation { get; private set; }
        public Vector2 Velocity { get; private set; }
        public bool WallBreaker { get; private set; }

        public SendFootballerEventArgs(string playerNick, Vector2 position, float rotation, Vector2 velocity, bool invisible, bool wallBreaker)
        {
            Invisible = invisible;
            PlayerNick = playerNick;
            Position = position;
            Rotation = rotation;
            Velocity = velocity;
            WallBreaker = wallBreaker;
        }
    }

    public class SendFootballerResponseHandler : IResponseHandler
    {
        public static event EventHandler<SendFootballerEventArgs> FootballerSent;

        public int ParamsRequiredCount { get; } = 8;
        public void Handle(ResponsePackage package)
        {
            string playerNick = package.Parameters[0];
            Vector2 position = new Vector2(float.Parse(package.Parameters[1]), float.Parse(package.Parameters[2]));
            float rotation = float.Parse(package.Parameters[3]);
            Vector2 velocity = new Vector2(float.Parse(package.Parameters[4]), float.Parse(package.Parameters[5]));
            bool invisible = bool.Parse(package.Parameters[6]);
            bool wallBreaker = bool.Parse(package.Parameters[7]);

            FootballerSent?.Invoke(this, new SendFootballerEventArgs(playerNick, position, rotation, velocity, invisible, wallBreaker));
        }
    }
}
