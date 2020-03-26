using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Interfaces
{
    public interface IFly
    {/// <summary>
    /// IFly interface for animals that have the ability to fly
    /// </summary>
        public bool HasWings { get; set; }

        public int Velocity { get; set; }

    }
}
