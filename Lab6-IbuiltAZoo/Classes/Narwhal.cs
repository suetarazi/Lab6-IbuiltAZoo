using Lab6_IbuiltAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    public class Narwhal : NoLegs, ISwim
    {
        /// <summary>
        /// Derived from the NoLegs class and uses the ISwim interface
        /// </summary>
        public bool CanFloat { get; set; } = true;
        public bool HaveFins { get; set; } = true;
        public override bool HasHorn { get; set; } = true;


        public override string Name { get; set; }
        public string Sleep()
        {
            return $"{Name} sleeps while swimming";
        }

        public override string Eats()
        {
            return $"{Name} loves to eat chocolate ice cream";
        }
    }
}
