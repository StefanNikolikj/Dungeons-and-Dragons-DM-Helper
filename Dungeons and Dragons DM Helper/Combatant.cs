using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons_DM_Helper
{
    public class Combatant
    {
        public string name {  get; set; }
        // Stats

        public List<int> stats {  get; set; } //(index of elements and their meanings) 0 - str, 1 - dex, 2 - con, 3 - int, 4 - wis, 5 - chr
        //public int strength;
        //public int dexterity;
        //public int constitution;
        //public int intelligence;
        //public int wisdom;
        //public int charisma;

        //health and armor class
        public int maxHP {  get; set; }
        public int currentHP { get; set; }
        public int tempHP { get; set; } // not sure if needed
        public int AC {  get; set; }
        //proficiency bonux
        public int proficiency { get; set; }
        //speeds
        public int movementSpeed { get; set; }
        public int burrowSpeed {  get; set; }
        public int swimSpeed {  get; set; }
        public int flyingSpeed {  get; set; }
        public int climbingSpeed {  get; set; } // dunno how neccecary this one is
        public int passivePerception {  get; set; }
        public int passiveInsight {  get; set; } // homebrew shit for Stefan

        public List<string> savingThrows { get; set; }
        public List<string> damageResistances { get; set; }
        public List<string> damageImmunities { get; set; }
        public List<string> damageVulnerabilities { get; set; }
        public List<string> conditionImmunities { get; set; }

        public int initiative { get; set; }

        public Combatant(string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, int hp, int ac, int proficiency,List<string> damageResistances, List<string> damageImmunities, List<string> damageVulnerabilities,List<string> savingThrows, int movementSpeed, int burrowSpeed, int swimSpeed, int flightSpeed, int climbingSpeed)
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
            this.initiative = 0;
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

        public override string ToString()
        {
            return $"{this.name} - Initiative: {this.initiative}";
        }
    }
}
