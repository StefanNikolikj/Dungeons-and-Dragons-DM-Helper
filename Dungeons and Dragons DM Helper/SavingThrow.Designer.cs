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
            this.nudDC = new System.Windows.Forms.NumericUpDown();
            this.nudStat = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStat)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDC
            // 
            this.nudDC.Location = new System.Drawing.Point(40, 48);
            this.nudDC.Name = "nudDC";
            this.nudDC.Size = new System.Drawing.Size(120, 20);
            this.nudDC.TabIndex = 0;
            // 
            // nudStat
            // 
            this.nudStat.Location = new System.Drawing.Point(40, 124);
            this.nudStat.Name = "nudStat";
            this.nudStat.Size = new System.Drawing.Size(120, 20);
            this.nudStat.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SavingThrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudStat);
            this.Controls.Add(this.nudDC);
            this.Name = "SavingThrow";
            this.Text = "SavingThrow";
            ((System.ComponentModel.ISupportInitialize)(this.nudDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDC;
        private System.Windows.Forms.NumericUpDown nudStat;
        private System.Windows.Forms.Button button1;
    }
}