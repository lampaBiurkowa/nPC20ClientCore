namespace CapsBallCore
{
    public class ShieldBonus : IBonus
    {
        public string TexturePath => "Resources/Bonuses/shield.png";

        public void Activate() => BonusStates.ShieldEnabled = true;
    }
}
