using Lab6_IbuiltAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace Lab6_IbuiltAZoo.Classes
{
    abstract class Penguin : HasLegs
    {

        public override string CoatType { get; set; } = "feathers";

        public override string Eats()
        {
            return "fish";
        }

        public string Sleep()
        {
            return ("This animal sleeps lying down");
        }
    }
}
