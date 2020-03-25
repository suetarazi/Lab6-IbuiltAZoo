using Lab6_IbuiltAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    class BaldEagle : Wings, IFly
    {
        public override int Wingspan { get; set; } = 60;
        public bool HasWings { get; set; } = true;
        public int Velocity { get; set; } = 75;

        protected virtual int Speed()
        {
            return 75;
        }
        

    }
}
