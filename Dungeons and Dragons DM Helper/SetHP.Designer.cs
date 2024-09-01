namespace Dungeons_and_Dragons_DM_Helper
{
    partial class SetHP
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
            this.btnSetHP = new System.Windows.Forms.Button();
            this.numHP = new System.Windows.Forms.NumericUpDown();
            this.lblSetHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetHP
            // 
            this.btnSetHP.Location = new System.Drawing.Point(59, 103);
            this.btnSetHP.Name = "btnSetHP";
            this.btnSetHP.Size = new System.Drawing.Size(169, 23);
            this.btnSetHP.TabIndex = 2;
            this.btnSetHP.Text = "Set HP";
            this.btnSetHP.UseVisualStyleBackColor = true;
            this.btnSetHP.Click += new System.EventHandler(this.btnSetHP_Click);
            // 
            // numHP
            // 
            this.numHP.Location = new System.Drawing.Point(12, 45);
            this.numHP.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numHP.Name = "numHP";
            this.numHP.Size = new System.Drawing.Size(263, 20);
            this.numHP.TabIndex = 3;
            // 
            // lblSetHP
            // 
            this.lblSetHP.AutoSize = true;
            this.lblSetHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetHP.Location = new System.Drawing.Point(95, 26);
            this.lblSetHP.Name = "lblSetHP";
            this.lblSetHP.Size = new System.Drawing.Size(87, 16);
            this.lblSetHP.TabIndex = 4;
            this.lblSetHP.Text = "Enter new HP";
            // 
            // SetHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 161);
            this.Controls.Add(this.lblSetHP);
            this.Controls.Add(this.numHP);
            this.Controls.Add(this.btnSetHP);
            this.Name = "SetHP";
            this.Text = "Set HP";
            this.Load += new System.EventHandler(this.SetHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetHP;
        private System.Windows.Forms.NumericUpDown numHP;
        private System.Windows.Forms.Label lblSetHP;
    }
}