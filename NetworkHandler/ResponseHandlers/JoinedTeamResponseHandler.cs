using CapsBallShared;
using Newtonsoft.Json;
using System;

namespace CapsBallCore
{
    public class JoinedTeamEventArgs
    {
        public Player Joiner { get; private set; }
        public TeamType TeamType { get; private set; }

        public JoinedTeamEventArgs(Player joiner, TeamType teamType)
        {
            Joiner = joiner;
            TeamType = teamType;
        }
    }

    public class JoinedTeamResponseHandler : IResponseHandler
    {
        public int ParamsRequiredCount => 2;

        public static event EventHandler<JoinedTeamEventArgs> JoinedTeam;

        public void Handle(ResponsePackage responsePackage)
        {
            Player joiner = JsonConvert.DeserializeObject<Player>(responsePackage.Parameters[0]);
            TeamType teamType = (TeamType)Enum.Parse(typeof(TeamType), responsePackage.Parameters[1]);
            JoinedTeam?.Invoke(this, new JoinedTeamEventArgs(joiner, teamType));
        }
    }
}
