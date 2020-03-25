using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    private class Pegasus : Wings
    {
        private override int wingspan { get; set; } = 200;
        private virtual int Speed(int mph = 150);

    }
}
