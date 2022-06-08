
namespace AbstraindoJogoRPG.Entities
{
    internal class Heroes
    {
        public string Name { get; set; }

        public string HeroType { get; set; }

        public int Level { get; set; }

        public int PowerOfAttack { get; set; }

        public Heroes() { }

        public Heroes(string name, int level, string heroType, int powerOfAttack)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.PowerOfAttack = powerOfAttack;
        }
    }
}
