using System;
using Lab6_IbuiltAZoo.Interfaces;
using Lab6_IbuiltAZoo.Classes;

namespace Lab6_IbuiltAZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IFly[] fly = new IFly[3];

            BaldEagle baldEagle = new BaldEagle() { BreathsPerMinute = 25, HasWings = true, Wingspan = 100 };
            Pegasus pegasus = new Pegasus() { CanFloat = true, Wingspan = 200, Velocity = 200 };
            Elephant elephant = new Elephant() { HasTrunk = true, HasWings = false, Velocity = 25 };
                        
                fly[0] = baldEagle;
                fly[1] = pegasus;
                fly[2] = elephant;
        
            for (int i=0; i<fly.Length; i++)
            {
                var canFly = fly[i];
                if(canFly is LandAnimals)
                {
                    var flier = (LandAnimals)canFly;
                    flier.MoveAround();
                }
                else if(canFly is WaterAnimals)
                {
                    var swimmer = (WaterAnimals)canFly;
                    swimmer.Eats();
                }
            }

        }
    }
}
