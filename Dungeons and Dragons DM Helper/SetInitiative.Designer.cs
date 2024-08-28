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
            ((System.ComponentModel.ISupportInitialize)(this.numInitiative)).BeginInit();
            this.SuspendLayout();
            // 
            // numInitiative
            // 
            this.numInitiative.Location = new System.Drawing.Point(12, 27);
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
            // SetInitiative
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 161);
            this.Controls.Add(this.btnSetInitiative);
            this.Controls.Add(this.numInitiative);
            this.Name = "SetInitiative";
            this.Text = "Set Initiative";
            ((System.ComponentModel.ISupportInitialize)(this.numInitiative)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numInitiative;
        private System.Windows.Forms.Button btnSetInitiative;
    }
}