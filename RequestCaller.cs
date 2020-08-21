using CapsBallShared;
using GeoLib;
using nDSSH;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CapsBallCore
{
    public static class RequestCaller
    {
        public static void RequestJoinGame() => Sender.Send(new RequestPackage(RequestCommand.JOIN_GAME).GetRawData());

        public static void RequestJoinTeam(TeamType teamType)
        {
            List<string> parameters = new List<string>(new string[] { teamType.ToString() });
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

        public static void RequestStartGame(StadiumCoreData stadiumCoreData)
        {
            List<string> parameters = new List<string>(new string[] { JsonConvert.SerializeObject(stadiumCoreData) });
            RequestPackage package = new RequestPackage(RequestCommand.START_GAME, parameters);
            Sender.Send(package.GetRawData());
        }

        public static void RequestSendOwnData(Vector2 position, float rotation, Vector2 velocity)
        {
            List<string> parameters = new List<string>(new string[] { position.X.ToString(), position.Y.ToString(), rotation.ToString(), velocity.X.ToString(), velocity.Y.ToString() });
            RequestPackage package = new RequestPackage(RequestCommand.SEND_FOOTBALER, parameters);
            Sender.Send(package.GetRawData());
        }
    }
}