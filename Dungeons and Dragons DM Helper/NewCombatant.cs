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
        List<Weapon> weaponList;
        public Combatant combatant {  get; set; }
        public NewCombatant()
        {
            InitializeComponent();
            weaponList = new List<Weapon>();
        }

        private void btnAddCombatant_Click(object sender, EventArgs e)
        {
            HashSet<string> damageResitances = addToSet(clbResistances.CheckedItems);
            HashSet<string> damageImmunities = addToSet(clbImmunities.CheckedItems);
            HashSet<string> damageVulnerabilities = addToSet(clbVulnerabilities.CheckedItems);
            HashSet<string> savingThrows = addToSet(clbSavingThrows.CheckedItems);

            this.combatant = new Combatant(tbName.Text,(int)numStr.Value, (int)numDex.Value, (int)numCon.Value, (int)numInt.Value, (int)numWis.Value, (int)numChr.Value, (int)numHp.Value, (int)numAc.Value, (int)numProficiency.Value, damageResitances, damageImmunities, damageVulnerabilities, savingThrows, (int)numMovmentSpeed.Value, (int)numBurrowSpeed.Value, (int)numSwimSpeed.Value, (int)numFlyingSpeed.Value, (int)numClimbingSpeed.Value, getListofWeapons());

            this.DialogResult = DialogResult.OK;


        }

        private HashSet<string> addToSet(CheckedListBox.CheckedItemCollection selectedItems)
        {
            HashSet<string> items = new HashSet<string>();

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

        private void btnAddWeapon_Click(object sender, EventArgs e)
        {
            AddWeapon addWeapon = new AddWeapon();

            if (addWeapon.ShowDialog() == DialogResult.OK)
            {
                lbWeapons.Items.Add(addWeapon.weapon);
            }
        }

        private void btnRemoveWeapon_Click(object sender, EventArgs e)
        {
            if (lbWeapons.Items.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to remove this weapon/attack from the list?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbWeapons.Items.RemoveAt(lbWeapons.SelectedIndex);
                }
            }
        }
        private List<Weapon> getListofWeapons()
        {
            List<Weapon> weapons = new List<Weapon>();
            foreach (var item in lbWeapons.Items)
            {
                Weapon weapon = item as Weapon;
                weapons.Add(weapon);
            }
            return weapons;
        }
    }
}
