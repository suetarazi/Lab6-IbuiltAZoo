using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_IbuiltAZoo.Classes
{
    private class BaldEagle : Wings
    {
        private override int wingspan { get; set; } = 60;
        private virtual int Speed(int mph = 75);
        

    }
}
