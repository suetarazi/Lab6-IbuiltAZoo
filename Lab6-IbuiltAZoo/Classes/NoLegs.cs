﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    /// <summary>
    /// This class is derived from WaterAnimals and is a base class for Narwhal and Stingray
    /// </summary>
    public abstract class NoLegs : WaterAnimals
    {
        //protected virtual string Eats();
        //protected override string Sleeps();
        public abstract bool HasHorn { get; set; }

        public override string MoveAround()

        {
            return "This animal swims";
        }
        
    }
}
