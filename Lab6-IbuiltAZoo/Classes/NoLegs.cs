using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    protected class NoLegs : WaterAnimals
    {
        //protected virtual string Eats();
        //protected override string Sleeps();
        protected abstract string coatType { get; set; } = "null";
    }
}
