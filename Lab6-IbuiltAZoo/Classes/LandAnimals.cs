using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{


    /// <summary>
    /// This class is derived from Animals and is a base class for Wings and NoWings
    /// </summary>
    public abstract class LandAnimals : Animals
    {
        public override string MoveAround()
        {
           
            return "These animals can move!";
        }

        public virtual string Speed()

        {
            
            return "0";
        }

    }
}
