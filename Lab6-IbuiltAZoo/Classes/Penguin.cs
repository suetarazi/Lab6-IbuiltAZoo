using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    private class Penguin : HasLegs
    {
        private override string coatType { get; set; } = "feathers";

        private override string Eats()
        {
            return "fish";
        }
    }
}
