namespace CapsBallCore
{
    public class AmmoPowerBonus : AmmoBonus, IBonus
    {
        public string TexturePath => "Resources/Bonuses/ammoPower.png";

        public AmmoPowerBonus() : base() { }

        public void Activate() => RemainigItems--;
    }
}
