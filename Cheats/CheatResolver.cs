using CapsBallShared;
using System.Collections.Generic;
using System.Linq;

namespace CapsBallCore
{
    public static class CheatResolver
    {
        const string BALL_MASS_CHEAT_ID = "bmass";
        const string GLOBAL_MASS_CHEAT_ID = "gmass";
        const string GLOBAL_POWER_CHEAT_ID = "gpower";
        const string GLOBAL_SIZE_CHEAT_ID = "gsize";
        const string GLOBAL_SPEED_CHEAT_ID = "gspeed";
        const string INVASION_CHEAT_ID = "invasion";
        const string PLAYER_INVISIBLE_CHEAT_ID = "pinvisible";
        const string PLAYER_MASS_CHEAT_ID = "pmass";
        const string PLAYER_POWER_CHEAT_ID = "ppower";
        const string PLAYER_SPEED_CHEAT_ID = "pspeed";
        const string PLAYER_WALL_BREAKER_CHEAT_ID = "pwallbreak";

        static Dictionary<ICheat, string> resolver = new Dictionary<ICheat, string>()
        {
            { new BallMassCheat(), BALL_MASS_CHEAT_ID },
            { new GlobalMassCheat(), GLOBAL_MASS_CHEAT_ID },
            { new GlobalPowerCheat(), GLOBAL_POWER_CHEAT_ID },
            { new GlobalSizeCheat(), GLOBAL_SIZE_CHEAT_ID },
            { new GlobalSpeedCheat(), GLOBAL_SPEED_CHEAT_ID },
            { new InvasionCheat(), INVASION_CHEAT_ID },
            { new PlayerInvisibleCheat(), PLAYER_INVISIBLE_CHEAT_ID },
            { new PlayerBounceCheat(), PLAYER_MASS_CHEAT_ID },
            { new PlayerPowerCheat(), PLAYER_POWER_CHEAT_ID },
            { new PlayerSpeedCheat(), PLAYER_SPEED_CHEAT_ID },
            { new PlayerWallBreakerCheat(), PLAYER_WALL_BREAKER_CHEAT_ID }
        };

        public static string CheatClassToString(ICheat cheat) =>
            resolver.Where(p => p.Key.GetType() == cheat.GetType()).FirstOrDefault().Value;

        public static ICheat StringToCheatClass(string cheatType) =>
            resolver.Where(p => p.Value == cheatType).FirstOrDefault().Key;
    }
}