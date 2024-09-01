using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.InteropServices;

namespace Dungeons_and_Dragons_DM_Helper
{
    public partial class CombatTracker : Form
    {
        public string FileName { get; set; }
        public CombatTracker()
        {
            InitializeComponent();
            FileName = "";
        }

        private void lbCombatants_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void btnAddCombatant_Click(object sender, EventArgs e)
        {
            NewCombatant newCombatant = new NewCombatant();

            if (newCombatant.ShowDialog() == DialogResult.OK)
            {
                lbCombatants.Items.Add(newCombatant.combatant);
            }
        }
        private void btnRemoveCombatant_Click(object sender, EventArgs e)
        {
            if (lbCombatants.SelectedIndex == -1)
            {
                epCombatTracker.SetError(lbCombatants, "Please select a Combatant");
                return;
            }
            if (lbCombatants.Items.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to remove this character from the combat?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lbCombatants.Items.RemoveAt(lbCombatants.SelectedIndex);
                }
            }
        }

        private void btnRollInitiative_Click(object sender, EventArgs e)
        {
            if (getListOfSelectedCombatants().Count == 0)
            {
                epCombatTracker.SetError(lbCombatants, "Please select a Combatant");
                return;
            }
            List<Combatant> combatants = getListOfSelectedCombatants();
            foreach (Combatant combatant in combatants)
            {
                combatant.initiative = Dice.rollDice(20) + combatant.modifierCalc(combatant.stats[1]);
                lbCombatants.Items[lbCombatants.Items.IndexOf(combatant)] = combatant;
            }
            sortCombatants();
            
        }
        private List<Combatant> getListOfSelectedCombatants()
        {
            List<Combatant> tempList = new List<Combatant>();
            foreach (var item in lbCombatants.SelectedItems)
            {
                Combatant temp = item as Combatant;
                tempList.Add(temp);
            }
            return tempList;
        }
        private void updateCombatants(List<Combatant> combatants)
        {
            lbCombatants.Items.Clear();
            foreach (var combatant in combatants)
            {
                lbCombatants.Items.Add(combatant);
            }
            updateDisplay();
        }
        private List<Combatant> getListOfEveryCombatant()
        {
            List<Combatant> tempList = new List<Combatant>();
            foreach (var item in lbCombatants.Items)
            {
                Combatant temp = item as Combatant;
                tempList.Add(temp);
            }
            return tempList;
        }
        private void sortCombatants()
        {
            List<Combatant> combatants = getListOfEveryCombatant();
            combatants.Sort((a, b) => b.initiative.CompareTo(a.initiative));
            updateCombatants(combatants);
        }

        private void btnManualInitiative_Click(object sender, EventArgs e)
        {
            if (lbCombatants.SelectedIndex == -1)
            {
                epCombatTracker.SetError(lbCombatants, "Please select a Combatant");
                return;
            }
            SetInitiative setInitiative = new SetInitiative();

            if (setInitiative.ShowDialog() == DialogResult.OK)
            {
                Combatant temp = lbCombatants.SelectedItem as Combatant;
                temp.initiative = setInitiative.initiative;
                lbCombatants.SelectedItem = temp;
                sortCombatants();
            }
        }

        private void updateDisplay()
        {
            if (lbCombatants.SelectedIndex >= 0)
            {
                Combatant combatant = lbCombatants.SelectedItem as Combatant;

                tbName.Text = combatant.name;
                tbProficiency.Text = $"+{combatant.proficiency}";
                tbPassivePerception.Text = combatant.passivePerception.ToString();
                tbTotalHP.Text = combatant.maxHP.ToString();
                tbAC.Text = combatant.AC.ToString();

                tbCurrentHP.Text = combatant.currentHP.ToString();
                pbCurrentHP.Maximum = combatant.maxHP;
                pbCurrentHP.Value = combatant.currentHP;

                tbStr.Text = $"{combatant.stats[0]} ({getSign(combatant.modifierCalc(combatant.stats[0]))}{combatant.modifierCalc(combatant.stats[0])})";
                tbDex.Text = $"{combatant.stats[1]} ({getSign(combatant.modifierCalc(combatant.stats[1]))}{combatant.modifierCalc(combatant.stats[1])})";
                tbCon.Text = $"{combatant.stats[2]} ({getSign(combatant.modifierCalc(combatant.stats[2]))}{combatant.modifierCalc(combatant.stats[2])})";
                tbInt.Text = $"{combatant.stats[3]} ({getSign(combatant.modifierCalc(combatant.stats[3]))}{combatant.modifierCalc(combatant.stats[3])})";
                tbWis.Text = $"{combatant.stats[4]} ({getSign(combatant.modifierCalc(combatant.stats[4]))}{combatant.modifierCalc(combatant.stats[4])})";
                tbChr.Text = $"{combatant.stats[5]} ({getSign(combatant.modifierCalc(combatant.stats[5]))}{combatant.modifierCalc(combatant.stats[5])})";

                tbStrSave.Text = $"{getSign(getSavingThrow("Strength"))}{getSavingThrow("Strength")}";
                tbDexSave.Text = $"{getSign(getSavingThrow("Dexterity"))}{getSavingThrow("Dexterity")}";
                tbConSave.Text = $"{getSign(getSavingThrow("Constitution"))}{getSavingThrow("Constitution")}";
                tbIntSave.Text = $"{getSign(getSavingThrow("Inteligence"))}{getSavingThrow("Inteligence")}";
                tbWisSave.Text = $"{getSign(getSavingThrow("Wisdom"))}{getSavingThrow("Wisdom")}";
                tbChrSave.Text = $"{getSign(getSavingThrow("Charisma"))}{getSavingThrow("Charisma")}";

                tbMovementSpeed.Text = $"{combatant.movementSpeed}ft";
                tbBurrowSpeed.Text = $"{combatant.burrowSpeed}ft";
                tbSwimSpeed.Text = $"{combatant.swimSpeed}ft";
                tbFlyingSpeed.Text = $"{combatant.flyingSpeed}ft";
                tbClimbingSpeed.Text = $"{combatant.climbingSpeed}ft";

                tbResistances.Text = toTextBox(combatant.damageResistances);
                tbImmunities.Text = toTextBox(combatant.damageImmunities);
                tbVulnerabilities.Text = toTextBox(combatant.damageVulnerabilities);

                updateWeapons(combatant.weapons);
            }
        }
        private int getSavingThrow(string stat)
        {
            Combatant combatant = lbCombatants.SelectedItem as Combatant;
            return combatant.getSavingThrowModifier(stat);
        }

        private string toTextBox(HashSet<string> set)
        {
            if (set.Count != 0)
                return string.Join(", ", set);
            else return "None";
        }

        private void btnRollSavingThrows_Click(object sender, EventArgs e)
        {
            if (getListOfSelectedCombatants().Count == 0)
            {
                epCombatTracker.SetError(lbCombatants, "Please select a Combatant");
                return;
            }
            List<Combatant> listOfSelectedCombatants = getListOfSelectedCombatants();
            
            SavingThrow savingThrow = new SavingThrow(listOfSelectedCombatants);

            if (savingThrow.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < lbCombatants.SelectedIndices.Count; i++)
                {
                    lbCombatants.Items[lbCombatants.SelectedIndices[i]] = savingThrow.combatants[i];
                    checkForHp(savingThrow.combatants[i]);
                }
                updateDisplay();
            }
        }
        private string getSign(int modifier)
        {
            string sign = "";
            if (modifier >= 0)
                sign = "+";
            return sign;
        }

        private void btnSetHP_Click(object sender, EventArgs e)
        {
            if (lbCombatants.SelectedIndex == -1)
            {
                epCombatTracker.SetError(lbCombatants, "Please select a Combatant");
                return;
            }
            Combatant combatant = lbCombatants.SelectedItem as Combatant; 
            SetHP setHP = new SetHP(combatant.currentHP,combatant.maxHP);

            if (setHP.ShowDialog() == DialogResult.OK)
            {
                combatant.currentHP = setHP.hp;
                checkForHp(combatant);
                updateDisplay();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                deserializeFile(FileName);

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List <Combatant> combatants = getListOfEveryCombatant();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = saveFileDialog.FileName;
                serializeFile(FileName,combatants);
                
            }
        }
        private void serializeFile(string path,List<Combatant> combatants)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Combatant>));

            using (FileStream fstream = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(fstream, combatants);
            }
        }
        private void deserializeFile(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Combatant>));

            using (FileStream fstream = new FileStream(path, FileMode.Open))
            {
                List<Combatant> newCombatants = (List<Combatant>)serializer.Deserialize(fstream);
                updateCombatants(newCombatants);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbCombatants.Items.Clear();
        }
        private void updateWeapons(List<Weapon> weapons)
        {
            lbWeapons.Items.Clear();
            foreach (Weapon weapon in weapons)
            {
                lbWeapons.Items.Add(weapon);
            }
        }

        private void btnAddWeapon_Click(object sender, EventArgs e)
        {
            if (lbCombatants.SelectedIndex == -1)
            {
                epCombatTracker.SetError(lbCombatants, "Please select a Combatant");
                return;
            }
            Combatant combatant = lbCombatants.SelectedItem as Combatant;
            AddWeapon addWeapon = new AddWeapon();
            if (addWeapon.ShowDialog() == DialogResult.OK)
            {
                Weapon weapon = addWeapon.weapon;
                switch (weapon.weaponType)
                {
                    case "Strength":
                        weapon.statModifier = combatant.modifierCalc(combatant.stats[0]);
                        break;
                    case "Dexterity":
                        weapon.statModifier = combatant.modifierCalc(combatant.stats[1]);
                        break;
                }
                combatant.weapons.Add(weapon);
                updateDisplay();
            }
        }

        private void btnRemoveWeapon_Click(object sender, EventArgs e)
        {
            if (lbWeapons.SelectedIndex == -1)
            {
                epCombatTracker.SetError(lbWeapons, "Please select a Weapon");
                return;
            }

            if (lbWeapons.Items.Count > 0)
            {
                Combatant combatant = lbCombatants.SelectedItem as Combatant;
                if (MessageBox.Show("Are you sure you want to remove this weapon/attack from the list?", "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    combatant.weapons.RemoveAt(lbWeapons.SelectedIndex);
                    updateDisplay();
                }
            }
        }

        private void btnMakeAnAttack_Click(object sender, EventArgs e)
        {
            if (lbCombatants.SelectedIndex == -1)
            {
                epCombatTracker.SetError(lbCombatants, "Please select a Combatant");
                return;
            }
            else if (lbWeapons.SelectedIndex == -1)
            {
                epCombatTracker.SetError(lbWeapons, "Please select a Weapon");
                return;
            }
            List<Combatant> combatants = getListOfEveryCombatant();
            Combatant selectedCombatant = lbCombatants.SelectedItem as Combatant;
            Weapon selectedWeapon = lbWeapons.SelectedItem as Weapon;

            combatants.RemoveAt(lbCombatants.SelectedIndex);
            MakeAnAttack makeAnAttack = new MakeAnAttack(combatants, selectedCombatant, selectedWeapon);

            if(makeAnAttack.ShowDialog() == DialogResult.Yes)
            {
                checkForHp(makeAnAttack.defendingCombatant);
            }
        }
        private void checkForHp(Combatant combatant)
        {
            if (combatant.currentHP == 0)
                lbCombatants.Items.Remove(combatant);
        }

        private void lbCombatants_Validating(object sender, CancelEventArgs e)
        {
            if (lbCombatants.SelectedIndex == -1)
            {
                epCombatTracker.SetError(lbCombatants, "Please select a Combatant");
                e.Cancel = true;
            }
            else
            {
                epCombatTracker.SetError(lbCombatants, null);
                e.Cancel = false;
            }
        }

        private void lbWeapons_Validating(object sender, CancelEventArgs e)
        {
            if (lbWeapons.SelectedIndex == -1)
            {
                epCombatTracker.SetError(lbWeapons, "Please select a Weapon");
                e.Cancel = true;
            }
            else
            {
                epCombatTracker.SetError(lbWeapons, null);
                e.Cancel = false;
            }
        }
    }
}
