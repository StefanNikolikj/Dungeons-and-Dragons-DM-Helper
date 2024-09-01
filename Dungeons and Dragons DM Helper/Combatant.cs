using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons_DM_Helper
{
    [Serializable]
    public class Combatant
    {
        public string name {  get; set; }
        // Stats

        public List<int> stats {  get; set; } //(index of elements and their meanings) 0 - str, 1 - dex, 2 - con, 3 - int, 4 - wis, 5 - chr

        //health and armor class
        public int maxHP {  get; set; }
        public int currentHP { get; set; }
        public int tempHP { get; set; } // not sure if needed
        public int AC {  get; set; }
        //proficiency bonus
        public int proficiency { get; set; }
        //speeds
        public int movementSpeed { get; set; }
        public int burrowSpeed {  get; set; }
        public int swimSpeed {  get; set; }
        public int flyingSpeed {  get; set; }
        public int climbingSpeed {  get; set; } // dunno how neccecary this one is
        public int passivePerception {  get; set; }

        public HashSet<string> savingThrows { get; set; }
        public HashSet<string> damageResistances { get; set; }
        public HashSet<string> damageImmunities { get; set; }
        public HashSet<string> damageVulnerabilities { get; set; }
        public HashSet<string> conditionImmunities { get; set; }
        
        public List<Weapon> weapons { get; set; }

        public int initiative { get; set; }
        
        public Combatant()
        {

        }

        public Combatant(string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, int hp, int ac, int proficiency,HashSet<string> damageResistances, HashSet<string> damageImmunities, HashSet<string> damageVulnerabilities,HashSet<string> savingThrows, int movementSpeed, int burrowSpeed, int swimSpeed, int flightSpeed, int climbingSpeed, List<Weapon> weapons)
        {
            this.name = name;
            this.stats = new List<int>();
            this.stats.Add( strength ); //0
            this.stats.Add( dexterity ); //1
            this.stats.Add ( constitution ); //2
            this.stats.Add(intelligence); //3
            this.stats.Add( wisdom ); //4
            this.stats.Add( charisma );//5
            this.maxHP = hp;
            this.currentHP = hp;
            this.AC = ac;
            this.proficiency = proficiency;
            this.damageResistances = damageResistances;
            this.damageImmunities = damageImmunities;
            this.damageVulnerabilities = damageVulnerabilities;
            this.savingThrows = savingThrows;
            this.passivePerception = calculatePassivePerception();
            this.initiative = 0;
            this.movementSpeed = movementSpeed;
            this.burrowSpeed = burrowSpeed;
            this.swimSpeed = swimSpeed;
            this.flyingSpeed = flightSpeed;
            this.climbingSpeed = climbingSpeed;
            this.weapons = weapons;
        }

        public int modifierCalc(int stat)
        {
            int modifier = ((stat / 2) - 5);
            return modifier;
        }
        private int calculatePassivePerception()
        {
            return 10 + modifierCalc(this.stats[4]);
        }
        

        List<String> damageTypes = new List<String>() {"Piercing", "Bludgeoning", "Slashing", "Cold", "Fire", "Lightning", "Thunder", "Poison", "Acid", "Necrotic", "Radiant", "Force", "Psychic"};

        List<String> conditions = new List<String>() {"Blinded", "Charmed", "Deafened", "Frightened", "Grappled", "Incapacitated", "Invisible", "Paralyzed", "Petrified", "Poisoned", "Prone", "Restrained", "Stunned", "Unconscious"};

        public override string ToString()
        {
            return $"{this.name} - Initiative: {this.initiative}";
        }

        public bool rollSavingThrow (int DC, int stat)
        {
            int save = Dice.rollDice(20) + stats[stat];

            if (save >= DC) {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int getStat(string statName)
        {
            switch (statName)
            {
                case "Strength":
                case "Str":
                    return 0;
                case "Dexterity":
                case "Dex":
                    return 1;
                case "Constitution":
                case "Con":
                    return 2;
                case "Inteligence":
                case "Int":
                    return 3;
                case "Wisdom":
                case "Wis":
                    return 4;
                case "Charisma":
                case "Chr":
                    return 5;
                default:
                    return -1;
            }
        }
        public int getSavingThrowModifier(string stat) 
        {
            int total = modifierCalc(stats[getStat(stat)]);
            foreach (string savingThrow in savingThrows)
            {
                if (savingThrow.CompareTo(stat) == 0)
                    total += proficiency;
            }
            return total;
        }
        public bool isResistant(string damageType)
        {
            return damageResistances.Contains(damageType);
        }
        public bool isImmune(string damageType)
        {
            return damageImmunities.Contains(damageType);
        }
        public bool isVulnerable(string damageType)
        {
            return damageVulnerabilities.Contains(damageType);
        }
        public void dealDamage(int damage)
        {
            this.currentHP -= damage;
            if (currentHP < 0)
                this.currentHP = 0;
        }
    }
}
