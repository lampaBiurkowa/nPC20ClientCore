namespace CapsBallCore
{
    public static class Constants
    {
        const string RESOURCES_PATH = "Resources";

        public static float DEFAULT_PLAYER_RADIUS = 25;
        public static float DEFAULT_BOUNCE = 2;
        public static float DEFAULT_SPEED = 1;
        public static float DEFAULT_POWER = 1;

        public const string BLUE_TEAM_TEXTURE_PATH = RESOURCES_PATH + "/blueTeam.png";
        public const string RED_TEAM_TEXTURE_PATH = RESOURCES_PATH + "/redTeam.png";
        public const string INPUT_UP = "ui_up";
        public const string INPUT_DOWN = "ui_down";
        public const string INPUT_LEFT = "ui_left";
        public const string INPUT_RIGHT = "ui_right";
        public const string INPUT_POWER = "power";

        public const int PACKAGES_PER_SECOND = 24;
    }
}
