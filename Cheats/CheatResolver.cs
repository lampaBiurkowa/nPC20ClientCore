using CapsBallShared;
using System.Collections.Generic;
using System.Linq;

namespace CapsBallCore
{
    public static class CheatResolver
    {
        const string BALL_BOUNCE_CHEAT_ID = "bbounce";
        const string BALL_SIZE_CHEAT_ID = "bsize";
        const string GLOBAL_FOOTBALLER_BOUNCE_CHEAT_ID = "gbounce";
        const string GLOBAL_POWER_CHEAT_ID = "gpower";
        const string GLOBAL_SIZE_CHEAT_ID = "gsize";
        const string GLOBAL_SPEED_CHEAT_ID = "gspeed";
        const string INVASION_CHEAT_ID = "invasion";
        const string PLAYER_INVISIBLE_CHEAT_ID = "pinvisible";
        const string PLAYER_BOUNCE_CHEAT_ID = "pbounce";
        const string PLAYER_POWER_CHEAT_ID = "ppower";
        const string PLAYER_SIZE_CHEAT_ID = "psize";
        const string PLAYER_SPEED_CHEAT_ID = "pspeed";
        const string PLAYER_WALL_BREAKER_CHEAT_ID = "pwallbreak";

        static Dictionary<ICheat, string> resolver = new Dictionary<ICheat, string>()
        {
            { new BallBounceCheat(), BALL_BOUNCE_CHEAT_ID },
            { new BallSizeCheat(), BALL_SIZE_CHEAT_ID },
            { new GlobalFootbalerBounceCheat(), GLOBAL_FOOTBALLER_BOUNCE_CHEAT_ID },
            { new GlobalPowerCheat(), GLOBAL_POWER_CHEAT_ID },
            { new GlobalSizeCheat(), GLOBAL_SIZE_CHEAT_ID },
            { new GlobalSpeedCheat(), GLOBAL_SPEED_CHEAT_ID },
            { new InvasionCheat(), INVASION_CHEAT_ID },
            { new PlayerInvisibleCheat(), PLAYER_INVISIBLE_CHEAT_ID },
            { new PlayerBounceCheat(), PLAYER_BOUNCE_CHEAT_ID },
            { new PlayerPowerCheat(), PLAYER_POWER_CHEAT_ID },
            { new PlayerSizeCheat(), PLAYER_SIZE_CHEAT_ID },
            { new PlayerSpeedCheat(), PLAYER_SPEED_CHEAT_ID },
            { new PlayerWallBreakerCheat(), PLAYER_WALL_BREAKER_CHEAT_ID }
        };

        public static string CheatClassToString(ICheat cheat) =>
            resolver.Where(p => p.Key.GetType() == cheat.GetType()).FirstOrDefault().Value;

        public static ICheat StringToCheatClass(string cheatType) =>
            resolver.Where(p => p.Value == cheatType).FirstOrDefault().Key;
    }
}