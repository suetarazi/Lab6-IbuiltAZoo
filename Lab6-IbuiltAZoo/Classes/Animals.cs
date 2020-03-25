using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    abstract class Animals
    {
        public virtual int breathsPerMinute { get; set; }
        public abstract string MoveAround();   
    }

}
