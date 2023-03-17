using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace FunctionOpdracht5
{
    internal class Program
    {
        string heroName;
        int heroStrength;
        int health;
        string name;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            Console.WriteLine("choose your hero's name");

            name = Console.ReadLine();

            heroName = this.GetHeroName(); //heroName zit op Program (this)

            Console.WriteLine($"your hero is called {heroName}");

            this.SetHeroStrength(9999);//super sterk natuurlijk

            Console.WriteLine($"your hero's strength is {heroStrength}");

            //1) roep hier de SetHealth aan met een 1000;
            this.SetHealth(1000);

            while (!IsHeroDead())//4) maak deze function, deze geeft een true  terug als health <= 0, anders geeft deze false terug
            {
                //fight!

               	int dam = RollDamage();//5) maak deze function, je mag een random gebruiken of een vast getal
              
            	Console.WriteLine($"{name} takes {dam} damage");
				DoDamageToHero(dam);//6) maak deze function, deze haalt dam af van de health (op program)

            	Console.WriteLine($"{name} has {health} health");

                Thread.Sleep(1000);
            }

            Console.WriteLine("oefening compleet!");
        }

        //2) maak hier een function GetHeroName die met Console.ReadLine() een helden naam vraagt

        internal string GetHeroName()
        {
            return this.name;
        }

        //3) maak hier een function SetHeroStrength met 1 argument  van type 'int'
        internal void SetHeroStrength(int strengh)
        {
            this.heroStrength = strengh;
        }
        //in de body van de function zet de waarde van heroStrength (van program) het 

        //

        internal void SetHealth(int amount)
        {
            this.health += amount;
        }

        internal bool IsHeroDead()
        {
            if (this.health <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal int RollDamage()
        {
            return 50;
        }

        internal void DoDamageToHero(int damage)
        {
            this.health -= damage;
        }
    }
}