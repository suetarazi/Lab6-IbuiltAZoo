using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    /// <summary>
    /// This class is derived from LandAnimals and is a base class for BaldEagle and Pegasus
    /// </summary>
    public abstract class Wings : LandAnimals
    {
        public abstract int Wingspan { get; set; }
        
        public override string MoveAround()
        {
            return "This animal can fly";

        }
    }
}
