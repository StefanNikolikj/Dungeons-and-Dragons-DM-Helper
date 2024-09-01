namespace Dungeons_and_Dragons_DM_Helper
{
    partial class AddWeapon
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
            this.components = new System.ComponentModel.Container();
            this.tbRollTotal = new System.Windows.Forms.TextBox();
            this.gbAddDice = new System.Windows.Forms.GroupBox();
            this.btnd8 = new System.Windows.Forms.Button();
            this.btnd4 = new System.Windows.Forms.Button();
            this.btnd6 = new System.Windows.Forms.Button();
            this.btnd10 = new System.Windows.Forms.Button();
            this.btnd12 = new System.Windows.Forms.Button();
            this.btnd20 = new System.Windows.Forms.Button();
            this.btnd100 = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDamageModifier = new System.Windows.Forms.Label();
            this.numDamageModifier = new System.Windows.Forms.NumericUpDown();
            this.lblWeaponType = new System.Windows.Forms.Label();
            this.ddWeaponType = new System.Windows.Forms.ComboBox();
            this.btnResetDice = new System.Windows.Forms.Button();
            this.btnAddWeapom = new System.Windows.Forms.Button();
            this.lblEnterNumberOfDice = new System.Windows.Forms.Label();
            this.ddDamageType = new System.Windows.Forms.ComboBox();
            this.lblDamageType = new System.Windows.Forms.Label();
            this.gbRollDamage = new System.Windows.Forms.GroupBox();
            this.numNumberOfDice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddDice = new System.Windows.Forms.Button();
            this.epAddWeapon = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbAddDice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDamageModifier)).BeginInit();
            this.gbRollDamage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddWeapon)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRollTotal
            // 
            this.tbRollTotal.Location = new System.Drawing.Point(302, 224);
            this.tbRollTotal.Name = "tbRollTotal";
            this.tbRollTotal.ReadOnly = true;
            this.tbRollTotal.Size = new System.Drawing.Size(317, 20);
            this.tbRollTotal.TabIndex = 10;
            // 
            // gbAddDice
            // 
            this.gbAddDice.Controls.Add(this.btnd8);
            this.gbAddDice.Controls.Add(this.btnd4);
            this.gbAddDice.Controls.Add(this.btnd6);
            this.gbAddDice.Controls.Add(this.btnd10);
            this.gbAddDice.Controls.Add(this.btnd12);
            this.gbAddDice.Controls.Add(this.btnd20);
            this.gbAddDice.Controls.Add(this.btnd100);
            this.gbAddDice.Location = new System.Drawing.Point(302, 26);
            this.gbAddDice.Name = "gbAddDice";
            this.gbAddDice.Size = new System.Drawing.Size(317, 168);
            this.gbAddDice.TabIndex = 9;
            this.gbAddDice.TabStop = false;
            this.gbAddDice.Text = "Click to add dice to the damage roll of the weapon";
            // 
            // btnd8
            // 
            this.btnd8.Location = new System.Drawing.Point(117, 69);
            this.btnd8.Name = "btnd8";
            this.btnd8.Size = new System.Drawing.Size(75, 23);
            this.btnd8.TabIndex = 6;
            this.btnd8.Text = "d8";
            this.btnd8.UseVisualStyleBackColor = true;
            this.btnd8.Click += new System.EventHandler(this.btnd8_Click);
            // 
            // btnd4
            // 
            this.btnd4.Location = new System.Drawing.Point(117, 113);
            this.btnd4.Name = "btnd4";
            this.btnd4.Size = new System.Drawing.Size(75, 23);
            this.btnd4.TabIndex = 5;
            this.btnd4.Text = "d4";
            this.btnd4.UseVisualStyleBackColor = true;
            this.btnd4.Click += new System.EventHandler(this.btnd4_Click);
            // 
            // btnd6
            // 
            this.btnd6.Location = new System.Drawing.Point(228, 69);
            this.btnd6.Name = "btnd6";
            this.btnd6.Size = new System.Drawing.Size(75, 23);
            this.btnd6.TabIndex = 4;
            this.btnd6.Text = "d6";
            this.btnd6.UseVisualStyleBackColor = true;
            this.btnd6.Click += new System.EventHandler(this.btnd6_Click);
            // 
            // btnd10
            // 
            this.btnd10.Location = new System.Drawing.Point(12, 69);
            this.btnd10.Name = "btnd10";
            this.btnd10.Size = new System.Drawing.Size(75, 23);
            this.btnd10.TabIndex = 3;
            this.btnd10.Text = "d10";
            this.btnd10.UseVisualStyleBackColor = true;
            this.btnd10.Click += new System.EventHandler(this.btnd10_Click);
            // 
            // btnd12
            // 
            this.btnd12.Location = new System.Drawing.Point(228, 22);
            this.btnd12.Name = "btnd12";
            this.btnd12.Size = new System.Drawing.Size(75, 23);
            this.btnd12.TabIndex = 2;
            this.btnd12.Text = "d12";
            this.btnd12.UseVisualStyleBackColor = true;
            this.btnd12.Click += new System.EventHandler(this.btnd12_Click);
            // 
            // btnd20
            // 
            this.btnd20.Location = new System.Drawing.Point(117, 22);
            this.btnd20.Name = "btnd20";
            this.btnd20.Size = new System.Drawing.Size(75, 23);
            this.btnd20.TabIndex = 1;
            this.btnd20.Text = "d20";
            this.btnd20.UseVisualStyleBackColor = true;
            this.btnd20.Click += new System.EventHandler(this.btnd20_Click);
            // 
            // btnd100
            // 
            this.btnd100.Location = new System.Drawing.Point(12, 22);
            this.btnd100.Name = "btnd100";
            this.btnd100.Size = new System.Drawing.Size(75, 23);
            this.btnd100.TabIndex = 0;
            this.btnd100.Text = "d100";
            this.btnd100.UseVisualStyleBackColor = true;
            this.btnd100.Click += new System.EventHandler(this.btnd100_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(12, 37);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(232, 22);
            this.tbName.TabIndex = 12;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Name";
            // 
            // lblDamageModifier
            // 
            this.lblDamageModifier.AutoSize = true;
            this.lblDamageModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamageModifier.Location = new System.Drawing.Point(12, 73);
            this.lblDamageModifier.Name = "lblDamageModifier";
            this.lblDamageModifier.Size = new System.Drawing.Size(111, 16);
            this.lblDamageModifier.TabIndex = 14;
            this.lblDamageModifier.Text = "Damage Modifier";
            // 
            // numDamageModifier
            // 
            this.numDamageModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDamageModifier.Location = new System.Drawing.Point(12, 96);
            this.numDamageModifier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDamageModifier.Name = "numDamageModifier";
            this.numDamageModifier.Size = new System.Drawing.Size(232, 22);
            this.numDamageModifier.TabIndex = 13;
            // 
            // lblWeaponType
            // 
            this.lblWeaponType.AutoSize = true;
            this.lblWeaponType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeaponType.Location = new System.Drawing.Point(12, 130);
            this.lblWeaponType.Name = "lblWeaponType";
            this.lblWeaponType.Size = new System.Drawing.Size(94, 16);
            this.lblWeaponType.TabIndex = 16;
            this.lblWeaponType.Text = "Weapon Type";
            // 
            // ddWeaponType
            // 
            this.ddWeaponType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddWeaponType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddWeaponType.FormattingEnabled = true;
            this.ddWeaponType.Items.AddRange(new object[] {
            "Strength",
            "Dexterity"});
            this.ddWeaponType.Location = new System.Drawing.Point(12, 149);
            this.ddWeaponType.Name = "ddWeaponType";
            this.ddWeaponType.Size = new System.Drawing.Size(121, 24);
            this.ddWeaponType.TabIndex = 17;
            // 
            // btnResetDice
            // 
            this.btnResetDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDice.Location = new System.Drawing.Point(399, 273);
            this.btnResetDice.Name = "btnResetDice";
            this.btnResetDice.Size = new System.Drawing.Size(129, 28);
            this.btnResetDice.TabIndex = 34;
            this.btnResetDice.Text = "Reset Dice";
            this.btnResetDice.UseVisualStyleBackColor = true;
            this.btnResetDice.Click += new System.EventHandler(this.btnResetDice_Click);
            // 
            // btnAddWeapom
            // 
            this.btnAddWeapom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWeapom.Location = new System.Drawing.Point(68, 263);
            this.btnAddWeapom.Name = "btnAddWeapom";
            this.btnAddWeapom.Size = new System.Drawing.Size(136, 28);
            this.btnAddWeapom.TabIndex = 33;
            this.btnAddWeapom.Text = "Add Weapon";
            this.btnAddWeapom.UseVisualStyleBackColor = true;
            this.btnAddWeapom.Click += new System.EventHandler(this.btnAddWeapom_Click);
            // 
            // lblEnterNumberOfDice
            // 
            this.lblEnterNumberOfDice.AutoSize = true;
            this.lblEnterNumberOfDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterNumberOfDice.Location = new System.Drawing.Point(29, 44);
            this.lblEnterNumberOfDice.Name = "lblEnterNumberOfDice";
            this.lblEnterNumberOfDice.Size = new System.Drawing.Size(220, 16);
            this.lblEnterNumberOfDice.TabIndex = 3;
            this.lblEnterNumberOfDice.Text = "Enter the number of dice to be rolled";
            // 
            // ddDamageType
            // 
            this.ddDamageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddDamageType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddDamageType.FormattingEnabled = true;
            this.ddDamageType.Items.AddRange(new object[] {
            "Piercing",
            "Bludgeoning",
            "Slashing",
            "Cold",
            "Fire",
            "Lightning",
            "Thunder",
            "Poison",
            "Acid",
            "Necrotic",
            "Radiant",
            "Force",
            "Psychic"});
            this.ddDamageType.Location = new System.Drawing.Point(273, 92);
            this.ddDamageType.Name = "ddDamageType";
            this.ddDamageType.Size = new System.Drawing.Size(121, 24);
            this.ddDamageType.TabIndex = 30;
            // 
            // lblDamageType
            // 
            this.lblDamageType.AutoSize = true;
            this.lblDamageType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDamageType.Location = new System.Drawing.Point(29, 97);
            this.lblDamageType.Name = "lblDamageType";
            this.lblDamageType.Size = new System.Drawing.Size(232, 16);
            this.lblDamageType.TabIndex = 31;
            this.lblDamageType.Text = "Choose the damage type of the attack";
            // 
            // gbRollDamage
            // 
            this.gbRollDamage.Controls.Add(this.btnAddDice);
            this.gbRollDamage.Controls.Add(this.numNumberOfDice);
            this.gbRollDamage.Controls.Add(this.lblDamageType);
            this.gbRollDamage.Controls.Add(this.ddDamageType);
            this.gbRollDamage.Controls.Add(this.lblEnterNumberOfDice);
            this.gbRollDamage.Enabled = false;
            this.gbRollDamage.Location = new System.Drawing.Point(645, 26);
            this.gbRollDamage.Name = "gbRollDamage";
            this.gbRollDamage.Size = new System.Drawing.Size(400, 184);
            this.gbRollDamage.TabIndex = 35;
            this.gbRollDamage.TabStop = false;
            // 
            // numNumberOfDice
            // 
            this.numNumberOfDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumberOfDice.Location = new System.Drawing.Point(273, 44);
            this.numNumberOfDice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNumberOfDice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfDice.Name = "numNumberOfDice";
            this.numNumberOfDice.Size = new System.Drawing.Size(121, 22);
            this.numNumberOfDice.TabIndex = 32;
            this.numNumberOfDice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Damage Dice";
            // 
            // btnAddDice
            // 
            this.btnAddDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDice.Location = new System.Drawing.Point(145, 140);
            this.btnAddDice.Name = "btnAddDice";
            this.btnAddDice.Size = new System.Drawing.Size(136, 28);
            this.btnAddDice.TabIndex = 34;
            this.btnAddDice.Text = "Add Dice Roll";
            this.btnAddDice.UseVisualStyleBackColor = true;
            this.btnAddDice.Click += new System.EventHandler(this.btnAddDice_Click);
            // 
            // epAddWeapon
            // 
            this.epAddWeapon.ContainerControl = this;
            // 
            // AddWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbRollDamage);
            this.Controls.Add(this.btnResetDice);
            this.Controls.Add(this.btnAddWeapom);
            this.Controls.Add(this.ddWeaponType);
            this.Controls.Add(this.lblWeaponType);
            this.Controls.Add(this.lblDamageModifier);
            this.Controls.Add(this.numDamageModifier);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbRollTotal);
            this.Controls.Add(this.gbAddDice);
            this.Name = "AddWeapon";
            this.Text = "Add a Weapon/Attack";
            this.Load += new System.EventHandler(this.AddWeapon_Load);
            this.gbAddDice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDamageModifier)).EndInit();
            this.gbRollDamage.ResumeLayout(false);
            this.gbRollDamage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epAddWeapon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRollTotal;
        private System.Windows.Forms.GroupBox gbAddDice;
        private System.Windows.Forms.Button btnd8;
        private System.Windows.Forms.Button btnd4;
        private System.Windows.Forms.Button btnd6;
        private System.Windows.Forms.Button btnd10;
        private System.Windows.Forms.Button btnd12;
        private System.Windows.Forms.Button btnd20;
        private System.Windows.Forms.Button btnd100;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDamageModifier;
        private System.Windows.Forms.NumericUpDown numDamageModifier;
        private System.Windows.Forms.Label lblWeaponType;
        private System.Windows.Forms.ComboBox ddWeaponType;
        private System.Windows.Forms.Button btnResetDice;
        private System.Windows.Forms.Button btnAddWeapom;
        private System.Windows.Forms.Label lblEnterNumberOfDice;
        private System.Windows.Forms.ComboBox ddDamageType;
        private System.Windows.Forms.Label lblDamageType;
        private System.Windows.Forms.GroupBox gbRollDamage;
        private System.Windows.Forms.NumericUpDown numNumberOfDice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddDice;
        private System.Windows.Forms.ErrorProvider epAddWeapon;
    }
}