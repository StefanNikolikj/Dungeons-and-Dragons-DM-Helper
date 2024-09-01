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
    public partial class MakeAnAttack : Form
    {
        public int damageToCombatant { get; set; }
        Combatant attackingCombatant { get; set; }
        public Combatant defendingCombatant { get; set; }
        Weapon selectedWeapon { get; set; }
        private void MakeAnAttack_Load(object sender, EventArgs e)
        {

        }

        public MakeAnAttack(List<Combatant> combatants, Combatant combatant, Weapon selectedWeapon)
        {
            InitializeComponent();
            updateListBox(combatants);
            this.attackingCombatant = combatant;
            this.selectedWeapon = selectedWeapon;
            damageToCombatant = 0;
        }
        private void updateListBox(List<Combatant> combatants)
        {
            lbCombatants.Items.Clear();
            foreach (Combatant combatant in combatants)
            {
                lbCombatants.Items.Add(combatant);
            }
        }

        private void btnRollToHit_Click(object sender, EventArgs e)
        {
            if (lbCombatants.SelectedIndex == -1)
            {
                epMakeAnAttack.SetError(lbCombatants, "Please select a Combatant");
                return;
            }
            damageToCombatant = 0;
            rtbRollResults.Text = string.Empty;
            this.defendingCombatant = lbCombatants.SelectedItem as Combatant;
            int attackRoll = -1;
            int damage = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Convert.ToInt32(numNumberOfDice.Value); i++)
            {
                if (rbAdvantage.Checked)
                {
                    attackRoll = Dice.rollWithAdvantage(20);
                    sb.Append($"Roll to attack with Advantage: {attackRoll} + {getModifiers()}");
                }
                else if (rbDisadvantage.Checked)
                {
                    attackRoll = Dice.rollWithDisadvantage(20);
                    sb.Append($"Roll to attack with Disdvantage: {attackRoll} + {getModifiers()}");
                }
                else
                {
                    attackRoll = Dice.rollDice(20);
                    sb.Append($"Roll to atttack: {attackRoll} + {getModifiers()}");
                }

                if (attackRoll == 20)
                {
                    damage = getTotalDamage(selectedWeapon.rollCriticalDamage());
                    sb.Append($" CRITICAL HIT!\nDamage: {damage}");
                }
                else if (attackRoll + getModifiers() > defendingCombatant.AC)
                {
                    damage = getTotalDamage(selectedWeapon.rollDamage());
                    sb.Append($" HIT!\nDamage: {damage}");
                }
                else if (attackRoll + getModifiers() == defendingCombatant.AC)
                {
                    damage = getTotalDamage(selectedWeapon.rollDamage()) / 2;
                    sb.Append($" GLANCING!\nDamage: {damage}");
                }
                else sb.Append("MISS!");


                sb.Append("\n");
                defendingCombatant.dealDamage(damage);
            }

            rtbRollResults.Text += sb.ToString();
            btnRollToHit.Enabled = false;
        }
        private int getModifiers()
        {
            return attackingCombatant.proficiency + attackingCombatant.modifierCalc(attackingCombatant.stats[attackingCombatant.getStat(selectedWeapon.weaponType)]) + selectedWeapon.damageModifier;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void lbCombatants_Validating(object sender, CancelEventArgs e)
        {
            if (lbCombatants.SelectedIndex == -1)
            {
                epMakeAnAttack.SetError(lbCombatants, "Please select a Combatant");
                e.Cancel = true;
            }
            else
            {
                epMakeAnAttack.SetError(lbCombatants, null);
                e.Cancel = false;
            }
        }
        private int getTotalDamage(Dictionary<string, int> damagePerAttacktype)
        {
            int totalDamage = 0;
            foreach (string key in damagePerAttacktype.Keys)
            {
                if (defendingCombatant.isResistant(key))
                    totalDamage += damagePerAttacktype[key] / 2;
                else if (defendingCombatant.isImmune(key))
                    totalDamage += 0;
                else if (defendingCombatant.isVulnerable(key))
                    totalDamage += damagePerAttacktype[key] * 2;
                else totalDamage += damagePerAttacktype[key];
            }
            return totalDamage;
        }
    }
}
