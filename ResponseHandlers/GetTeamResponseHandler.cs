using CapsBallShared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace CapsBallCore
{
    public class GetTeamResponseHandler : IResponseHandler
    {
        public int ParamsRequiredCount => 3;

        public static event Action<Team> TeamGot;

        public void Handle(ResponsePackage responsePackage)
        {
            string name = responsePackage.Parameters[0];
            int currentCount = int.Parse(responsePackage.Parameters[1]);
            int targetCount = int.Parse(responsePackage.Parameters[2]);
            List<Player> players = new List<Player>();
            XmlSerializer serializer = new XmlSerializer(typeof(Player));
            for (int i = ParamsRequiredCount; i < currentCount; i++)
            {
                string serializedPlayer = responsePackage.Parameters[i];
                players.Add((Player)serializer.Deserialize(new StringReader(serializedPlayer)));
            }

            System.Console.WriteLine(name);
            System.Console.WriteLine(targetCount);
            for (int i = 0; i < currentCount; i++)
            {
                System.Console.WriteLine(players[i].Account.Country);
                System.Console.WriteLine(players[i].Account.Email);
                System.Console.WriteLine(players[i].Account.Id);
                System.Console.WriteLine(players[i].Account.LastLoginDate);
                System.Console.WriteLine(players[i].Account.Name);
                System.Console.WriteLine(players[i].Account.Nick);
                System.Console.WriteLine(players[i].Account.Points);

            }
            TeamGot?.Invoke(new Team(name, players));
        }
    }
}
