using CapsBallShared;
using System.Collections.Generic;

namespace CapsBallCore
{
    public interface ICheat
    {
        int ParametersRequired { get; }
        void Apply(StadiumData stadium, Player player, List<string> parameters);
    }
}
