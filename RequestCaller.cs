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

        public static void RequestSendOwnData(FootballerState footballerState)
        {
            List<string> parameters = new List<string>(new string[] { JsonConvert.SerializeObject(footballerState) });
            RequestPackage package = new RequestPackage(RequestCommand.SEND_FOOTBALLER_STATE, parameters);
            Sender.Send(package.GetRawData());
        }

        public static void RequestApplyImpulse(string nick, Vector2 impulse)
        {
            List<string> parameters = new List<string>(new string[] { nick, impulse.X.ToString(), impulse.Y.ToString() });
            RequestPackage package = new RequestPackage(RequestCommand.APPLY_IMPULSE, parameters);
            Sender.Send(package.GetRawData());
        }

        //TODO think 
        public static void Request(RequestCommand command, List<string> parameters)
        {
            RequestPackage package = new RequestPackage(command, parameters);
            Sender.Send(package.GetRawData());
        }
    }
}