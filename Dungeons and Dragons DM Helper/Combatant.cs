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

        public Combatant(string name, int strenght, int dexterity, int constitution, int intelligence, int wisdom, int charisma, int hp, int ac, int proficiency)
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
        }

        public int modifierCalc(int stat)
        {
            return stat / 2 - 5;
        }
    }
}
