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
    public partial class NewCombatant : Form
    {
        public Combatant combatant {  get; set; }
        public NewCombatant()
        {
            InitializeComponent();
        }

        private void btnAddCombatant_Click(object sender, EventArgs e)
        {
            List<string> damageResitances = addToList(clbResistances.CheckedItems);
            List<string> damageImmunities = addToList(clbImmunities.CheckedItems);
            List<string> damageVulnerabilities = addToList(clbVulnerabilities.CheckedItems);
            List<string> savingThrows = addToList(clbSavingThrows.CheckedItems);

            this.combatant = new Combatant(tbName.Text,(int)numStr.Value, (int)numDex.Value, (int)numCon.Value, (int)numInt.Value, (int)numWis.Value, (int)numChr.Value, (int)numHp.Value, (int)numAc.Value, (int)numProficiency.Value, damageResitances, damageImmunities, damageVulnerabilities, savingThrows, (int)numMovmentSpeed.Value, (int)numBurrowSpeed.Value, (int)numSwimSpeed.Value, (int)numFlyingSpeed.Value, (int)numClimbingSpeed.Value);

            this.DialogResult = DialogResult.OK;


        }

        private List<string> addToList(CheckedListBox.CheckedItemCollection selectedItems)
        {
            List<string> items = new List<string>();

            foreach (var item in selectedItems)
                items.Add(item.ToString());

            return items;
        }

        private void numStr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NewCombatant_Load(object sender, EventArgs e)
        {

        }
    }
}
