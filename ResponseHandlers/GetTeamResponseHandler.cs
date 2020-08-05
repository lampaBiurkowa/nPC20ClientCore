using CapsBallShared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CapsBallCore
{
    public class GetTeamResponseHandler : IResponseHandler
    {
        public int ParamsRequiredCount => 3;

        public static event Action<Team> TeamGot;

        public void Handle(ResponsePackage responsePackage)
        {
            TeamType type = (TeamType)Enum.Parse(typeof(TeamType), responsePackage.Parameters[0]);
            string name = responsePackage.Parameters[1];
            int currentCount = int.Parse(responsePackage.Parameters[2]);
            List<Player> players = new List<Player>();
            //XmlSerializer serializer = new XmlSerializer(typeof(Player));
            for (int i = ParamsRequiredCount; i < currentCount + ParamsRequiredCount; i++)
            {
                string serializedPlayer = responsePackage.Parameters[i];
                System.Console.WriteLine($"{players.Count} i {serializedPlayer}");
                players.Add(JsonConvert.DeserializeObject<Player>(serializedPlayer));
            }
            

            System.Console.WriteLine(name);
            for (int i = 0; i < currentCount; i++)
            {
                System.Console.WriteLine(players[i].PublicAccount.Country);
                System.Console.WriteLine(players[i].PublicAccount.Email);
                System.Console.WriteLine(players[i].PublicAccount.Id);
                System.Console.WriteLine(players[i].PublicAccount.LastLoginDate);
                System.Console.WriteLine(players[i].PublicAccount.Name);
                System.Console.WriteLine(players[i].PublicAccount.Nick);
                System.Console.WriteLine(players[i].PublicAccount.Points);
            }

            if (players.Any(p => p.PublicAccount.Nick == CachedData.Nick)) //TODO inline?
            {
                if (CachedData.CurrentTeam == null)
                    CachedData.CurrentTeam = new Team(type, name, players);
                else
                    CachedData.CurrentTeam.Players = players;
            }
            else
            {
                if (CachedData.OpponentTeam == null)
                    CachedData.OpponentTeam = new Team(type, name, players);
                else
                    CachedData.OpponentTeam.Players = players;
            }
            TeamGot?.Invoke(new Team(type, name, players));
        }
    }
}
