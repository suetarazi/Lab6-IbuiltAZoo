using Lab6_IbuiltAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    abstract class Narwhal : NoLegs, ISwim
    {
        public bool CanFloat { get; set; } = true;
        public bool HaveFins { get; set; } = true;
        public override bool HasHorn { get; set; } = true;
    }
}
