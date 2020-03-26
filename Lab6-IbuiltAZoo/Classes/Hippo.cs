using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    /// <summary>
    /// Derived from the HasLegs class
    /// </summary>
    public class Hippo : HasLegs
    {
        public override string CoatType { get; set; } = "skin";
        public override string Eats()
        {
            return ("cheesecake");
        }
        public string Sleep()
        {
            return ("This animal sleeps lying down");
        }

    }
}
