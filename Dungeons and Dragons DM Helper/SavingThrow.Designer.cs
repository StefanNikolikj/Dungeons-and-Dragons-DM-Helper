﻿namespace Dungeons_and_Dragons_DM_Helper
{
    partial class SavingThrow
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
            this.ddSavingThrowType = new System.Windows.Forms.ComboBox();
            this.lblChooseSavingThrow = new System.Windows.Forms.Label();
            this.lblEnterSaveDC = new System.Windows.Forms.Label();
            this.numSaveDC = new System.Windows.Forms.NumericUpDown();
            this.btnRollSaveThrows = new System.Windows.Forms.Button();
            this.rtbRollResults = new System.Windows.Forms.RichTextBox();
            this.cbRollDamage = new System.Windows.Forms.CheckBox();
            this.lblEnterDice = new System.Windows.Forms.Label();
            this.tbEnterDice = new System.Windows.Forms.TextBox();
            this.ddDamageType = new System.Windows.Forms.ComboBox();
            this.lblDamageType = new System.Windows.Forms.Label();
            this.gbRollDamage = new System.Windows.Forms.GroupBox();
            this.cbHalfDamage = new System.Windows.Forms.CheckBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.rbAdvantage = new System.Windows.Forms.RadioButton();
            this.rbDisadvantage = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.epSavingThrow = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numSaveDC)).BeginInit();
            this.gbRollDamage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSavingThrow)).BeginInit();
            this.SuspendLayout();
            // 
            // ddSavingThrowType
            // 
            this.ddSavingThrowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddSavingThrowType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddSavingThrowType.FormattingEnabled = true;
            this.ddSavingThrowType.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution",
            "Inteligence",
            "Wisdom",
            "Charisma"});
            this.ddSavingThrowType.Location = new System.Drawing.Point(329, 30);
            this.ddSavingThrowType.Name = "ddSavingThrowType";
            this.ddSavingThrowType.Size = new System.Drawing.Size(121, 24);
            this.ddSavingThrowType.TabIndex = 0;
            this.ddSavingThrowType.SelectedIndexChanged += new System.EventHandler(this.ddSavingThrowType_SelectedIndexChanged);
            // 
            // lblChooseSavingThrow
            // 
            this.lblChooseSavingThrow.AutoSize = true;
            this.lblChooseSavingThrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseSavingThrow.Location = new System.Drawing.Point(12, 33);
            this.lblChooseSavingThrow.Name = "lblChooseSavingThrow";
            this.lblChooseSavingThrow.Size = new System.Drawing.Size(293, 16);
            this.lblChooseSavingThrow.TabIndex = 1;
            this.lblChooseSavingThrow.Text = "Choose the type of Saving Throw you want to roll";
            // 
            // lblEnterSaveDC
            // 
            this.lblEnterSaveDC.AutoSize = true;
            this.lblEnterSaveDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterSaveDC.Location = new System.Drawing.Point(12, 76);
            this.lblEnterSaveDC.Name = "lblEnterSaveDC";
            this.lblEnterSaveDC.Size = new System.Drawing.Size(95, 16);
            this.lblEnterSaveDC.TabIndex = 2;
            this.lblEnterSaveDC.Text = "Enter Save DC";
            // 
            // numSaveDC
            // 
            this.numSaveDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSaveDC.Location = new System.Drawing.Point(138, 74);
            this.numSaveDC.Name = "numSaveDC";
            this.numSaveDC.Size = new System.Drawing.Size(121, 22);
            this.numSaveDC.TabIndex = 3;
            // 
            // btnRollSaveThrows
            // 
            this.btnRollSaveThrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollSaveThrows.Location = new System.Drawing.Point(15, 333);
            this.btnRollSaveThrows.Name = "btnRollSaveThrows";
            this.btnRollSaveThrows.Size = new System.Drawing.Size(189, 28);
            this.btnRollSaveThrows.TabIndex = 4;
            this.btnRollSaveThrows.Text = "Roll Saves";
            this.btnRollSaveThrows.UseVisualStyleBackColor = true;
            this.btnRollSaveThrows.Click += new System.EventHandler(this.btnRollSaveThrows_Click);
            // 
            // rtbRollResults
            // 
            this.rtbRollResults.Location = new System.Drawing.Point(15, 124);
            this.rtbRollResults.Name = "rtbRollResults";
            this.rtbRollResults.ReadOnly = true;
            this.rtbRollResults.Size = new System.Drawing.Size(435, 167);
            this.rtbRollResults.TabIndex = 6;
            this.rtbRollResults.Text = "";
            // 
            // cbRollDamage
            // 
            this.cbRollDamage.AutoSize = true;
            this.cbRollDamage.Location = new System.Drawing.Point(329, 77);
            this.cbRollDamage.Name = "cbRollDamage";
            this.cbRollDamage.Size = new System.Drawing.Size(108, 17);
            this.cbRollDamage.TabIndex = 7;
            this.cbRollDamage.Text = "Roll for Damage?";
            this.cbRollDamage.UseVisualStyleBackColor = true;
            this.cbRollDamage.CheckedChanged += new System.EventHandler(this.cbRollDamage_CheckedChanged);
            // 
            // lblEnterDice
            // 
            this.lblEnterDice.AutoSize = true;
            this.lblEnterDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDice.Location = new System.Drawing.Point(29, 44);
            this.lblEnterDice.Name = "lblEnterDice";
            this.lblEnterDice.Size = new System.Drawing.Size(160, 16);
            this.lblEnterDice.TabIndex = 3;
            this.lblEnterDice.Text = "Enter the Dice to be rolled";
            // 
            // tbEnterDice
            // 
            this.tbEnterDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEnterDice.Location = new System.Drawing.Point(273, 37);
            this.tbEnterDice.Name = "tbEnterDice";
            this.tbEnterDice.Size = new System.Drawing.Size(121, 29);
            this.tbEnterDice.TabIndex = 29;
            this.tbEnterDice.Validating += new System.ComponentModel.CancelEventHandler(this.tbEnterDice_Validating);
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
            this.gbRollDamage.Controls.Add(this.cbHalfDamage);
            this.gbRollDamage.Controls.Add(this.lblDamageType);
            this.gbRollDamage.Controls.Add(this.ddDamageType);
            this.gbRollDamage.Controls.Add(this.tbEnterDice);
            this.gbRollDamage.Controls.Add(this.lblEnterDice);
            this.gbRollDamage.Enabled = false;
            this.gbRollDamage.Location = new System.Drawing.Point(493, 30);
            this.gbRollDamage.Name = "gbRollDamage";
            this.gbRollDamage.Size = new System.Drawing.Size(420, 167);
            this.gbRollDamage.TabIndex = 8;
            this.gbRollDamage.TabStop = false;
            this.gbRollDamage.Text = "Roll Damage";
            // 
            // cbHalfDamage
            // 
            this.cbHalfDamage.AutoSize = true;
            this.cbHalfDamage.Location = new System.Drawing.Point(32, 131);
            this.cbHalfDamage.Name = "cbHalfDamage";
            this.cbHalfDamage.Size = new System.Drawing.Size(254, 17);
            this.cbHalfDamage.TabIndex = 32;
            this.cbHalfDamage.Text = "Does this attack deal half damage when saved?";
            this.cbHalfDamage.UseVisualStyleBackColor = true;
            this.cbHalfDamage.CheckedChanged += new System.EventHandler(this.cbHalfDamage_CheckedChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(277, 333);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(173, 28);
            this.btnReturn.TabIndex = 32;
            this.btnReturn.Text = "Finish";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // rbAdvantage
            // 
            this.rbAdvantage.AutoSize = true;
            this.rbAdvantage.Location = new System.Drawing.Point(15, 297);
            this.rbAdvantage.Name = "rbAdvantage";
            this.rbAdvantage.Size = new System.Drawing.Size(77, 17);
            this.rbAdvantage.TabIndex = 33;
            this.rbAdvantage.TabStop = true;
            this.rbAdvantage.Text = "Advantage";
            this.rbAdvantage.UseVisualStyleBackColor = true;
            // 
            // rbDisadvantage
            // 
            this.rbDisadvantage.AutoSize = true;
            this.rbDisadvantage.Location = new System.Drawing.Point(200, 297);
            this.rbDisadvantage.Name = "rbDisadvantage";
            this.rbDisadvantage.Size = new System.Drawing.Size(91, 17);
            this.rbDisadvantage.TabIndex = 34;
            this.rbDisadvantage.TabStop = true;
            this.rbDisadvantage.Text = "Disadvantage";
            this.rbDisadvantage.UseVisualStyleBackColor = true;
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(399, 297);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 35;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // epSavingThrow
            // 
            this.epSavingThrow.ContainerControl = this;
            // 
            // SavingThrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 396);
            this.Controls.Add(this.rbNone);
            this.Controls.Add(this.rbDisadvantage);
            this.Controls.Add(this.rbAdvantage);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.gbRollDamage);
            this.Controls.Add(this.cbRollDamage);
            this.Controls.Add(this.rtbRollResults);
            this.Controls.Add(this.btnRollSaveThrows);
            this.Controls.Add(this.numSaveDC);
            this.Controls.Add(this.lblEnterSaveDC);
            this.Controls.Add(this.lblChooseSavingThrow);
            this.Controls.Add(this.ddSavingThrowType);
            this.Name = "SavingThrow";
            this.Text = "SavingThrow";
            this.Load += new System.EventHandler(this.SavingThrow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSaveDC)).EndInit();
            this.gbRollDamage.ResumeLayout(false);
            this.gbRollDamage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSavingThrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddSavingThrowType;
        private System.Windows.Forms.Label lblChooseSavingThrow;
        private System.Windows.Forms.Label lblEnterSaveDC;
        private System.Windows.Forms.NumericUpDown numSaveDC;
        private System.Windows.Forms.Button btnRollSaveThrows;
        private System.Windows.Forms.RichTextBox rtbRollResults;
        private System.Windows.Forms.CheckBox cbRollDamage;
        private System.Windows.Forms.Label lblEnterDice;
        private System.Windows.Forms.TextBox tbEnterDice;
        private System.Windows.Forms.ComboBox ddDamageType;
        private System.Windows.Forms.Label lblDamageType;
        private System.Windows.Forms.GroupBox gbRollDamage;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.CheckBox cbHalfDamage;
        private System.Windows.Forms.RadioButton rbAdvantage;
        private System.Windows.Forms.RadioButton rbDisadvantage;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.ErrorProvider epSavingThrow;
    }
}