using System;
using Xunit;
using Lab6-IbuiltAZoo.Classes;
using Lab6-IbuiltAZoo.Interfaces;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestEachClassInheritsBehavior()
        {
            BaldEagle baldEagle = new BaldEagle() { Name = "Birdie" };
            string input = baldEagle.blah();
            string expected = ($"{ baldEagle.Name} has a big wing span");
        }

        [Fact]

    }
}
