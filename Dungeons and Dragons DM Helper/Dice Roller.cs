using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeons_and_Dragons_DM_Helper
{
    public partial class Dice_Roller : Form
    {
        List<Dice> diceList = new List<Dice>();
        
        public Dice_Roller()
        {
            InitializeComponent();
        }


        private void btnRoll_Click(object sender, EventArgs e)
        {
            int totalRoll = getTotalRoll();
            diceList.Clear();
            tbRollTotal.Text = totalRoll.ToString();
        }
        private void rollDice(int sides)
        {
            Dice dice = new Dice(sides);
            dice.setRoll();
            diceList.Add(dice);
        }
        private void btnd100_Click(object sender, EventArgs e)
        {
            rollDice(100);
        }

        private void btnd20_Click(object sender, EventArgs e)
        {
            rollDice(20);
        }

        private void btnd12_Click(object sender, EventArgs e)
        {
            rollDice(12);
        }

        private void btnd10_Click(object sender, EventArgs e)
        {
            rollDice(10);
        }

        private void btnd8_Click(object sender, EventArgs e)
        {
            rollDice(8);
        }

        private void btnd6_Click(object sender, EventArgs e)
        {
            rollDice(6);
        }

        private void btnd4_Click(object sender, EventArgs e)
        {
            rollDice(4);
        }
        private int getTotalRoll()
        {
            int totalRoll = 0;
            diceList.ForEach(dice => totalRoll += dice.roll);

            return totalRoll;
        }
    }
}
