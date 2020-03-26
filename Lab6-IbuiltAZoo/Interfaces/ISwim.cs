using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Interfaces
{
    public interface ISwim
    {
        /// <summary>
        /// ISwim interface for animals with the ability to swim
        /// </summary>
        public bool CanFloat { get; set; }
        public bool HaveFins { get; set; }


    }
}
