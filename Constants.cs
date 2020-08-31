namespace CapsBallCore
{
    public static class Constants
    {
        const string RESOURCES_PATH = "Resources";

        public const float DEFAULT_PLAYER_RADIUS = 25;
        public const int EXTRA_SKILL_BONUS_FACTOR = 2;

        public const string BLUE_TEAM_TEXTURE_PATH = RESOURCES_PATH + "/blueTeam.png";
        public const string RED_TEAM_TEXTURE_PATH = RESOURCES_PATH + "/redTeam.png";
        public const string INPUT_MOVE_UP = "move_up";
        public const string INPUT_MOVE_DOWN = "move_down";
        public const string INPUT_MOVE_LEFT = "move_left";
        public const string INPUT_MOVE_RIGHT = "move_right";
        public const string INPUT_ROTATE_RIGHT = "rotate_right";
        public const string INPUT_ROTATE_LEFT = "rotate_left";
        public const string INPUT_POWER = "power";
        public const string INPUT_SHOOT = "shoot";
        public const string INPUT_BONUS = "bonus_activate";

        public const int PACKAGES_PER_SECOND = 24;
        public const int EXTRA_SKILL_DURATION_SECONDS = 10;
        public const int BULLET_FLY_DURATION_SECONDS = 10;
    }
}
