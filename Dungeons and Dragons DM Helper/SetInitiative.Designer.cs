namespace Dungeons_and_Dragons_DM_Helper
{
    partial class SetInitiative
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
            this.numInitiative = new System.Windows.Forms.NumericUpDown();
            this.btnSetInitiative = new System.Windows.Forms.Button();
            this.lblSetInitiative = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numInitiative)).BeginInit();
            this.SuspendLayout();
            // 
            // numInitiative
            // 
            this.numInitiative.Location = new System.Drawing.Point(12, 59);
            this.numInitiative.Name = "numInitiative";
            this.numInitiative.Size = new System.Drawing.Size(263, 20);
            this.numInitiative.TabIndex = 0;
            // 
            // btnSetInitiative
            // 
            this.btnSetInitiative.Location = new System.Drawing.Point(58, 102);
            this.btnSetInitiative.Name = "btnSetInitiative";
            this.btnSetInitiative.Size = new System.Drawing.Size(169, 23);
            this.btnSetInitiative.TabIndex = 1;
            this.btnSetInitiative.Text = "Set initiative";
            this.btnSetInitiative.UseVisualStyleBackColor = true;
            this.btnSetInitiative.Click += new System.EventHandler(this.btnSetInitiative_Click);
            // 
            // lblSetInitiative
            // 
            this.lblSetInitiative.AutoSize = true;
            this.lblSetInitiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetInitiative.Location = new System.Drawing.Point(86, 40);
            this.lblSetInitiative.Name = "lblSetInitiative";
            this.lblSetInitiative.Size = new System.Drawing.Size(119, 16);
            this.lblSetInitiative.TabIndex = 2;
            this.lblSetInitiative.Text = "Enter New Initiative";
            // 
            // SetInitiative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 161);
            this.Controls.Add(this.lblSetInitiative);
            this.Controls.Add(this.btnSetInitiative);
            this.Controls.Add(this.numInitiative);
            this.Name = "SetInitiative";
            this.Text = "Set Initiative";
            ((System.ComponentModel.ISupportInitialize)(this.numInitiative)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numInitiative;
        private System.Windows.Forms.Button btnSetInitiative;
        private System.Windows.Forms.Label lblSetInitiative;
    }
}