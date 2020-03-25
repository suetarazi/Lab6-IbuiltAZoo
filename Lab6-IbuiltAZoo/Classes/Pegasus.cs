using Lab6_IbuiltAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    class Pegasus : Wings, ISwim, IFly
    {
        public override int Wingspan { get; set; } = 200;
        public bool CanFloat { get; set; } = true;
        public bool HaveFins { get; set; } = false;
        public bool HasWings { get; set; } = true;
        public int Velocity { get; set; } = 150;

        protected virtual int Speed()
        {
            return 150;
        }

    }
}
