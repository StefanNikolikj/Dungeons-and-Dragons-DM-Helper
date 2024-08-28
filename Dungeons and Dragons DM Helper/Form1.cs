using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeons_and_Dragons_DM_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dice_Roller dice_Roller = new Dice_Roller();

            dice_Roller.Show();
        }

        private void lbCombatants_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCombatant_Click(object sender, EventArgs e)
        {
            NewCombatant newCombatant = new NewCombatant();

            if (newCombatant.ShowDialog() == DialogResult.OK)
            {
                lbCombatants.Items.Add(newCombatant.combatant);
            }
        }

        private void btnRollInitiative_Click(object sender, EventArgs e)
        {
            Dice initiativeDice = new Dice(20);
            List<Combatant> combatants = getCombatantList();
            foreach (var combatant in combatants)
            {
                initiativeDice.setRoll();
                combatant.initiative = initiativeDice.roll + combatant.modifierCalc(combatant.stats[1]);
            }
            combatants.Sort((a,b) => b.initiative.CompareTo(a.initiative));
            updateCombatants(combatants);

        }
        private List<Combatant> getCombatantList()
        {
            List<Combatant> tempList = new List<Combatant>();
            foreach (var item in lbCombatants.Items)
            {
                Combatant temp = item as Combatant;
                tempList.Add(temp);
            }
            return tempList;
        }
        private void updateCombatants(List<Combatant> combatants)
        {
            lbCombatants.Items.Clear();
            foreach (var combatant in combatants)
            {
                lbCombatants.Items.Add(combatant);
            }
        }
    }
}
