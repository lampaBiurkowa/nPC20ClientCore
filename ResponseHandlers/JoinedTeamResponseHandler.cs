using System;

namespace CapsBallCore
{
    public class JoinedTeamResponseHandler : IResponseHandler
    {
        public int ParamsRequiredCount => 1;

        public static event Action<int> JoinedTeam;

        public void Handle(ResponsePackage responsePackage)
        {
            int joinerId = int.Parse(responsePackage.Parameters[0]);
            JoinedTeam?.Invoke(joinerId);
        }
    }
}
