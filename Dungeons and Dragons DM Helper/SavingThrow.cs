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
        List<Combatant> combatants {  get; set; }
        public SavingThrow(List<Combatant> combatants)
        {
            InitializeComponent();
            this.combatants = combatants;
        }

        private void btnRollSaveThrows_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Combatant combatant in this.combatants)
            {
                bool isSaved = false;
                int roll = rollSavingThrow(combatant);
                if (roll >= Convert.ToInt32(numSaveDC.Value))
                    isSaved = true;

                sb.Append($"{combatant.name}: {roll} - {isSaved}\n");
            }
            rtbRollResults.Text = sb.ToString();
        }
        private int rollSavingThrow(Combatant combatant)
        {

            int result = Dice.rollDice(20) + combatant.getSavingThrowModifier(cbSavingThrowType.SelectedItem.ToString());
            return result;
        }
    }
}
