using Lab6_IbuiltAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    abstract class Cheetah : NoWings, ISwim
    {
        public virtual bool HasTrunk { get; set; } = false;
        public bool CanFloat { get; set; } = true;
        public bool HaveFins { get; set; } = false;

        public virtual int Speed()
        {
            return 80;
        }
    }
}
