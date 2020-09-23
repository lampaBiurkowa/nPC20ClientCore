using CapsBallShared;
using GeoLib;
using System;

namespace CapsBallCore
{
    public class ImpulseAppliedEventArgs
    {
        public string Nick { get; private set; }
        public Vector2 Impulse { get; private set; }

        public ImpulseAppliedEventArgs(Vector2 impulse, string nick)
        {
            Nick = nick;
            Impulse = impulse;
        }
    }

    public class ImpulseAppliedResponseHandler : IResponseHandler
    {
        public int ParamsRequiredCount => 3;

        public static event EventHandler<ImpulseAppliedEventArgs> ImpulseApplied;

        public void Handle(ResponsePackage responsePackage)
        {
            string nick = responsePackage.Parameters[0];
            float x = float.Parse(responsePackage.Parameters[1]);
            float y = float.Parse(responsePackage.Parameters[2]);
            Vector2 impulse = new Vector2(x, y);
            ImpulseApplied?.Invoke(this, new ImpulseAppliedEventArgs(impulse, nick));
        }
    }
}
