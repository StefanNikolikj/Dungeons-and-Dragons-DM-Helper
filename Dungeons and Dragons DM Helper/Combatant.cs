using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons_DM_Helper
{
    internal class Combatant
    {
        public string name;
        // Stats

        public List<int> stats; // 0 - str, 1 - dex, 2 - con, 3 - int, 4 - wis, 5 - chr
        //public int strength;
        //public int dexterity;
        //public int constitution;
        //public int intelligence;
        //public int wisdom;
        //public int charisma;

        //health and armor class
        public int maxHP;
        public int currentHP;
        public int tempHP; // not sure if needed
        public int AC;
        //proficiency bonux
        public int proficiency;
        //speeds
        public int movementSpeed;
        public int burrowSpeed;
        public int swimSpeed;
        public int flyingSpeed;
        public int climbingSpeed; // dunno how neccecary this one is
        public int passivePerception;
        public int passiveInsight; // homebrew shit for Stefan

        public List<int> savingThrows;
        public List<int> damageResistances;
        public List<int> damageImmunities;
        public List<int> damageVulnerabilities;
        public List<int> conditionImmunities;

        public Combatant(string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, int hp, int ac, int proficiency,List<int> damageResistances, List<int> damageImmunities, List<int> damageVulnerabilities,List<int> savingThrows)
        {
            this.name = name;
            this.stats = new List<int>();
            this.stats.Add( strength ); //0
            this.stats.Add( dexterity ); //1
            this.stats.Add ( constitution ); //2
            this.stats.Add( wisdom ); //3
            this.stats.Add( charisma );//4
            this.maxHP = hp;
            this.currentHP = hp;
            this.AC = ac;
            this.proficiency = proficiency;
            this.damageResistances = damageResistances;
            this.damageImmunities = damageImmunities;
            this.damageVulnerabilities = damageVulnerabilities;
            this.savingThrows = savingThrows;
            this.passivePerception = calculatePassivePerception();
        }

        public int modifierCalc(int stat)
        {
            int modifier = (int)Math.Floor(((double)stat / 2) - 5);
            return modifier;
        }
        private int calculatePassivePerception()
        {
            return 10 + modifierCalc(this.stats[4]);
        }

        List<String> damageTypes = new List<String>() {"Piercing", "Bludgeoning", "Slashing", "Cold", "Fire", "Lightning", "Thunder", "Poison", "Acid", "Necrotic", "Radiant", "Force", "Psychic"};

        List<String> conditions = new List<String>() {"Blinded", "Charmed", "Deafened", "Frightened", "Grappled", "Incapacitated", "Invisible", "Paralyzed", "Petrified", "Poisoned", "Prone", "Restrained", "Stunned", "Unconscious"};


    }
}
