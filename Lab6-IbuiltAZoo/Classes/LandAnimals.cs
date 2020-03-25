using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    //this class is derived from Animals
    abstract class LandAnimals : Animals
    {
        public override string MoveAround()
        {
           
            return "These animals can move!";
        }

        public virtual int Speed()

        {
            
            return 0;
        }

    }
}
