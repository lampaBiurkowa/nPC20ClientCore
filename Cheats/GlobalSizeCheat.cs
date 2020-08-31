using CapsBallShared;
using System.Collections.Generic;

namespace CapsBallCore
{
    public class GlobalSizeCheat : ICheat
    {
        public int ParametersRequired => 1;

        public void Apply(StadiumData stadium, Player player, List<string> parameters)
        {
            float value = float.Parse(parameters[0]);
            stadium.Environment.PlayerRadius = value;
        }
    }
}
