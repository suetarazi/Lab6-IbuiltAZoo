using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    /// <summary>
    /// Base class Animals
    /// </summary>
    public abstract class Animals
    {
        public virtual int BreathsPerMinute { get; set; }
        public abstract string MoveAround();
        
    }

}
