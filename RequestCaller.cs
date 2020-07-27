using CapsBallShared;
using nDSSH;
using System.Collections.Generic;

namespace CapsBallCore
{
    public static class RequestCaller
    {
        public static void RequestCreateTeam(Team team)
        {
            List<string> parameters = new List<string>(new string[] { team.Name });
            RequestPackage package = new RequestPackage(RequestCommand.CREATE_TEAM, parameters);
            Sender.Send(package.GetRawData());
        }

        public static void RequestJoinGame()
        {
            RequestPackage package = new RequestPackage(RequestCommand.JOIN_GAME);
            Sender.Send(package.GetRawData());
        }

        public static void RequestJoinTeam(string teamName)
        {
            List<string> parameters = new List<string>(new string[] { teamName });
            RequestPackage package = new RequestPackage(RequestCommand.JOIN_TEAM, parameters);
            Sender.Send(package.GetRawData());
        }

        public static void RequestGetTeams(TeamType teamType)
        {
            List<string> parameters = new List<string>(new string[] { teamType.ToString() });
            RequestPackage package = new RequestPackage(RequestCommand.GET_TEAMS, parameters);
            Sender.Send(package.GetRawData());
        }

        public static void RequestGetTeam(string name, TeamType teamType)
        {
            List<string> parameters = new List<string>(new string[] { name, teamType.ToString() });
            RequestPackage package = new RequestPackage(RequestCommand.GET_TEAM, parameters);
            Sender.Send(package.GetRawData());
        }

        public static void RequestChallangeTeam(string ownTeamName, string challangedTeamName)
        {
            List<string> parameters = new List<string>(new string[] { ownTeamName, challangedTeamName });
            RequestPackage package = new RequestPackage(RequestCommand.CHALLANGE_TEAM, parameters);
            Sender.Send(package.GetRawData());
        }
    }
}
