using Lab6_IbuiltAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;


namespace Lab6_IbuiltAZoo.Classes
{   
    /// <summary>
    /// Derived from the HasLegs class
    /// </summary>
    public class Penguin : HasLegs
    {

        public override string CoatType { get; set; } = "feathers";

        public override string Eats()
        {
            return $"{Name} loves to eat fish";
        }

        //public override string Sleep()
        //{
        //    return ("This animal sleeps lying down");
        //}
    }
}
