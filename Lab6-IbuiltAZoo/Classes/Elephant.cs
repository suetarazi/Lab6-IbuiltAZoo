using Lab6_IbuiltAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    /// <summary>
    /// Derived from the NoWings class and uses the IFly interface
    /// </summary>
    class Elephant : NoWings, IFly
    {
        public override bool HasTrunk { get; set; } = true;
        public bool HasWings { get; set; } = false;
        public int Velocity { get; set; } = 10;

        public override string Name { get; set; }

        public override string Speed()
        {
            return $"{Name} can fly at {Velocity} mph";
        }
    }
}
