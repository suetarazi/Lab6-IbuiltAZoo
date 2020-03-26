using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    public abstract class NoWings : LandAnimals
    {
        public virtual bool HasTrunk { get; set; } 

        public override string MoveAround()
        {
         
            return "This animal can walk or run";

        }
    }
        
    }

