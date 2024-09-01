namespace Dungeons_and_Dragons_DM_Helper
{
    partial class MakeAnAttack
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
            this.lbCombatants = new System.Windows.Forms.ListBox();
            this.lblChooseToAttack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.rbDisadvantage = new System.Windows.Forms.RadioButton();
            this.rbAdvantage = new System.Windows.Forms.RadioButton();
            this.btnRollToHit = new System.Windows.Forms.Button();
            this.numNumberOfDice = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfAttacks = new System.Windows.Forms.Label();
            this.rtbRollResults = new System.Windows.Forms.RichTextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.epMakeAnAttack = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfDice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMakeAnAttack)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCombatants
            // 
            this.lbCombatants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCombatants.FormattingEnabled = true;
            this.lbCombatants.ItemHeight = 16;
            this.lbCombatants.Location = new System.Drawing.Point(12, 28);
            this.lbCombatants.Name = "lbCombatants";
            this.lbCombatants.Size = new System.Drawing.Size(236, 468);
            this.lbCombatants.TabIndex = 1;
            this.lbCombatants.Validating += new System.ComponentModel.CancelEventHandler(this.lbCombatants_Validating);
            // 
            // lblChooseToAttack
            // 
            this.lblChooseToAttack.AutoSize = true;
            this.lblChooseToAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseToAttack.Location = new System.Drawing.Point(50, 9);
            this.lblChooseToAttack.Name = "lblChooseToAttack";
            this.lblChooseToAttack.Size = new System.Drawing.Size(135, 16);
            this.lblChooseToAttack.TabIndex = 4;
            this.lblChooseToAttack.Text = "Choose who to Attack";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Attack Roll";
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(540, 279);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 40;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // rbDisadvantage
            // 
            this.rbDisadvantage.AutoSize = true;
            this.rbDisadvantage.Location = new System.Drawing.Point(386, 279);
            this.rbDisadvantage.Name = "rbDisadvantage";
            this.rbDisadvantage.Size = new System.Drawing.Size(91, 17);
            this.rbDisadvantage.TabIndex = 39;
            this.rbDisadvantage.TabStop = true;
            this.rbDisadvantage.Text = "Disadvantage";
            this.rbDisadvantage.UseVisualStyleBackColor = true;
            // 
            // rbAdvantage
            // 
            this.rbAdvantage.AutoSize = true;
            this.rbAdvantage.Location = new System.Drawing.Point(264, 279);
            this.rbAdvantage.Name = "rbAdvantage";
            this.rbAdvantage.Size = new System.Drawing.Size(77, 17);
            this.rbAdvantage.TabIndex = 38;
            this.rbAdvantage.TabStop = true;
            this.rbAdvantage.Text = "Advantage";
            this.rbAdvantage.UseVisualStyleBackColor = true;
            // 
            // btnRollToHit
            // 
            this.btnRollToHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollToHit.Location = new System.Drawing.Point(264, 321);
            this.btnRollToHit.Name = "btnRollToHit";
            this.btnRollToHit.Size = new System.Drawing.Size(136, 28);
            this.btnRollToHit.TabIndex = 41;
            this.btnRollToHit.Text = "Roll to Hit";
            this.btnRollToHit.UseVisualStyleBackColor = true;
            this.btnRollToHit.Click += new System.EventHandler(this.btnRollToHit_Click);
            // 
            // numNumberOfDice
            // 
            this.numNumberOfDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNumberOfDice.Location = new System.Drawing.Point(460, 41);
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
            this.numNumberOfDice.TabIndex = 43;
            this.numNumberOfDice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNumberOfAttacks
            // 
            this.lblNumberOfAttacks.AutoSize = true;
            this.lblNumberOfAttacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfAttacks.Location = new System.Drawing.Point(261, 43);
            this.lblNumberOfAttacks.Name = "lblNumberOfAttacks";
            this.lblNumberOfAttacks.Size = new System.Drawing.Size(167, 16);
            this.lblNumberOfAttacks.TabIndex = 42;
            this.lblNumberOfAttacks.Text = "Enter the number of attacks";
            // 
            // rtbRollResults
            // 
            this.rtbRollResults.Location = new System.Drawing.Point(264, 106);
            this.rtbRollResults.Name = "rtbRollResults";
            this.rtbRollResults.ReadOnly = true;
            this.rtbRollResults.Size = new System.Drawing.Size(327, 167);
            this.rtbRollResults.TabIndex = 44;
            this.rtbRollResults.Text = "";
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(445, 321);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(136, 28);
            this.btnFinish.TabIndex = 45;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // epMakeAnAttack
            // 
            this.epMakeAnAttack.ContainerControl = this;
            // 
            // MakeAnAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 509);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.rtbRollResults);
            this.Controls.Add(this.numNumberOfDice);
            this.Controls.Add(this.lblNumberOfAttacks);
            this.Controls.Add(this.btnRollToHit);
            this.Controls.Add(this.rbNone);
            this.Controls.Add(this.rbDisadvantage);
            this.Controls.Add(this.rbAdvantage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChooseToAttack);
            this.Controls.Add(this.lbCombatants);
            this.Name = "MakeAnAttack";
            this.Text = "Make an Attack";
            this.Load += new System.EventHandler(this.MakeAnAttack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfDice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMakeAnAttack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCombatants;
        private System.Windows.Forms.Label lblChooseToAttack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.RadioButton rbDisadvantage;
        private System.Windows.Forms.RadioButton rbAdvantage;
        private System.Windows.Forms.Button btnRollToHit;
        private System.Windows.Forms.NumericUpDown numNumberOfDice;
        private System.Windows.Forms.Label lblNumberOfAttacks;
        private System.Windows.Forms.RichTextBox rtbRollResults;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ErrorProvider epMakeAnAttack;
    }
}