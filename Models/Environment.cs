using CapsBallShared;

namespace CapsBallCore
{
    public class Environment
	{
		public float BallBounce { get; set; } = SharedConstants.DEFAULT_BALL_MASS;
		public float BallRadius { get; set; } = SharedConstants.DEFAULT_BALL_RADIUS;
		public float FootballerBounceStep { get; set; } = SharedConstants.FOOTBALLER_BOUNCE_STEP;
		public float FootballerRadiusStep { get; set; } = SharedConstants.FOOTBALLER_RADIUS_STEP;
		public float PowerStep { get; set; } = SharedConstants.POWER_STEP;
		public float SpeedStep { get; set; } = SharedConstants.SPEED_STEP;
    }
}
