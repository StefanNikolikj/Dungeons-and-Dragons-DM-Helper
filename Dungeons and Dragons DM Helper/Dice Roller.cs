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
        Dictionary<string, List<int>> diceMap {  get; set; }
        
        public Dice_Roller()
        {
            InitializeComponent();
            diceMap = new Dictionary<string, List<int>>();
        }


        private void btnRoll_Click(object sender, EventArgs e)
        {
            int totalRoll = getTotalRoll();
            
            tbRollTotal.Text = totalRoll.ToString();
        }
        private void rollDie(string dice)
        {
            int roll = Dice.rollDice(Int32.Parse(dice.Substring(1)));
            if (!diceMap.ContainsKey(dice))
                diceMap.Add(dice, new List<int> { roll });
            else diceMap[dice].Add(roll);
        }
        private void btnd100_Click(object sender, EventArgs e)
        {
            rollDie("d100");
        }

        private void btnd20_Click(object sender, EventArgs e)
        {
            rollDie("d20");
        }

        private void btnd12_Click(object sender, EventArgs e)
        {
            rollDie("d12");
        }

        private void btnd10_Click(object sender, EventArgs e)
        {
            rollDie("d10");
        }

        private void btnd8_Click(object sender, EventArgs e)
        {
            rollDie("d8");
        }

        private void btnd6_Click(object sender, EventArgs e)
        {
            rollDie("d6");
        }

        private void btnd4_Click(object sender, EventArgs e)
        {
            rollDie("d4");
        }
        private int getTotalRoll()
        {
            int totalRoll = 0;
            foreach (var key in diceMap.Keys)
            {
                foreach (var value in diceMap[key])
                    totalRoll += value;
            }
            return totalRoll;
        }
    }
}
