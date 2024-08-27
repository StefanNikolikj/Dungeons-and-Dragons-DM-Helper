using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons_DM_Helper
{
    internal class Dice
    {
        public int sides;
        public int roll;
        private Random RANDOM;

        public Dice(int sides)
        {
            this.sides = sides;
            RANDOM = new Random();
            roll = 0;
        }

        public void setRoll()
        {
            roll = RANDOM.Next(1,sides);
        }
    }
}
