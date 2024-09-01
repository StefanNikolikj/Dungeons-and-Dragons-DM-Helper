﻿using System;
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
        public int damageToCombatant {  get; set; }
        Combatant attackingCombatant { get; set; }
        public Combatant defendingCombatant { get; set; }
        Weapon selectedWeapon { get; set; }

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
                    damage = selectedWeapon.rollCriticalDamage();
                    sb.Append($" CRITICAL HIT!\nDamage: {damage}");
                }
                else if (attackRoll + getModifiers() > defendingCombatant.AC)
                {
                    damage = selectedWeapon.rollDamage();
                    sb.Append($" HIT!\nDamage: {damage}");
                }
                else if (attackRoll + getModifiers() == defendingCombatant.AC)
                {
                    damage = selectedWeapon.rollDamage() / 2;
                    sb.Append($" GLANCING!\nDamage: {damage}");
                }
                else sb.Append("MISS!");
                sb.Append("\n");
                defendingCombatant.dealDamage( damage );
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
    }
 
}
