﻿using Lab6_IbuiltAZoo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    abstract class HasLegs : WaterAnimals
    {
        //protected virtual string Eats();
        //protected override string Sleeps();
        public abstract string CoatType { get; set; }
        public bool CanFloat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool HaveFins { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string MoveAround()
        {
            {
                return "This animal can walk or swim";
            }

        }
    }
}
