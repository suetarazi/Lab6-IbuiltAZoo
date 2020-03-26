using Lab6_IbuiltAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    /// <summary>
    /// Derived from the NoWings class and uses the ISwim interface
    /// </summary>
    public class Cheetah : NoWings, ISwim
    {
        public override bool HasTrunk { get; set; } = false;
        public bool CanFloat { get; set; } = true;
        public bool HaveFins { get; set; } = false;

        public override string Name { get; set; }
        public override string Speed()
        {
            return "80";
        }
    }
}
