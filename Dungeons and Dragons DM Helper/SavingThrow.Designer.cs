namespace Dungeons_and_Dragons_DM_Helper
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
            this.cbSavingThrowType = new System.Windows.Forms.ComboBox();
            this.lblChooseSavingThrow = new System.Windows.Forms.Label();
            this.lblEnterSaveDC = new System.Windows.Forms.Label();
            this.numSaveDC = new System.Windows.Forms.NumericUpDown();
            this.btnRollSaveThrows = new System.Windows.Forms.Button();
            this.rtbRollResults = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSaveDC)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSavingThrowType
            // 
            this.cbSavingThrowType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSavingThrowType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSavingThrowType.FormattingEnabled = true;
            this.cbSavingThrowType.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution",
            "Inteligence",
            "Wisdom",
            "Charisma"});
            this.cbSavingThrowType.Location = new System.Drawing.Point(329, 30);
            this.cbSavingThrowType.Name = "cbSavingThrowType";
            this.cbSavingThrowType.Size = new System.Drawing.Size(121, 24);
            this.cbSavingThrowType.TabIndex = 0;
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
            this.btnRollSaveThrows.Location = new System.Drawing.Point(147, 332);
            this.btnRollSaveThrows.Name = "btnRollSaveThrows";
            this.btnRollSaveThrows.Size = new System.Drawing.Size(173, 28);
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
            // SavingThrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 396);
            this.Controls.Add(this.rtbRollResults);
            this.Controls.Add(this.btnRollSaveThrows);
            this.Controls.Add(this.numSaveDC);
            this.Controls.Add(this.lblEnterSaveDC);
            this.Controls.Add(this.lblChooseSavingThrow);
            this.Controls.Add(this.cbSavingThrowType);
            this.Name = "SavingThrow";
            this.Text = "SavingThrow";
            ((System.ComponentModel.ISupportInitialize)(this.numSaveDC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSavingThrowType;
        private System.Windows.Forms.Label lblChooseSavingThrow;
        private System.Windows.Forms.Label lblEnterSaveDC;
        private System.Windows.Forms.NumericUpDown numSaveDC;
        private System.Windows.Forms.Button btnRollSaveThrows;
        private System.Windows.Forms.RichTextBox rtbRollResults;
    }
}