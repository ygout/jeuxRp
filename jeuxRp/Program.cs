using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeuxRp
{
    class Program
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Jeu1();
        }

        private static void Jeu1()
        {
            Joueur myHero = new Joueur(150);
            int easyFight = 0;
            int hardFight = 0;

            while(myHero.isAlive)
            {
                Monster monster = MonsterFactory();
                while (myHero.isAlive && monster.isAlive)
                {
                    myHero.Attack(monster);
                    if (monster.isAlive)
                        monster.Attack(myHero);
                }

                if (myHero.isAlive)
                {
                    if (monster is HardMonster)
                        hardFight++;
                    else
                        easyFight++;
                }
                else
                {
                    Console.WriteLine("Snif, vous êtes mort ...");
                    break;
                }
            }

            Console.WriteLine($"Bravo !!! Vous avez tué {easyFight} monstres faciles et {hardFight} monstres difficiles. Vous avez {easyFight + hardFight*2} points");
            Console.ReadLine();
        }

        private static Monster MonsterFactory()
        {
            if (random.Next(2) == 0)
                return new EasyMonster();
            else
                return new HardMonster();
        }
    }
}
