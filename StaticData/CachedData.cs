using CapsBallShared;
using System.Linq;

namespace CapsBallCore
{
    public static class CachedData
    {
        public static bool IsAdmin { get; set; } //TODO wyfslic\
        public static GameState GameState { get; set; } = new GameState();
        public static string Nick { get; set; }
        public static Team CurrentTeam { get; set; } = new Team();
        public static Team OpponentTeam { get; set; } = new Team();
        public static ServerLoop ServerLoop { get; set; }
        public static StadiumData StadiumData { get; set; }

        public static AmmoBonus Ammo { get; set; }
        public static IBonus ExtraPower { get; set; }
        public static IWeapon Weapon { get; set; }

        public static TeamType DetermineTeamType(Player player)
        {
            if (CurrentTeam.Players.Any(p => p.PublicAccount.Nick == player.PublicAccount.Nick))
                return CurrentTeam.TeamType == TeamType.BLUE ? TeamType.BLUE : TeamType.RED;
            else
                return OpponentTeam.TeamType == TeamType.BLUE ? TeamType.BLUE : TeamType.RED;
        }
    }
}
