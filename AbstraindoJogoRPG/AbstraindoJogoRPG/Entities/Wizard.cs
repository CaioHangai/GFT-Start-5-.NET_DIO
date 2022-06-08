

namespace AbstraindoJogoRPG.Entities
{
    internal class Wizard : Heroes
    {
        public string MagicType { get; set; }

        public Wizard() { }

        public Wizard(string name, int level, string heroType, int powerOfAttack, string magicType) : base (name, level, heroType, powerOfAttack)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.PowerOfAttack = powerOfAttack;
            MagicType = magicType;
        }

        public override string ToString()
        {
            return $"The {HeroType} attacks with magic of the type: {MagicType}, with the strength of: {PowerOfAttack}";
        }
    }
}
