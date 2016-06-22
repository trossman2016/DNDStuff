using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    public class Dice
    {

        /// <summary>
        /// Function to roll a die with the specified number of sides a specified number of times.
        /// </summary>
        /// <param name="nos">The number of sides to the die (i.e. 6).</param>
        /// <param name="nod">The number of times to roll the die (default of 1).</param>
        /// <returns>Returns a list of the rolls.</returns>
        public static List<int> diceroll(int nos, int nod = 1)
        {
            List<int> roll = new List<int>();
            int rollsum = 0;
            int rollcount = 0;
            Random rnd = new Random();


            while (rollcount < nod)
            {
                int rollnext = rnd.Next(1, nos);
                roll.Add(rollnext);
                rollsum += rollnext;
                rollcount++;
            }
            return roll;
        }

        public static List<int> dieroll(int nos, int nod, Random rnd, bool IsStatRoll = false)
        {
            List<int> rolls = new List<int>();
            if (nos == 6)
            {
                if (IsStatRoll)
                {
                    for (int i = 0; i < nod; i++)
                    {
                        rolls.Add(rnd.Next(2, 6));
                    }                    
                }
                else
                {
                    rolls.Add(rnd.Next(1, nos));
                } 
            }

            return rolls;
        }
    }
}
