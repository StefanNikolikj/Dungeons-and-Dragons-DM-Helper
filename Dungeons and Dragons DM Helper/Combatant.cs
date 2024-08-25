using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeons_and_Dragons_DM_Helper
{
    internal class Combatant
    {
        public string name;
        public int strenght;
        public int dexterity;
        public int constitution;
        public int intelligence;
        public int wisdom;
        public int charisma;
        public int hp;
        public int AC;
        public int proficiency;
        public List<int> savingThrows = new List<int> ();
        public List<int> damageResistances = new List<int> ();
        public List<int> damageImmunities = new List<int> ();
        public List<int> damageVulnerabilities = new List<int> ();
        public List<int> conditionImmunities = new List<int> () ;

        public Combatant(string name, int strenght, int dexterity, int constitution, int intelligence, int wisdom, int charisma, int hp, int ac, int proficiency, List<int> damageResistances, List<int> damageImmunities, List<int> damageVulnerabilities, List<int> savingThrows)

        {
            this.name = name;
            this.strenght = strenght;
            this.dexterity = dexterity;
            this.constitution = constitution;
            this.intelligence = intelligence;
            this.wisdom = wisdom;
            this.charisma = charisma;
            this.hp = hp;
            this.AC = ac;
            this.proficiency = proficiency;
            this.damageResistances = damageResistances;
            this.damageImmunities = damageImmunities;
            this.damageVulnerabilities = damageVulnerabilities;
            this.savingThrows = savingThrows;
        }

        public int modifierCalc(int stat)
        {
            return stat / 2 - 5;
        }

        List<String> damageTypes = new List<String>() {"Piercing", "Bludgeoning", "Slashing", "Cold", "Fire", "Lightning", "Thunder", "Poison", "Acid", "Necrotic", "Radiant", "Force", "Psychic"};

        List<String> conditions = new List<String>() {"Blinded", "Charmed", "Deafened", "Frightened", "Grappled", "Incapacitated", "Invisible", "Paralyzed", "Petrified", "Poisoned", "Prone", "Restrained", "Stunned", "Unconscious"};


    }
}
