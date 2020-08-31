using CapsBallShared;
using System.Collections.Generic;

namespace CapsBallCore
{
    public class PlayerWallBreakerCheat : ICheat
    {
        public int ParametersRequired => 1;

        public void Apply(StadiumData stadium, Player player, List<string> parameters)
        {
            int value = int.Parse(parameters[0]);
            player.Skills.Wallbreaker = value == 1 ? true : false;
        }
    }
}
