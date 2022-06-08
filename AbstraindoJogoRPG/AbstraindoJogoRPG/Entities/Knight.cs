
namespace AbstraindoJogoRPG.Entities
{
    internal class Knight : Heroes
    {
        
        public Knight() { }

        public Knight(string name, int level, string heroType, int powerOfAttack) : base(name, level, heroType, powerOfAttack) 
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.PowerOfAttack = powerOfAttack; 
           
        }

        public override string ToString()
        {
            return $"The {HeroType} attacks with the sword, with the force of: {PowerOfAttack}";
        }
    }
}
