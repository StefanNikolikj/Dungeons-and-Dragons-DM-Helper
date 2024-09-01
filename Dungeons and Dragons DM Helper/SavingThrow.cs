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
    public partial class SavingThrow : Form
    {
        public List<Combatant> combatants {  get; set; }
        public SavingThrow(List<Combatant> combatants)
        {
            InitializeComponent();
            this.combatants = combatants;
        }

        private void btnRollSaveThrows_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.combatants.Count; i++)
            {
                string rollState = "Failed!";
                int roll = rollSavingThrow(combatants[i]);
                if (roll >= Convert.ToInt32(numSaveDC.Value))
                    rollState = "Saved!";


                sb.Append($"{combatants[i].name}: {roll} - {rollState}");
                if (cbRollDamage.Checked)
                {
                    int damage = 0;
                    string[] arr = tbEnterDice.Text.Split('d');
                    for (int j = 0; j < Convert.ToInt32(arr[0]); j++)
                    {
                        damage += Dice.rollDice(Convert.ToInt32(arr[1]));
                    }
                    if (rollState.CompareTo("Saved!") == 0 && cbHalfDamage.Checked)
                        damage /= 2;
                    else if (rollState.CompareTo("Saved!") == 0)
                        damage = 0;
                    string temp = "";
                    if (combatants[i].isResistant(ddDamageType.SelectedItem.ToString()))
                    {
                        damage /= 2;
                        temp = "Resistant!";
                    }
                    else if (combatants[i].isImmune(ddDamageType.SelectedItem.ToString()))
                    {
                        damage = 0;
                        temp = "Immune!";
                    }
                    else if (combatants[i].isVulnerable(ddDamageType.SelectedItem.ToString()))
                    {
                        damage *= 2;
                        temp = "Vulnerable!";
                    }
                    sb.Append($" Damage: {damage} ");
                    if (temp != "")
                        sb.Append($"({temp})");

                    if (combatants[i].currentHP - damage < 0)
                        combatants[i].currentHP = 0;
                   else combatants[i].currentHP -= damage;
                    
                }
                sb.Append("\n");
                btnRollSaveThrows.Enabled = false;
            }
            rtbRollResults.Text = sb.ToString();
        }
        private int rollSavingThrow(Combatant combatant)
        {
            int result = Dice.rollDice(20) + combatant.getSavingThrowModifier(ddSavingThrowType.SelectedItem.ToString());
            return result;
        }

        private void cbRollDamage_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRollDamage.Checked)
            {
                gbRollDamage.Enabled = true;
            }
            else gbRollDamage.Enabled = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
