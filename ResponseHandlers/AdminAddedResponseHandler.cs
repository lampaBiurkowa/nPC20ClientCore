using System;

namespace CapsBallCore
{
    public class AdminAddedResponseHandler : IResponseHandler
    {
        public int ParamsRequiredCount => 0;

        public static event Action AdminAdded;

        public void Handle(ResponsePackage responsePackage)
        {
            CachedData.IsAdmin = true; //TODO remve?
            AdminAdded?.Invoke();
        }
    }
}
