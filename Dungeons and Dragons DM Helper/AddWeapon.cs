using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

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
        private void AddWeapon_Load(object sender, EventArgs e)
        {
            ddDamageType.SelectedIndex = 0;
            ddWeaponType.SelectedIndex = 0;
        }

        private void btnd100_Click(object sender, EventArgs e)
        {
            btnd100.FlatAppearance.BorderColor = Color.LightBlue;
            btnd20.FlatAppearance.BorderColor = SystemColors.Control;
            btnd12.FlatAppearance.BorderColor = SystemColors.Control;
            btnd10.FlatAppearance.BorderColor = SystemColors.Control;
            btnd8.FlatAppearance.BorderColor = SystemColors.Control;
            btnd6.FlatAppearance.BorderColor = SystemColors.Control;
            btnd4.FlatAppearance.BorderColor = SystemColors.Control;
            setDice("d100");

        }

        private void btnd20_Click(object sender, EventArgs e)
        {
            btnd100.FlatAppearance.BorderColor = SystemColors.Control;
            btnd20.FlatAppearance.BorderColor = Color.LightBlue;
            btnd12.FlatAppearance.BorderColor = SystemColors.Control;
            btnd10.FlatAppearance.BorderColor = SystemColors.Control;
            btnd8.FlatAppearance.BorderColor = SystemColors.Control;
            btnd6.FlatAppearance.BorderColor = SystemColors.Control;
            btnd4.FlatAppearance.BorderColor = SystemColors.Control;
            setDice("d20");
        }

        private void btnd12_Click(object sender, EventArgs e)
        {
            btnd100.FlatAppearance.BorderColor = SystemColors.Control;
            btnd20.FlatAppearance.BorderColor = SystemColors.Control;
            btnd12.FlatAppearance.BorderColor = Color.LightBlue;
            btnd10.FlatAppearance.BorderColor = SystemColors.Control;
            btnd8.FlatAppearance.BorderColor = SystemColors.Control;
            btnd6.FlatAppearance.BorderColor = SystemColors.Control;
            btnd4.FlatAppearance.BorderColor = SystemColors.Control;
            setDice("d12");   
        }

        private void btnd10_Click(object sender, EventArgs e)
        {
            btnd100.FlatAppearance.BorderColor = SystemColors.Control;
            btnd20.FlatAppearance.BorderColor = SystemColors.Control;
            btnd12.FlatAppearance.BorderColor = SystemColors.Control;
            btnd10.FlatAppearance.BorderColor = Color.LightBlue;
            btnd8.FlatAppearance.BorderColor = SystemColors.Control;
            btnd6.FlatAppearance.BorderColor = SystemColors.Control;
            btnd4.FlatAppearance.BorderColor = SystemColors.Control;
            setDice("d10");
        }

        private void btnd8_Click(object sender, EventArgs e)
        {
            btnd100.FlatAppearance.BorderColor = SystemColors.Control;
            btnd20.FlatAppearance.BorderColor = SystemColors.Control;
            btnd12.FlatAppearance.BorderColor = SystemColors.Control;
            btnd10.FlatAppearance.BorderColor = SystemColors.Control;
            btnd8.FlatAppearance.BorderColor = Color.LightBlue;
            btnd6.FlatAppearance.BorderColor = SystemColors.Control;
            btnd4.FlatAppearance.BorderColor = SystemColors.Control;
            setDice("d8");
        }

        private void btnd6_Click(object sender, EventArgs e)
        {
            btnd100.FlatAppearance.BorderColor = SystemColors.Control;
            btnd20.FlatAppearance.BorderColor = SystemColors.Control;
            btnd12.FlatAppearance.BorderColor = SystemColors.Control;
            btnd10.FlatAppearance.BorderColor = SystemColors.Control;
            btnd8.FlatAppearance.BorderColor = SystemColors.Control;
            btnd6.FlatAppearance.BorderColor = Color.LightBlue;
            btnd4.FlatAppearance.BorderColor = SystemColors.Control;
            setDice("d6");
        }

        private void btnd4_Click(object sender, EventArgs e)
        {
            btnd100.FlatAppearance.BorderColor = SystemColors.Control;
            btnd20.FlatAppearance.BorderColor = SystemColors.Control;
            btnd12.FlatAppearance.BorderColor = SystemColors.Control;
            btnd10.FlatAppearance.BorderColor = SystemColors.Control;
            btnd8.FlatAppearance.BorderColor = SystemColors.Control;
            btnd6.FlatAppearance.BorderColor = SystemColors.Control;
            btnd4.FlatAppearance.BorderColor = Color.LightBlue;
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
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                tbName.Focus();
                epAddWeapon.SetError(tbName, "Please enter a name");
                return;
            }
            weapon = new Weapon(tbName.Text, diceList, Convert.ToInt32(numDamageModifier.Value), ddWeaponType.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                epAddWeapon.SetError(tbName, "Please enter a name");
                e.Cancel = true;
            }
            else
            {
                epAddWeapon.SetError(tbName, null);
                e.Cancel = false;
            }
        }


    }
}
