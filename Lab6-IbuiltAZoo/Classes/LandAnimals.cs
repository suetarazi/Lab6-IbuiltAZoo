using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    //this class is derived from Animals
    public abstract class LandAnimals : Animals
    {
        public override string MoveAround();
        public virtual int Speed();

    }
}
