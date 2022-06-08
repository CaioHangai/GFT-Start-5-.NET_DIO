using System;
using System.Collections.Generic;
using AbstraindoJogoRPG.Entities;

namespace AbstraindoJogoRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Heroes> listOfHeroes = new List<Heroes>();

            Console.Write("Please enter the number of heroes: ");
            int numberOfHeroes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfHeroes; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Please enter hero data # {i}: ");

                Console.Write("Please enter the hero's name:");
                string name = Console.ReadLine();

                Console.Write("Please enter the hero's level:");
                int heroLevel = int.Parse(Console.ReadLine());

                Console.Write("Please enter the hero's attack power:");
                int powerOfAttack = int.Parse(Console.ReadLine());

                Console.WriteLine("Select a hero type:");
                Console.WriteLine("1 - for Knigt:");
                Console.WriteLine("2 - for Ninja:");
                Console.WriteLine("3 - for Wizard:");
                Console.WriteLine();

                int opcaoUsuario = int.Parse(Console.ReadLine());

                switch (opcaoUsuario)
                {
                    case 1:
                        string heroType = "Knight";
                        listOfHeroes.Add(new Knight(name, heroLevel, heroType, powerOfAttack));
                        break;

                    case 2:
                        heroType = "Ninja";
                        listOfHeroes.Add(new Ninja(name, heroLevel, heroType, powerOfAttack));
                        break;

                    case 3:
                        heroType = "Wizard";

                        Console.Write("Please enter the magic type:");
                        string magicType = Console.ReadLine();

                        listOfHeroes.Add(new Wizard(name, heroLevel, heroType, powerOfAttack, magicType));
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            Console.WriteLine();
            foreach (Heroes hero in listOfHeroes)
            {
                Console.WriteLine(hero.ToString());
            }
        }
    }
}
