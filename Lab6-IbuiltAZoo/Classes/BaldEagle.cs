using Lab6_IbuiltAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    /// <summary>
    /// Derived from Wings and uses the IFly interface
    /// </summary>
    public class BaldEagle : Wings, IFly
    {
        public override int Wingspan { get; set; } = 60;
        public bool HasWings { get; set; } = true;
        public int Velocity { get; set; } = 75;

        public override string Name { get; set; }  
            
        public override string Speed()
        {
            
            return ($"{Name} can fly over {Velocity} mph");
        }
        

    }
}
