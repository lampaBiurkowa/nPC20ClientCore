using CapsBallShared;

namespace CapsBallCore
{
    public class Environment
	{
		public float Mass { get; set; } = SharedConstants.DEFAULT_MASS;
		public float PlayerRadius { get; set; } = Constants.DEFAULT_PLAYER_RADIUS;
		public float Power { get; set; } = SharedConstants.DEFAULT_POWER;
		public float Speed { get; set; } = SharedConstants.DEFAULT_SPEED;
    }
}
