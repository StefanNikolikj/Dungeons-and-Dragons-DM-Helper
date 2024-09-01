namespace Dungeons_and_Dragons_DM_Helper
{
    partial class CombatTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCombatants = new System.Windows.Forms.ListBox();
            this.btnRollInitiative = new System.Windows.Forms.Button();
            this.btnAddCombatant = new System.Windows.Forms.Button();
            this.gbDisplayCombatant = new System.Windows.Forms.GroupBox();
            this.btnSetHP = new System.Windows.Forms.Button();
            this.tbPassivePerception = new System.Windows.Forms.TextBox();
            this.lblPassivePerception = new System.Windows.Forms.Label();
            this.tbVulnerabilities = new System.Windows.Forms.TextBox();
            this.tbImmunities = new System.Windows.Forms.TextBox();
            this.tbResistances = new System.Windows.Forms.TextBox();
            this.lblVulnerabilities = new System.Windows.Forms.Label();
            this.lblImmunities = new System.Windows.Forms.Label();
            this.lblResistances = new System.Windows.Forms.Label();
            this.tbCurrentHP = new System.Windows.Forms.TextBox();
            this.pbCurrentHP = new System.Windows.Forms.ProgressBar();
            this.lblCurrentHP = new System.Windows.Forms.Label();
            this.tbAC = new System.Windows.Forms.TextBox();
            this.tbTotalHP = new System.Windows.Forms.TextBox();
            this.lblAC = new System.Windows.Forms.Label();
            this.lblTotalHP = new System.Windows.Forms.Label();
            this.tbProficiency = new System.Windows.Forms.TextBox();
            this.gbSavingThrows = new System.Windows.Forms.GroupBox();
            this.tbChrSave = new System.Windows.Forms.TextBox();
            this.tbWisSave = new System.Windows.Forms.TextBox();
            this.tbIntSave = new System.Windows.Forms.TextBox();
            this.tbConSave = new System.Windows.Forms.TextBox();
            this.tbDexSave = new System.Windows.Forms.TextBox();
            this.tbStrSave = new System.Windows.Forms.TextBox();
            this.lblChrSave = new System.Windows.Forms.Label();
            this.lblWisSave = new System.Windows.Forms.Label();
            this.lblIntSave = new System.Windows.Forms.Label();
            this.lblConSave = new System.Windows.Forms.Label();
            this.lblDexSave = new System.Windows.Forms.Label();
            this.lblStrSave = new System.Windows.Forms.Label();
            this.lblProficiency = new System.Windows.Forms.Label();
            this.gbSpeed = new System.Windows.Forms.GroupBox();
            this.tbClimbingSpeed = new System.Windows.Forms.TextBox();
            this.tbFlyingSpeed = new System.Windows.Forms.TextBox();
            this.tbSwimSpeed = new System.Windows.Forms.TextBox();
            this.tbBurrowSpeed = new System.Windows.Forms.TextBox();
            this.tbMovementSpeed = new System.Windows.Forms.TextBox();
            this.lblClimbingSpeed = new System.Windows.Forms.Label();
            this.lblFlightSpeed = new System.Windows.Forms.Label();
            this.lblSwimSpeed = new System.Windows.Forms.Label();
            this.lblBurrowSpeed = new System.Windows.Forms.Label();
            this.lblMovementSpeed = new System.Windows.Forms.Label();
            this.gbStats = new System.Windows.Forms.GroupBox();
            this.tbChr = new System.Windows.Forms.TextBox();
            this.tbWis = new System.Windows.Forms.TextBox();
            this.tbInt = new System.Windows.Forms.TextBox();
            this.tbCon = new System.Windows.Forms.TextBox();
            this.tbDex = new System.Windows.Forms.TextBox();
            this.tbStr = new System.Windows.Forms.TextBox();
            this.lblChr = new System.Windows.Forms.Label();
            this.lblWis = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRollSavingThrows = new System.Windows.Forms.Button();
            this.btnManualInitiative = new System.Windows.Forms.Button();
            this.btnRemoveCombatant = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDisplayCombatant.SuspendLayout();
            this.gbSavingThrows.SuspendLayout();
            this.gbSpeed.SuspendLayout();
            this.gbStats.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCombatants
            // 
            this.lbCombatants.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCombatants.FormattingEnabled = true;
            this.lbCombatants.ItemHeight = 20;
            this.lbCombatants.Location = new System.Drawing.Point(12, 27);
            this.lbCombatants.Name = "lbCombatants";
            this.lbCombatants.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbCombatants.Size = new System.Drawing.Size(236, 484);
            this.lbCombatants.TabIndex = 0;
            this.lbCombatants.SelectedIndexChanged += new System.EventHandler(this.lbCombatants_SelectedIndexChanged);
            // 
            // btnRollInitiative
            // 
            this.btnRollInitiative.Location = new System.Drawing.Point(12, 535);
            this.btnRollInitiative.Name = "btnRollInitiative";
            this.btnRollInitiative.Size = new System.Drawing.Size(236, 23);
            this.btnRollInitiative.TabIndex = 1;
            this.btnRollInitiative.Text = "Roll Initiatives of Selected Combatants";
            this.btnRollInitiative.UseVisualStyleBackColor = true;
            this.btnRollInitiative.Click += new System.EventHandler(this.btnRollInitiative_Click);
            // 
            // btnAddCombatant
            // 
            this.btnAddCombatant.Location = new System.Drawing.Point(256, 27);
            this.btnAddCombatant.Name = "btnAddCombatant";
            this.btnAddCombatant.Size = new System.Drawing.Size(187, 23);
            this.btnAddCombatant.TabIndex = 2;
            this.btnAddCombatant.Text = "Add new Combatant";
            this.btnAddCombatant.UseVisualStyleBackColor = true;
            this.btnAddCombatant.Click += new System.EventHandler(this.btnAddCombatant_Click);
            // 
            // gbDisplayCombatant
            // 
            this.gbDisplayCombatant.Controls.Add(this.btnSetHP);
            this.gbDisplayCombatant.Controls.Add(this.tbPassivePerception);
            this.gbDisplayCombatant.Controls.Add(this.lblPassivePerception);
            this.gbDisplayCombatant.Controls.Add(this.tbVulnerabilities);
            this.gbDisplayCombatant.Controls.Add(this.tbImmunities);
            this.gbDisplayCombatant.Controls.Add(this.tbResistances);
            this.gbDisplayCombatant.Controls.Add(this.lblVulnerabilities);
            this.gbDisplayCombatant.Controls.Add(this.lblImmunities);
            this.gbDisplayCombatant.Controls.Add(this.lblResistances);
            this.gbDisplayCombatant.Controls.Add(this.tbCurrentHP);
            this.gbDisplayCombatant.Controls.Add(this.pbCurrentHP);
            this.gbDisplayCombatant.Controls.Add(this.lblCurrentHP);
            this.gbDisplayCombatant.Controls.Add(this.tbAC);
            this.gbDisplayCombatant.Controls.Add(this.tbTotalHP);
            this.gbDisplayCombatant.Controls.Add(this.lblAC);
            this.gbDisplayCombatant.Controls.Add(this.lblTotalHP);
            this.gbDisplayCombatant.Controls.Add(this.tbProficiency);
            this.gbDisplayCombatant.Controls.Add(this.gbSavingThrows);
            this.gbDisplayCombatant.Controls.Add(this.lblProficiency);
            this.gbDisplayCombatant.Controls.Add(this.gbSpeed);
            this.gbDisplayCombatant.Controls.Add(this.gbStats);
            this.gbDisplayCombatant.Controls.Add(this.tbName);
            this.gbDisplayCombatant.Controls.Add(this.lblName);
            this.gbDisplayCombatant.Location = new System.Drawing.Point(449, 27);
            this.gbDisplayCombatant.Name = "gbDisplayCombatant";
            this.gbDisplayCombatant.Size = new System.Drawing.Size(1157, 560);
            this.gbDisplayCombatant.TabIndex = 3;
            this.gbDisplayCombatant.TabStop = false;
            this.gbDisplayCombatant.Text = "Display Combatant";
            // 
            // btnSetHP
            // 
            this.btnSetHP.Location = new System.Drawing.Point(641, 115);
            this.btnSetHP.Name = "btnSetHP";
            this.btnSetHP.Size = new System.Drawing.Size(75, 23);
            this.btnSetHP.TabIndex = 40;
            this.btnSetHP.Text = "Set HP";
            this.btnSetHP.UseVisualStyleBackColor = true;
            this.btnSetHP.Click += new System.EventHandler(this.btnSetHP_Click);
            // 
            // tbPassivePerception
            // 
            this.tbPassivePerception.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassivePerception.Location = new System.Drawing.Point(157, 98);
            this.tbPassivePerception.Name = "tbPassivePerception";
            this.tbPassivePerception.ReadOnly = true;
            this.tbPassivePerception.Size = new System.Drawing.Size(82, 26);
            this.tbPassivePerception.TabIndex = 39;
            // 
            // lblPassivePerception
            // 
            this.lblPassivePerception.AutoSize = true;
            this.lblPassivePerception.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassivePerception.Location = new System.Drawing.Point(154, 79);
            this.lblPassivePerception.Name = "lblPassivePerception";
            this.lblPassivePerception.Size = new System.Drawing.Size(142, 16);
            this.lblPassivePerception.TabIndex = 38;
            this.lblPassivePerception.Text = "Passive Perception";
            // 
            // tbVulnerabilities
            // 
            this.tbVulnerabilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVulnerabilities.Location = new System.Drawing.Point(137, 517);
            this.tbVulnerabilities.Name = "tbVulnerabilities";
            this.tbVulnerabilities.ReadOnly = true;
            this.tbVulnerabilities.Size = new System.Drawing.Size(681, 26);
            this.tbVulnerabilities.TabIndex = 37;
            // 
            // tbImmunities
            // 
            this.tbImmunities.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbImmunities.Location = new System.Drawing.Point(137, 472);
            this.tbImmunities.Name = "tbImmunities";
            this.tbImmunities.ReadOnly = true;
            this.tbImmunities.Size = new System.Drawing.Size(681, 26);
            this.tbImmunities.TabIndex = 36;
            // 
            // tbResistances
            // 
            this.tbResistances.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResistances.Location = new System.Drawing.Point(137, 427);
            this.tbResistances.Name = "tbResistances";
            this.tbResistances.ReadOnly = true;
            this.tbResistances.Size = new System.Drawing.Size(681, 26);
            this.tbResistances.TabIndex = 35;
            // 
            // lblVulnerabilities
            // 
            this.lblVulnerabilities.AutoSize = true;
            this.lblVulnerabilities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVulnerabilities.Location = new System.Drawing.Point(17, 523);
            this.lblVulnerabilities.Name = "lblVulnerabilities";
            this.lblVulnerabilities.Size = new System.Drawing.Size(91, 16);
            this.lblVulnerabilities.TabIndex = 34;
            this.lblVulnerabilities.Text = "Vulnerabilities";
            // 
            // lblImmunities
            // 
            this.lblImmunities.AutoSize = true;
            this.lblImmunities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImmunities.Location = new System.Drawing.Point(17, 478);
            this.lblImmunities.Name = "lblImmunities";
            this.lblImmunities.Size = new System.Drawing.Size(70, 16);
            this.lblImmunities.TabIndex = 33;
            this.lblImmunities.Text = "Immunities";
            // 
            // lblResistances
            // 
            this.lblResistances.AutoSize = true;
            this.lblResistances.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResistances.Location = new System.Drawing.Point(17, 433);
            this.lblResistances.Name = "lblResistances";
            this.lblResistances.Size = new System.Drawing.Size(82, 16);
            this.lblResistances.TabIndex = 32;
            this.lblResistances.Text = "Resistances";
            // 
            // tbCurrentHP
            // 
            this.tbCurrentHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentHP.Location = new System.Drawing.Point(651, 51);
            this.tbCurrentHP.Name = "tbCurrentHP";
            this.tbCurrentHP.ReadOnly = true;
            this.tbCurrentHP.Size = new System.Drawing.Size(47, 29);
            this.tbCurrentHP.TabIndex = 31;
            // 
            // pbCurrentHP
            // 
            this.pbCurrentHP.Location = new System.Drawing.Point(535, 86);
            this.pbCurrentHP.Name = "pbCurrentHP";
            this.pbCurrentHP.Size = new System.Drawing.Size(283, 23);
            this.pbCurrentHP.TabIndex = 30;
            // 
            // lblCurrentHP
            // 
            this.lblCurrentHP.AutoSize = true;
            this.lblCurrentHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentHP.Location = new System.Drawing.Point(612, 23);
            this.lblCurrentHP.Name = "lblCurrentHP";
            this.lblCurrentHP.Size = new System.Drawing.Size(128, 25);
            this.lblCurrentHP.TabIndex = 29;
            this.lblCurrentHP.Text = "Current HP";
            // 
            // tbAC
            // 
            this.tbAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAC.Location = new System.Drawing.Point(428, 57);
            this.tbAC.Name = "tbAC";
            this.tbAC.ReadOnly = true;
            this.tbAC.Size = new System.Drawing.Size(46, 29);
            this.tbAC.TabIndex = 28;
            // 
            // tbTotalHP
            // 
            this.tbTotalHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalHP.Location = new System.Drawing.Point(320, 57);
            this.tbTotalHP.Name = "tbTotalHP";
            this.tbTotalHP.ReadOnly = true;
            this.tbTotalHP.Size = new System.Drawing.Size(47, 29);
            this.tbTotalHP.TabIndex = 27;
            // 
            // lblAC
            // 
            this.lblAC.AutoSize = true;
            this.lblAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAC.Location = new System.Drawing.Point(431, 29);
            this.lblAC.Name = "lblAC";
            this.lblAC.Size = new System.Drawing.Size(43, 25);
            this.lblAC.TabIndex = 26;
            this.lblAC.Text = "AC";
            // 
            // lblTotalHP
            // 
            this.lblTotalHP.AutoSize = true;
            this.lblTotalHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHP.Location = new System.Drawing.Point(298, 29);
            this.lblTotalHP.Name = "lblTotalHP";
            this.lblTotalHP.Size = new System.Drawing.Size(103, 25);
            this.lblTotalHP.TabIndex = 25;
            this.lblTotalHP.Text = "Total HP";
            // 
            // tbProficiency
            // 
            this.tbProficiency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProficiency.Location = new System.Drawing.Point(21, 98);
            this.tbProficiency.Name = "tbProficiency";
            this.tbProficiency.ReadOnly = true;
            this.tbProficiency.Size = new System.Drawing.Size(82, 26);
            this.tbProficiency.TabIndex = 21;
            // 
            // gbSavingThrows
            // 
            this.gbSavingThrows.Controls.Add(this.tbChrSave);
            this.gbSavingThrows.Controls.Add(this.tbWisSave);
            this.gbSavingThrows.Controls.Add(this.tbIntSave);
            this.gbSavingThrows.Controls.Add(this.tbConSave);
            this.gbSavingThrows.Controls.Add(this.tbDexSave);
            this.gbSavingThrows.Controls.Add(this.tbStrSave);
            this.gbSavingThrows.Controls.Add(this.lblChrSave);
            this.gbSavingThrows.Controls.Add(this.lblWisSave);
            this.gbSavingThrows.Controls.Add(this.lblIntSave);
            this.gbSavingThrows.Controls.Add(this.lblConSave);
            this.gbSavingThrows.Controls.Add(this.lblDexSave);
            this.gbSavingThrows.Controls.Add(this.lblStrSave);
            this.gbSavingThrows.Location = new System.Drawing.Point(261, 140);
            this.gbSavingThrows.Name = "gbSavingThrows";
            this.gbSavingThrows.Size = new System.Drawing.Size(232, 280);
            this.gbSavingThrows.TabIndex = 20;
            this.gbSavingThrows.TabStop = false;
            this.gbSavingThrows.Text = "Saving Throws";
            // 
            // tbChrSave
            // 
            this.tbChrSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChrSave.Location = new System.Drawing.Point(134, 229);
            this.tbChrSave.Name = "tbChrSave";
            this.tbChrSave.ReadOnly = true;
            this.tbChrSave.Size = new System.Drawing.Size(82, 26);
            this.tbChrSave.TabIndex = 17;
            // 
            // tbWisSave
            // 
            this.tbWisSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWisSave.Location = new System.Drawing.Point(134, 189);
            this.tbWisSave.Name = "tbWisSave";
            this.tbWisSave.ReadOnly = true;
            this.tbWisSave.Size = new System.Drawing.Size(82, 26);
            this.tbWisSave.TabIndex = 16;
            // 
            // tbIntSave
            // 
            this.tbIntSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIntSave.Location = new System.Drawing.Point(134, 149);
            this.tbIntSave.Name = "tbIntSave";
            this.tbIntSave.ReadOnly = true;
            this.tbIntSave.Size = new System.Drawing.Size(82, 26);
            this.tbIntSave.TabIndex = 15;
            // 
            // tbConSave
            // 
            this.tbConSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConSave.Location = new System.Drawing.Point(134, 109);
            this.tbConSave.Name = "tbConSave";
            this.tbConSave.ReadOnly = true;
            this.tbConSave.Size = new System.Drawing.Size(82, 26);
            this.tbConSave.TabIndex = 14;
            // 
            // tbDexSave
            // 
            this.tbDexSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDexSave.Location = new System.Drawing.Point(134, 69);
            this.tbDexSave.Name = "tbDexSave";
            this.tbDexSave.ReadOnly = true;
            this.tbDexSave.Size = new System.Drawing.Size(82, 26);
            this.tbDexSave.TabIndex = 13;
            // 
            // tbStrSave
            // 
            this.tbStrSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStrSave.Location = new System.Drawing.Point(134, 29);
            this.tbStrSave.Name = "tbStrSave";
            this.tbStrSave.ReadOnly = true;
            this.tbStrSave.Size = new System.Drawing.Size(82, 26);
            this.tbStrSave.TabIndex = 12;
            // 
            // lblChrSave
            // 
            this.lblChrSave.AutoSize = true;
            this.lblChrSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChrSave.Location = new System.Drawing.Point(22, 235);
            this.lblChrSave.Name = "lblChrSave";
            this.lblChrSave.Size = new System.Drawing.Size(64, 16);
            this.lblChrSave.TabIndex = 11;
            this.lblChrSave.Text = "Charisma";
            // 
            // lblWisSave
            // 
            this.lblWisSave.AutoSize = true;
            this.lblWisSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWisSave.Location = new System.Drawing.Point(22, 195);
            this.lblWisSave.Name = "lblWisSave";
            this.lblWisSave.Size = new System.Drawing.Size(57, 16);
            this.lblWisSave.TabIndex = 10;
            this.lblWisSave.Text = "Wisdom";
            // 
            // lblIntSave
            // 
            this.lblIntSave.AutoSize = true;
            this.lblIntSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntSave.Location = new System.Drawing.Point(22, 155);
            this.lblIntSave.Name = "lblIntSave";
            this.lblIntSave.Size = new System.Drawing.Size(72, 16);
            this.lblIntSave.TabIndex = 9;
            this.lblIntSave.Text = "Inteligence";
            // 
            // lblConSave
            // 
            this.lblConSave.AutoSize = true;
            this.lblConSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConSave.Location = new System.Drawing.Point(22, 115);
            this.lblConSave.Name = "lblConSave";
            this.lblConSave.Size = new System.Drawing.Size(75, 16);
            this.lblConSave.TabIndex = 8;
            this.lblConSave.Text = "Constitution";
            // 
            // lblDexSave
            // 
            this.lblDexSave.AutoSize = true;
            this.lblDexSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDexSave.Location = new System.Drawing.Point(22, 75);
            this.lblDexSave.Name = "lblDexSave";
            this.lblDexSave.Size = new System.Drawing.Size(59, 16);
            this.lblDexSave.TabIndex = 7;
            this.lblDexSave.Text = "Dexterity";
            // 
            // lblStrSave
            // 
            this.lblStrSave.AutoSize = true;
            this.lblStrSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrSave.Location = new System.Drawing.Point(22, 35);
            this.lblStrSave.Name = "lblStrSave";
            this.lblStrSave.Size = new System.Drawing.Size(56, 16);
            this.lblStrSave.TabIndex = 6;
            this.lblStrSave.Text = "Strength";
            // 
            // lblProficiency
            // 
            this.lblProficiency.AutoSize = true;
            this.lblProficiency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProficiency.Location = new System.Drawing.Point(17, 79);
            this.lblProficiency.Name = "lblProficiency";
            this.lblProficiency.Size = new System.Drawing.Size(131, 16);
            this.lblProficiency.TabIndex = 19;
            this.lblProficiency.Text = "Proficiency Bonus";
            // 
            // gbSpeed
            // 
            this.gbSpeed.Controls.Add(this.tbClimbingSpeed);
            this.gbSpeed.Controls.Add(this.tbFlyingSpeed);
            this.gbSpeed.Controls.Add(this.tbSwimSpeed);
            this.gbSpeed.Controls.Add(this.tbBurrowSpeed);
            this.gbSpeed.Controls.Add(this.tbMovementSpeed);
            this.gbSpeed.Controls.Add(this.lblClimbingSpeed);
            this.gbSpeed.Controls.Add(this.lblFlightSpeed);
            this.gbSpeed.Controls.Add(this.lblSwimSpeed);
            this.gbSpeed.Controls.Add(this.lblBurrowSpeed);
            this.gbSpeed.Controls.Add(this.lblMovementSpeed);
            this.gbSpeed.Location = new System.Drawing.Point(522, 140);
            this.gbSpeed.Name = "gbSpeed";
            this.gbSpeed.Size = new System.Drawing.Size(296, 280);
            this.gbSpeed.TabIndex = 10;
            this.gbSpeed.TabStop = false;
            this.gbSpeed.Text = "Speeds";
            // 
            // tbClimbingSpeed
            // 
            this.tbClimbingSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClimbingSpeed.Location = new System.Drawing.Point(168, 189);
            this.tbClimbingSpeed.Name = "tbClimbingSpeed";
            this.tbClimbingSpeed.ReadOnly = true;
            this.tbClimbingSpeed.Size = new System.Drawing.Size(82, 26);
            this.tbClimbingSpeed.TabIndex = 17;
            // 
            // tbFlyingSpeed
            // 
            this.tbFlyingSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFlyingSpeed.Location = new System.Drawing.Point(168, 149);
            this.tbFlyingSpeed.Name = "tbFlyingSpeed";
            this.tbFlyingSpeed.ReadOnly = true;
            this.tbFlyingSpeed.Size = new System.Drawing.Size(82, 26);
            this.tbFlyingSpeed.TabIndex = 16;
            // 
            // tbSwimSpeed
            // 
            this.tbSwimSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSwimSpeed.Location = new System.Drawing.Point(168, 109);
            this.tbSwimSpeed.Name = "tbSwimSpeed";
            this.tbSwimSpeed.ReadOnly = true;
            this.tbSwimSpeed.Size = new System.Drawing.Size(82, 26);
            this.tbSwimSpeed.TabIndex = 15;
            // 
            // tbBurrowSpeed
            // 
            this.tbBurrowSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBurrowSpeed.Location = new System.Drawing.Point(168, 69);
            this.tbBurrowSpeed.Name = "tbBurrowSpeed";
            this.tbBurrowSpeed.ReadOnly = true;
            this.tbBurrowSpeed.Size = new System.Drawing.Size(82, 26);
            this.tbBurrowSpeed.TabIndex = 14;
            // 
            // tbMovementSpeed
            // 
            this.tbMovementSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMovementSpeed.Location = new System.Drawing.Point(168, 25);
            this.tbMovementSpeed.Name = "tbMovementSpeed";
            this.tbMovementSpeed.ReadOnly = true;
            this.tbMovementSpeed.Size = new System.Drawing.Size(82, 26);
            this.tbMovementSpeed.TabIndex = 13;
            // 
            // lblClimbingSpeed
            // 
            this.lblClimbingSpeed.AutoSize = true;
            this.lblClimbingSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClimbingSpeed.Location = new System.Drawing.Point(22, 195);
            this.lblClimbingSpeed.Name = "lblClimbingSpeed";
            this.lblClimbingSpeed.Size = new System.Drawing.Size(103, 16);
            this.lblClimbingSpeed.TabIndex = 10;
            this.lblClimbingSpeed.Text = "Climbing Speed";
            // 
            // lblFlightSpeed
            // 
            this.lblFlightSpeed.AutoSize = true;
            this.lblFlightSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightSpeed.Location = new System.Drawing.Point(22, 155);
            this.lblFlightSpeed.Name = "lblFlightSpeed";
            this.lblFlightSpeed.Size = new System.Drawing.Size(87, 16);
            this.lblFlightSpeed.TabIndex = 9;
            this.lblFlightSpeed.Text = "Flying Speed";
            // 
            // lblSwimSpeed
            // 
            this.lblSwimSpeed.AutoSize = true;
            this.lblSwimSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimSpeed.Location = new System.Drawing.Point(22, 115);
            this.lblSwimSpeed.Name = "lblSwimSpeed";
            this.lblSwimSpeed.Size = new System.Drawing.Size(83, 16);
            this.lblSwimSpeed.TabIndex = 8;
            this.lblSwimSpeed.Text = "Swim Speed";
            // 
            // lblBurrowSpeed
            // 
            this.lblBurrowSpeed.AutoSize = true;
            this.lblBurrowSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurrowSpeed.Location = new System.Drawing.Point(22, 75);
            this.lblBurrowSpeed.Name = "lblBurrowSpeed";
            this.lblBurrowSpeed.Size = new System.Drawing.Size(92, 16);
            this.lblBurrowSpeed.TabIndex = 7;
            this.lblBurrowSpeed.Text = "Burrow Speed";
            // 
            // lblMovementSpeed
            // 
            this.lblMovementSpeed.AutoSize = true;
            this.lblMovementSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovementSpeed.Location = new System.Drawing.Point(22, 35);
            this.lblMovementSpeed.Name = "lblMovementSpeed";
            this.lblMovementSpeed.Size = new System.Drawing.Size(114, 16);
            this.lblMovementSpeed.TabIndex = 6;
            this.lblMovementSpeed.Text = "Movement Speed";
            // 
            // gbStats
            // 
            this.gbStats.Controls.Add(this.tbChr);
            this.gbStats.Controls.Add(this.tbWis);
            this.gbStats.Controls.Add(this.tbInt);
            this.gbStats.Controls.Add(this.tbCon);
            this.gbStats.Controls.Add(this.tbDex);
            this.gbStats.Controls.Add(this.tbStr);
            this.gbStats.Controls.Add(this.lblChr);
            this.gbStats.Controls.Add(this.lblWis);
            this.gbStats.Controls.Add(this.lblInt);
            this.gbStats.Controls.Add(this.lblCon);
            this.gbStats.Controls.Add(this.lblDex);
            this.gbStats.Controls.Add(this.lblStr);
            this.gbStats.Location = new System.Drawing.Point(9, 140);
            this.gbStats.Name = "gbStats";
            this.gbStats.Size = new System.Drawing.Size(232, 280);
            this.gbStats.TabIndex = 6;
            this.gbStats.TabStop = false;
            this.gbStats.Text = "Stats";
            // 
            // tbChr
            // 
            this.tbChr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbChr.Location = new System.Drawing.Point(134, 229);
            this.tbChr.Name = "tbChr";
            this.tbChr.ReadOnly = true;
            this.tbChr.Size = new System.Drawing.Size(82, 26);
            this.tbChr.TabIndex = 17;
            // 
            // tbWis
            // 
            this.tbWis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWis.Location = new System.Drawing.Point(134, 189);
            this.tbWis.Name = "tbWis";
            this.tbWis.ReadOnly = true;
            this.tbWis.Size = new System.Drawing.Size(82, 26);
            this.tbWis.TabIndex = 16;
            // 
            // tbInt
            // 
            this.tbInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInt.Location = new System.Drawing.Point(134, 149);
            this.tbInt.Name = "tbInt";
            this.tbInt.ReadOnly = true;
            this.tbInt.Size = new System.Drawing.Size(82, 26);
            this.tbInt.TabIndex = 15;
            // 
            // tbCon
            // 
            this.tbCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCon.Location = new System.Drawing.Point(134, 109);
            this.tbCon.Name = "tbCon";
            this.tbCon.ReadOnly = true;
            this.tbCon.Size = new System.Drawing.Size(82, 26);
            this.tbCon.TabIndex = 14;
            // 
            // tbDex
            // 
            this.tbDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDex.Location = new System.Drawing.Point(134, 69);
            this.tbDex.Name = "tbDex";
            this.tbDex.ReadOnly = true;
            this.tbDex.Size = new System.Drawing.Size(82, 26);
            this.tbDex.TabIndex = 13;
            // 
            // tbStr
            // 
            this.tbStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStr.Location = new System.Drawing.Point(134, 29);
            this.tbStr.Name = "tbStr";
            this.tbStr.ReadOnly = true;
            this.tbStr.Size = new System.Drawing.Size(82, 26);
            this.tbStr.TabIndex = 12;
            // 
            // lblChr
            // 
            this.lblChr.AutoSize = true;
            this.lblChr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChr.Location = new System.Drawing.Point(22, 235);
            this.lblChr.Name = "lblChr";
            this.lblChr.Size = new System.Drawing.Size(64, 16);
            this.lblChr.TabIndex = 11;
            this.lblChr.Text = "Charisma";
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWis.Location = new System.Drawing.Point(22, 195);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(57, 16);
            this.lblWis.TabIndex = 10;
            this.lblWis.Text = "Wisdom";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInt.Location = new System.Drawing.Point(22, 155);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(72, 16);
            this.lblInt.TabIndex = 9;
            this.lblInt.Text = "Inteligence";
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCon.Location = new System.Drawing.Point(22, 115);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(75, 16);
            this.lblCon.TabIndex = 8;
            this.lblCon.Text = "Constitution";
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDex.Location = new System.Drawing.Point(22, 75);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(59, 16);
            this.lblDex.TabIndex = 7;
            this.lblDex.Text = "Dexterity";
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStr.Location = new System.Drawing.Point(22, 35);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(56, 16);
            this.lblStr.TabIndex = 6;
            this.lblStr.Text = "Strength";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(20, 42);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(205, 22);
            this.tbName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(17, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // btnRollSavingThrows
            // 
            this.btnRollSavingThrows.Location = new System.Drawing.Point(256, 118);
            this.btnRollSavingThrows.Name = "btnRollSavingThrows";
            this.btnRollSavingThrows.Size = new System.Drawing.Size(187, 23);
            this.btnRollSavingThrows.TabIndex = 0;
            this.btnRollSavingThrows.Text = "Roll Saving Throws";
            this.btnRollSavingThrows.UseVisualStyleBackColor = true;
            this.btnRollSavingThrows.Click += new System.EventHandler(this.btnRollSavingThrows_Click);
            // 
            // btnManualInitiative
            // 
            this.btnManualInitiative.Location = new System.Drawing.Point(12, 564);
            this.btnManualInitiative.Name = "btnManualInitiative";
            this.btnManualInitiative.Size = new System.Drawing.Size(236, 23);
            this.btnManualInitiative.TabIndex = 5;
            this.btnManualInitiative.Text = "Manualy Imput Initiative of a Combatant";
            this.btnManualInitiative.UseVisualStyleBackColor = true;
            this.btnManualInitiative.Click += new System.EventHandler(this.btnManualInitiative_Click);
            // 
            // btnRemoveCombatant
            // 
            this.btnRemoveCombatant.Location = new System.Drawing.Point(256, 56);
            this.btnRemoveCombatant.Name = "btnRemoveCombatant";
            this.btnRemoveCombatant.Size = new System.Drawing.Size(187, 23);
            this.btnRemoveCombatant.TabIndex = 6;
            this.btnRemoveCombatant.Text = "Remove Combatant";
            this.btnRemoveCombatant.UseVisualStyleBackColor = true;
            this.btnRemoveCombatant.Click += new System.EventHandler(this.btnRemoveCombatant_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1624, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // CombatTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 599);
            this.Controls.Add(this.btnRemoveCombatant);
            this.Controls.Add(this.btnRollSavingThrows);
            this.Controls.Add(this.btnManualInitiative);
            this.Controls.Add(this.gbDisplayCombatant);
            this.Controls.Add(this.btnAddCombatant);
            this.Controls.Add(this.btnRollInitiative);
            this.Controls.Add(this.lbCombatants);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CombatTracker";
            this.Text = "Dnd Combat Helper App";
            this.gbDisplayCombatant.ResumeLayout(false);
            this.gbDisplayCombatant.PerformLayout();
            this.gbSavingThrows.ResumeLayout(false);
            this.gbSavingThrows.PerformLayout();
            this.gbSpeed.ResumeLayout(false);
            this.gbSpeed.PerformLayout();
            this.gbStats.ResumeLayout(false);
            this.gbStats.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCombatants;
        private System.Windows.Forms.Button btnRollInitiative;
        private System.Windows.Forms.Button btnAddCombatant;
        private System.Windows.Forms.GroupBox gbDisplayCombatant;
        private System.Windows.Forms.Button btnManualInitiative;
        private System.Windows.Forms.Button btnRollSavingThrows;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbStats;
        private System.Windows.Forms.TextBox tbChr;
        private System.Windows.Forms.TextBox tbWis;
        private System.Windows.Forms.TextBox tbInt;
        private System.Windows.Forms.TextBox tbCon;
        private System.Windows.Forms.TextBox tbDex;
        private System.Windows.Forms.TextBox tbStr;
        private System.Windows.Forms.Label lblChr;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.GroupBox gbSpeed;
        private System.Windows.Forms.TextBox tbClimbingSpeed;
        private System.Windows.Forms.TextBox tbFlyingSpeed;
        private System.Windows.Forms.TextBox tbSwimSpeed;
        private System.Windows.Forms.TextBox tbBurrowSpeed;
        private System.Windows.Forms.TextBox tbMovementSpeed;
        private System.Windows.Forms.Label lblClimbingSpeed;
        private System.Windows.Forms.Label lblFlightSpeed;
        private System.Windows.Forms.Label lblSwimSpeed;
        private System.Windows.Forms.Label lblBurrowSpeed;
        private System.Windows.Forms.Label lblMovementSpeed;
        private System.Windows.Forms.Label lblProficiency;
        private System.Windows.Forms.TextBox tbProficiency;
        private System.Windows.Forms.GroupBox gbSavingThrows;
        private System.Windows.Forms.TextBox tbChrSave;
        private System.Windows.Forms.TextBox tbWisSave;
        private System.Windows.Forms.TextBox tbIntSave;
        private System.Windows.Forms.TextBox tbConSave;
        private System.Windows.Forms.TextBox tbDexSave;
        private System.Windows.Forms.TextBox tbStrSave;
        private System.Windows.Forms.Label lblChrSave;
        private System.Windows.Forms.Label lblWisSave;
        private System.Windows.Forms.Label lblIntSave;
        private System.Windows.Forms.Label lblConSave;
        private System.Windows.Forms.Label lblDexSave;
        private System.Windows.Forms.Label lblStrSave;
        private System.Windows.Forms.TextBox tbCurrentHP;
        private System.Windows.Forms.ProgressBar pbCurrentHP;
        private System.Windows.Forms.Label lblCurrentHP;
        private System.Windows.Forms.TextBox tbAC;
        private System.Windows.Forms.TextBox tbTotalHP;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.Label lblTotalHP;
        private System.Windows.Forms.TextBox tbResistances;
        private System.Windows.Forms.Label lblVulnerabilities;
        private System.Windows.Forms.Label lblImmunities;
        private System.Windows.Forms.Label lblResistances;
        private System.Windows.Forms.TextBox tbVulnerabilities;
        private System.Windows.Forms.TextBox tbImmunities;
        private System.Windows.Forms.Button btnRemoveCombatant;
        private System.Windows.Forms.TextBox tbPassivePerception;
        private System.Windows.Forms.Label lblPassivePerception;
        private System.Windows.Forms.Button btnSetHP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}

