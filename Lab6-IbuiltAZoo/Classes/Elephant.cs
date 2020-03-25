using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    private class Elephant : NoWings
    {
        private virtual bool hasTrunk { get; set; } = true;
        private virtual int Speed(int mph = 10);
    }
}
