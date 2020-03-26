using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    /// <summary>
    /// This class is derived from the base class animals; it also serves as the base class for HasLegs and NoLegs
    /// </summary>
    public class WaterAnimals : Animals
    {
        public override string MoveAround()
        {
            return "no legs";
        }
        public virtual string Eats()
        {
            return "Eats fish";
        }
        public string Sleeps()
        {
            return "We all gotta sleep sometime";
        }
    }
}
