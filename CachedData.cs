using CapsBallShared;

namespace CapsBallCore
{
    public static class CachedData
    {
        public static string Nick { get; set; }
        public static Team CurrentTeam { get; set; }
        public static ServerLoop ServerLoop { get; set; }
    }
}
