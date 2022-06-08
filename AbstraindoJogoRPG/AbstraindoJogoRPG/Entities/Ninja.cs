
namespace AbstraindoJogoRPG.Entities
{
    internal class Ninja : Heroes 
    {
       
        public Ninja() { }

        public Ninja (string name, int level, string heroType, int powerOfAttack) : base(name, level, heroType, powerOfAttack)
        {
            this.Name = name;
            this.Level = level;
            this.PowerOfAttack = powerOfAttack;
            this.HeroType = heroType;
        }

        public override string ToString()
        {
            return $"The {HeroType} attacks with the katana, with the force of: {PowerOfAttack}";
        }
    }
}
   