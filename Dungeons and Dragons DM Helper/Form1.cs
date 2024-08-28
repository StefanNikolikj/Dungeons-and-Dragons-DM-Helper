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
            List<Combatant> combatants = getListOfSelectedCombatants();
            foreach (Combatant combatant in combatants)
            {
                combatant.initiative = Dice.rollDice(20) + combatant.modifierCalc(combatant.stats[1]);
                lbCombatants.Items[lbCombatants.Items.IndexOf(combatant)] = combatant;
            }
            sortCombatants();
            
        }
        private List<Combatant> getListOfSelectedCombatants()
        {
            List<Combatant> tempList = new List<Combatant>();
            foreach (var item in lbCombatants.SelectedItems)
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
        private List<Combatant> getListOfEveryCombatant()
        {
            List<Combatant> tempList = new List<Combatant>();
            foreach (var item in lbCombatants.Items)
            {
                Combatant temp = item as Combatant;
                tempList.Add(temp);
            }
            return tempList;
        }
        private void sortCombatants()
        {
            List<Combatant> combatants = getListOfEveryCombatant();
            combatants.Sort((a, b) => b.initiative.CompareTo(a.initiative));
            updateCombatants(combatants);
        }

        private void btnManualInitiative_Click(object sender, EventArgs e)
        {
            SetInitiative setInitiative = new SetInitiative();

            if (setInitiative.ShowDialog() == DialogResult.OK)
            {
                Combatant temp = lbCombatants.SelectedItem as Combatant;
                temp.initiative = setInitiative.initiative;
                lbCombatants.SelectedItem = temp;
                sortCombatants();
            }
        }

        private void btnSingleSavingThrow_Click(object sender, EventArgs e)
        {
            SavingThrow newSavingThrow = new SavingThrow();

            if(newSavingThrow.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
