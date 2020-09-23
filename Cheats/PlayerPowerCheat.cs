using CapsBallShared;
using System.Collections.Generic;

namespace CapsBallCore
{
    public class PlayerPowerCheat : ICheat
    {
        public int ParametersRequired => 1;

        public void Apply(StadiumData stadium, Player player, List<string> parameters)
        {
            float value = float.Parse(parameters[0]);
            if (value >= SharedConstants.MIN_SKILL_VALUE && value <= SharedConstants.MAX_SKILL_VALUE)
                player.Skills.Power = value;
        }
    }
}
