using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceRoller;
using HelperItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperItems.Tests
{
    [TestClass()]
    public class CalculationsTests
    {
        [TestMethod()]
        public void CalculateHitTest()
        {
            int thac0 = 8;
            int ac = -13;
            List<int> rolls = new List<int>();
            rolls.Add(20);
            List<bool> actual = Calculations.CalculateHit(rolls, thac0, ac);
            foreach (int roll in rolls)
            {
                int testroll = (20 - roll) + roll;
                Console.WriteLine(testroll.ToString());
                int needed = thac0 + (ac * -1);
                string test = roll.ToString() + " " + actual.ElementAt(rolls.IndexOf(roll)) + " " + needed.ToString();
                Console.WriteLine(test);
                bool expected = false;
                if (needed <= testroll || testroll == 20)
                {
                    expected = true;
                }
                Assert.AreEqual(expected, actual.ElementAt(rolls.IndexOf(roll)));
            }
        }
    }
}