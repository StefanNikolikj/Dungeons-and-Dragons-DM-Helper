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
    public partial class AddWeapon : Form
    {
        List<string> diceList { get; set; }
        string currentDamageDice;
        public Weapon weapon { get; set; }
        public AddWeapon()
        {
            InitializeComponent();
            diceList = new List<string>();
        }

        private void btnd100_Click(object sender, EventArgs e)
        {
            setDice("d100");
        }

        private void btnd20_Click(object sender, EventArgs e)
        {
            setDice("d20");
        }

        private void btnd12_Click(object sender, EventArgs e)
        {
            setDice("d12");   
        }

        private void btnd10_Click(object sender, EventArgs e)
        {
            setDice("d10");
        }

        private void btnd8_Click(object sender, EventArgs e)
        {
            setDice("d8");
        }

        private void btnd6_Click(object sender, EventArgs e)
        {
            setDice("d6");
        }

        private void btnd4_Click(object sender, EventArgs e)
        {
            setDice("d4");
        }

        private void setDice (string damageDice)
        {
            gbRollDamage.Enabled = true;
            currentDamageDice = damageDice;
        }

        private void btnAddDice_Click(object sender, EventArgs e)
        {
            diceList.Add($"{Convert.ToInt32(numNumberOfDice.Value)}{currentDamageDice} {ddDamageType.SelectedItem.ToString()}");
            updateTextBox();
        }
        private void updateTextBox()
        {
            tbRollTotal.Text = string.Join(" + ", diceList);
        }

        private void btnResetDice_Click(object sender, EventArgs e)
        {
            tbRollTotal.Text = "";
            diceList.Clear();
        }

        private void btnAddWeapom_Click(object sender, EventArgs e)
        {
            weapon = new Weapon(tbName.Text, diceList, Convert.ToInt32(numDamageModifier.Value), ddWeaponType.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
