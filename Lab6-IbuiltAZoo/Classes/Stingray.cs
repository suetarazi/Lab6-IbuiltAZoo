using Lab6_IbuiltAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    abstract class Stingray : NoLegs, ISwim
    {
        /// <summary>
        /// Derived from the NoLegs class and uses the ISwim interface
        /// </summary>
        public bool CanFloat { get; set; } = true;
        public bool HaveFins { get; set; } = true;
        public override bool HasHorn { get; set; }  = false;
    
        public string Sleep()
        {
            return ("This animal sleeps while swimming");
        }

        public override string Eats()
        {
            return "crill";
        }
    }
}
