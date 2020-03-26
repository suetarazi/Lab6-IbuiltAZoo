using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    public abstract class WaterAnimals : Animals
    {
        public virtual string Eats()
        {
            return "Eats fish";
        }
        public abstract string Sleeps();
    }
}
