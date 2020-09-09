using CapsBallShared;

namespace CapsBallCore
{
    public class Environment
	{
		public float BallMass { get; set; } = SharedConstants.DEFAULT_BALL_MASS;
		public float FootballerBounce { get; set; } = SharedConstants.DEFAULT_FOTBALLER_BOUNCE;
		public float PlayerRadius { get; set; } = Constants.DEFAULT_PLAYER_RADIUS;
		public float Power { get; set; } = SharedConstants.DEFAULT_POWER;
		public float Speed { get; set; } = SharedConstants.DEFAULT_SPEED;
    }
}
