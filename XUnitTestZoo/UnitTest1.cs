using System;
using Xunit;
using Lab6_IbuiltAZoo.Classes;

namespace XUnitTestZoo
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests for inherited behavior in BaldEagle class
        /// </summary>
        [Fact]
        public void TestBaldEagleClassInheritsBehavior()
        {
            BaldEagle baldEagle = new BaldEagle() { Name = "Birdie" };
            string input = baldEagle.Speed();
            string expected = ($"{baldEagle.Name} can fly over {baldEagle.Velocity} mph");
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Tests for inherited behavior in Pegasus class
        /// </summary>
        [Fact]
        public void TestPegasusClassInheritsBehavior()
        {
            Pegasus pegasus = new Pegasus() { Name = "Wild horse" };
            string input = pegasus.Speed();
            string expected = ($"{pegasus.Name} has the top speed of {pegasus.Velocity} mph");
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Tests for inherted behavior in Elephant class
        /// </summary>
        [Fact]
        public void TestElephantClassInheritsBehavior()
        {
            Elephant elephant = new Elephant() { Name = "Dumbo" };
            string input = elephant.Speed();
            string expected = ($"{elephant.Name} can fly at {elephant.Velocity} mph");
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Tests for inherited behavior in Narwhal class
        /// </summary>
        [Fact]
        
        public void TestNarwhalClassInheritsBehavior()
        {
            Narwhal narwhal = new Narwhal() { Name = "Spike" };
            string input = narwhal.Eats();
            string expected = ($"{narwhal.Name} loves to eat chocolate ice cream");
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Tests for inherited behavior in Cheetah class
        /// </summary>
        [Fact]
        public void TestCheetahInheritedBehavior()
        {
            Cheetah cheetah = new Cheetah();
            Assert.True(cheetah.CanFloat);

        }

        /// <summary>
        /// Tests for inherited behavior in Hippo class
        /// </summary>
        [Fact]
        public void TestHippoInheritedBehavior()
        {
            Hippo hippo = new Hippo();
            string input = hippo.Eats();
            string expected = "cheesecake";
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Tests for inherited behavior in Penguin class
        /// </summary>
        [Fact]
        public void TestPenguinInheritedBehavior()
        {
            Penguin penguin = new Penguin() { Name = "Bill" };
            string input = penguin.Eats();
            string expected = ($"{penguin.Name} loves to eat fish");
            Assert.Equal(expected, input);
        }

        /// <summary>
        /// Tests for inherited behavior in Stingray class
        /// </summary>
        [Fact]
        public void TestStingrayInheritedBehavior()
        {
            Stingray stingray = new Stingray();
            string input = stingray.Sleeps();
            string expected = "We all gotta sleep sometime";
            Assert.Equal(expected, input);
        }

    }
}

