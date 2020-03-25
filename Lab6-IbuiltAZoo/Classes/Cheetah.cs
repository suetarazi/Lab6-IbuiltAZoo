using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    private class Cheetah : NoWings
    {
        private virtual bool hasTrunk { get; set; } = false;
        private virtual int Speed(int mph = 80);
    }
}
