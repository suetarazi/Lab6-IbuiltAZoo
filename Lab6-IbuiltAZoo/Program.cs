using System;
using Lab6_IbuiltAZoo.Interfaces;
using Lab6_IbuiltAZoo.Classes;

namespace Lab6_IbuiltAZoo
{
    class Program
    {/// <summary>
    /// Main to instantiate animals, make array and show them; then make fly array for flying animals from IFly interface
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Animals[] animals = new Animals[5];
            IFly[] fly = new IFly[3];

            //instantiate 5 animals

            BaldEagle baldEagle = new BaldEagle() { Name = "Birdie", BreathsPerMinute = 25, HasWings = true, Wingspan = 100 };
            Pegasus pegasus = new Pegasus() { Name = "Wild horse", CanFloat = true, Wingspan = 200, Velocity = 200 };
            Elephant elephant = new Elephant() { Name = "Dumbo", HasTrunk = true, HasWings = false, Velocity = 25 };
            Penguin penguin = new Penguin() { Name = "Bill", CoatType = "feathers" };
            Narwhal narwahl = new Narwhal() { Name = "Spike", HasHorn = true };

            // fly array contains 3 animals
            fly[0] = baldEagle;
            fly[1] = pegasus;
            fly[2] = elephant;

            // animal array contains 5 animals
            animals[0] = baldEagle;
            animals[1] = pegasus;
            animals[2] = elephant;
            animals[3] = penguin;
            animals[4] = narwahl;

            for (int i = 0; i < fly.Length; i++)
            {
                var canFly = fly[i];
                if (canFly is LandAnimals)
                {
                    var flier = (LandAnimals)canFly;
                    flier.MoveAround();
                }
                else if (canFly is WaterAnimals)
                {
                    var swimmer = (WaterAnimals)canFly;
                    string eat = swimmer.Eats();
                    Console.WriteLine($"{eat}");
                }
            }

            //for loop to display 5 animals

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }

        }
    }
}

