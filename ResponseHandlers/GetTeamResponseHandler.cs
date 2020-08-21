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
            for (int i = ParamsRequiredCount; i < currentCount + ParamsRequiredCount; i++)
            {
                string serializedPlayer = responsePackage.Parameters[i];
                players.Add(JsonConvert.DeserializeObject<Player>(serializedPlayer));
            }

            if (players.Any(p => p.PublicAccount.Nick == CachedData.Nick))
                CachedData.CurrentTeam = new Team(type, name, players);
            else
                CachedData.OpponentTeam = new Team(type, name, players);

            TeamGot?.Invoke(new Team(type, name, players));
        }
    }
}
