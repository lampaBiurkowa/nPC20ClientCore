﻿using CapsBallShared;
using System.Linq;

namespace CapsBallCore
{
    public static class CachedData
    {
        public static bool IsAdmin { get; set; } //TODO wyfslic
        public static string Nick { get; set; }
        public static Team CurrentTeam { get; set; }
        public static Team OpponentTeam { get; set; }
        public static ServerLoop ServerLoop { get; set; }

        public static TeamType DetermineTeamType(Player player)
        {
            if (CurrentTeam.Players.Any(p => p.PublicAccount.Nick == player.PublicAccount.Nick))
                return CurrentTeam.TeamType == TeamType.BLUE ? TeamType.BLUE : TeamType.RED;
            else
                return OpponentTeam.TeamType == TeamType.BLUE ? TeamType.BLUE : TeamType.RED;
        }
    }
}
