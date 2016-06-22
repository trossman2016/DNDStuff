using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperItems
{
    public class Calculations
    {
        /// <summary>
        /// Calculates whether or not a list of d20 rolls would hit a specified
        /// armor class based off of the characters needed value to hit armor class 0.
        /// </summary>
        /// <param name="rolls">The rolls.</param>
        /// <param name="thac0">The thac0.</param>
        /// <param name="ac">The ac.</param>
        /// <typeparam name="wasHit">The boolean value for whether or not a hit was successful.</typeparam>
        /// <returns>Returns a <typeparamref name="wasHit"/> list.</returns>
        public static List<bool> CalculateHit(List<int> rolls, int thac0, int ac)
        {
            List<bool> wasHit = new List<bool>();
            foreach (int roll in rolls)
            {
                if (roll >= thac0 + (ac * -1) || roll == 20)
                {
                    wasHit.Add(true);
                }
                else
                {
                    wasHit.Add(false);
                }
            }
            return wasHit;
        }
    }
}
