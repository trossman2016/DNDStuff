using Microsoft.VisualStudio.TestTools.UnitTesting;
using DiceRoller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller.Tests
{
    [TestClass()]
    public class DiceTests
    {
        [TestMethod()]
        public void dierollTestD20()
        {
            int nod = 100;
            int nos = 20;
            List<int> rolls = DiceRoller.Dice.diceroll(nos, nod);
            foreach (var roll in rolls)
            {
                Console.WriteLine(roll);
                Console.ReadLine();
                int rollfail = roll + nos;
                if (roll > nos)
                {
                    Assert.Fail("Roll number " + rolls.IndexOf(roll) + " was greater than " + nos + ".");
                }
                else if (roll < 1)
                {
                    Assert.Fail("Roll number " + rolls.IndexOf(roll) + " was less than 1.");
                }
            }
        }

        [TestMethod()]
        public void dierollTestD12()
        {
            int nod = 100;
            int nos = 12;
            List<int> rolls = DiceRoller.Dice.diceroll(nos, nod);
            foreach (var roll in rolls)
            {
                Console.WriteLine(roll);
                Console.ReadLine();
                if (roll > nos)
                {
                    Assert.Fail("Roll number " + rolls.IndexOf(roll) + " was greater than " + nos + ".");
                }
                else if (roll < 1)
                {
                    Assert.Fail("Roll number " + rolls.IndexOf(roll) + " was less than 1.");
                }
            }
        }

        [TestMethod()]
        public void dierollTestD10()
        {
            int nod = 100;
            int nos = 10;
            List<int> rolls = DiceRoller.Dice.diceroll(nos, nod);
            foreach (var roll in rolls)
            {
                Console.WriteLine(roll);
                Console.ReadLine();
                if (roll > nos)
                {
                    Assert.Fail("Roll number " + rolls.IndexOf(roll) + " was greater than " + nos + ".");
                }
                else if (roll < 1)
                {
                    Assert.Fail("Roll number " + rolls.IndexOf(roll) + " was less than 1.");
                }
            }
        }

        [TestMethod()]
        public void dierollTestD8()
        {
            int nod = 100;
            int nos = 8;
            List<int> rolls = DiceRoller.Dice.diceroll(nos, nod);
            foreach (var roll in rolls)
            {
                Console.WriteLine(roll);
                Console.ReadLine();
                if (roll > nos)
                {
                    Assert.Fail("Roll number " + rolls.IndexOf(roll) + " was greater than " + nos + ".");
                }
                else if (roll < 1)
                {
                    Assert.Fail("Roll number " + rolls.IndexOf(roll) + " was less than 1.");
                }
            }
        }

        [TestMethod()]
        public void dierollTestD6()
        {
            int nod = 100;
            int nos = 6;
            List<int> rolls = DiceRoller.Dice.diceroll(nos, nod);
            foreach (var roll in rolls)
            {
                Console.WriteLine(roll);
                Console.ReadLine(); if (roll > nos)
                {
                    Assert.Fail("Roll number " + rolls.IndexOf(roll) + " was greater than " + nos + ".");
                }
                else if (roll < 1)
                {
                    Assert.Fail("Roll number " + rolls.IndexOf(roll) + " was less than 1.");
                }
            }
        }

        [TestMethod()]
        public void dierollTestD4()
        {
            int nod = 100;
            int nos = 4;
            List<int> rolls = DiceRoller.Dice.diceroll(nos, nod);
            foreach (var roll in rolls)
            {
                Console.WriteLine(roll);
                Console.ReadLine();
                if (roll > nos)
                {
                    Assert.Fail("Roll number " + rolls.IndexOf(roll) + " was greater than " + nos + ".");
                }
                else if (roll < 1)
                {
                    Assert.Fail("Roll number " + rolls.IndexOf(roll) + " was less than 1.");
                }
            }
        }
    }
}