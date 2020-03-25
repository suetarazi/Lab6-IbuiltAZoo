using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    public abstract class WaterAnimals : Animals
    {
        public override string MoveAround();
        public virtual string Eats();
        public abstract string Sleeps();
    }
}
