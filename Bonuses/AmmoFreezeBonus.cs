namespace CapsBallCore
{
    public class AmmoFreezeBonus : AmmoBonus, IBonus
    {
        public string TexturePath => "Resources/Bonuses/ammoFreeze.png";

        public AmmoFreezeBonus() : base() { }

        public void Activate() => RemainigItems--;
    }
}
