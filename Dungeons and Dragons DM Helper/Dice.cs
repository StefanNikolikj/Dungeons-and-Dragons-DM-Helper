using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons_DM_Helper
{
    public static class Dice
    {
        private static Random RANDOM = new Random();

        public static int rollDice(int sides)
        {
            return RANDOM.Next(1,sides);
        }
        public static int rollWithAdvantage(int sides)
        {
            return Math.Max(RANDOM.Next(1, sides), RANDOM.Next(1, sides));
        }
        public static int rollWithDisadvantage(int sides)
        {
            return Math.Min(RANDOM.Next(1, sides), RANDOM.Next(1, sides));
        }
    }
}
