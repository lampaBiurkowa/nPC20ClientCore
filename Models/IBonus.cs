using CapsBallShared;

namespace CapsBallCore
{
    public interface IBonus
    {
        string TexturePath { get; }

        void Activate();
    }
}
