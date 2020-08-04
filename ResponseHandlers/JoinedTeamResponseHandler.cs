using CapsBallShared;
using System;

namespace CapsBallCore
{
    public class JoinedTeamEventArgs
    {
        public string JoinerNick { get; private set; }
        public TeamType TeamType { get; private set; }

        public JoinedTeamEventArgs(string joinerNick, TeamType teamType)
        {
            JoinerNick = joinerNick;
            TeamType = teamType;
        }
    }

    public class JoinedTeamResponseHandler : IResponseHandler
    {
        public int ParamsRequiredCount => 2;

        public static event EventHandler<JoinedTeamEventArgs> JoinedTeam;

        public void Handle(ResponsePackage responsePackage)
        {
            string joinerNick = responsePackage.Parameters[0];
            TeamType teamType = (TeamType)Enum.Parse(typeof(TeamType), responsePackage.Parameters[1]);
            JoinedTeam?.Invoke(this, new JoinedTeamEventArgs(joinerNick, teamType));
        }
    }
}
