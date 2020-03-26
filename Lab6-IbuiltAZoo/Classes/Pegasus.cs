using Lab6_IbuiltAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    /// <summary>
    /// Derived from the Wings class and uses both the ISwim and IFly interfaces
    /// </summary>
    class Pegasus : Wings, ISwim, IFly
    {
        public override int Wingspan { get; set; } = 200;
        public bool CanFloat { get; set; } = true;
        public bool HaveFins { get; set; } = false;
        public bool HasWings { get; set; } = true;
        public int Velocity { get; set; } = 150;

        public override string Name { get; set; }
        public override string Speed()
        {
            return $"{Name} has the top speed of {Velocity} mph";
        }

    }
}
