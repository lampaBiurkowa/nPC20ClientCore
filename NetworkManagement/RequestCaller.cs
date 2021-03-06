﻿using CapsBallShared;
using GeoLib;
using nDSSH;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace CapsBallCore
{
    public static class RequestCaller
    {
        public static void RequestBulletTriggered(BulletState bulletState)
        {
            List<string> parameters = new List<string>(new string[] { JsonConvert.SerializeObject(bulletState) });
            RequestPackage package = new RequestPackage(RequestCommand.BULLET_TRIGGERED, parameters);
            Sender.Send(package.GetRawData());
        }

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

        public static void RequestSendBallData(MovementState ballState)
        {
            List<string> parameters = new List<string>(new string[] { JsonConvert.SerializeObject(ballState) });
            RequestPackage package = new RequestPackage(RequestCommand.SEND_BALL_STATE, parameters);
            Sender.Send(package.GetRawData());
        }

        public static void RequestSendBonusData(BonusItemData bonusData, string receiverNick)
        {
            List<string> parameters = new List<string>(new string[] { JsonConvert.SerializeObject(bonusData), receiverNick });
            RequestPackage package = new RequestPackage(RequestCommand.SEND_BONUS_DATA, parameters);
            Sender.Send(package.GetRawData());
        }

        public static void RequestSendGameState(GameState gameState)
        {
            List<string> parameters = new List<string>(new string[] { JsonConvert.SerializeObject(gameState) });
            RequestPackage package = new RequestPackage(RequestCommand.SEND_GAME_STATE, parameters);
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