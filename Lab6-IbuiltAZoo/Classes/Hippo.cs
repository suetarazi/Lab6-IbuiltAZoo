using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    abstract class Hippo : HasLegs
    {
        public override string CoatType { get; set; } = "skin";
        public override string Eats()
        {
            return ("cheesecake");
        }
    }
}
