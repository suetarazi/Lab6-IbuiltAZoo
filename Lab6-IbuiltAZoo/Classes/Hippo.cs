using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    private class Hippo : HasLegs
    {
        private override string coatType { get; set; } = "skin";
        private override string Eats()
        {
            return ("cheesecake");
        }
    }
}
