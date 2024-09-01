﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons_DM_Helper
{
    [Serializable]
    public class Weapon
    {
        public string name {  get; set; }
        public List<string> damageDice {  get; set; } // as an example, damage die can be 2d6 where the format is: 2 - num of dice to roll, d6 - type of dice rolled
        //public List<string> damageTypes { get; set; } // can be piercing, slashing, cold, radiant, etc...

        public int damageModifier { get; set; }
        
        public string weaponType { get; set; } // can only be str or dex
        public int statModifier { get; set; }

        public Weapon()
        {
        }

        public Weapon(string name, List<string> damageDice, int damageModifier, string weaponType)
        {
            this.name = name;
            this.damageDice = damageDice;
            //this.damageTypes = damageTypes;
            this.damageModifier = damageModifier;
            this.weaponType = weaponType;
            this.statModifier = 0;
        }
        public int rollDamage()
        {
            int totalDamage = 0;
            foreach (string dice in this.damageDice)
            {
                string[] temp = dice.Split(' ');
                string[] arr = temp[0].Split('d');
                for (int i = 0; i < Convert.ToInt32(arr[0]); i++)
                {
                    totalDamage += Dice.rollDice(Convert.ToInt32(arr[1]));
                }
            }
            return totalDamage + damageModifier + statModifier;
        }
        public int rollCriticalDamage()
        {
            int totalDamage = 0;
            foreach (string dice in this.damageDice)
            {
                string[] temp = dice.Split(' ');
                string[] arr = temp[0].Split('d');
                for (int i = 0; i < 2*Convert.ToInt32(arr[0]); i++)
                {
                    totalDamage += Dice.rollDice(Convert.ToInt32(arr[1]));
                }
            }
            return totalDamage + damageModifier + statModifier;
        }
        public override string ToString()
        {
            return $"{name} ({getDamageDice()} {getSign()} {damageModifier + statModifier})";
        }
        private string getDamageDice()
        {
            return string.Join(" + ", damageDice);
        }
        private string getSign()
        {
            string sign = "";
            if (damageModifier + statModifier > 0)
                sign = "+";
            return sign;
        }
    }
}
