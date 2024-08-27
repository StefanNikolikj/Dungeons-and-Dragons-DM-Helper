namespace Dungeons_and_Dragons_DM_Helper
{
    partial class Dice_Roller
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
            this.btnd100 = new System.Windows.Forms.Button();
            this.btnd20 = new System.Windows.Forms.Button();
            this.btnd12 = new System.Windows.Forms.Button();
            this.btnd10 = new System.Windows.Forms.Button();
            this.btnd6 = new System.Windows.Forms.Button();
            this.btnd4 = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnd8 = new System.Windows.Forms.Button();
            this.tbRollTotal = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(42, 286);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(291, 23);
            this.btnRoll.TabIndex = 6;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnd8);
            this.groupBox1.Controls.Add(this.btnd4);
            this.groupBox1.Controls.Add(this.btnd6);
            this.groupBox1.Controls.Add(this.btnd10);
            this.groupBox1.Controls.Add(this.btnd12);
            this.groupBox1.Controls.Add(this.btnd20);
            this.groupBox1.Controls.Add(this.btnd100);
            this.groupBox1.Location = new System.Drawing.Point(30, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 168);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click to add dice to roll";
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
            // tbRollTotal
            // 
            this.tbRollTotal.Location = new System.Drawing.Point(42, 235);
            this.tbRollTotal.Name = "tbRollTotal";
            this.tbRollTotal.ReadOnly = true;
            this.tbRollTotal.Size = new System.Drawing.Size(291, 20);
            this.tbRollTotal.TabIndex = 8;
            // 
            // Dice_Roller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 452);
            this.Controls.Add(this.tbRollTotal);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dice_Roller";
            this.Text = "Dice_Roller";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnd100;
        private System.Windows.Forms.Button btnd20;
        private System.Windows.Forms.Button btnd12;
        private System.Windows.Forms.Button btnd10;
        private System.Windows.Forms.Button btnd6;
        private System.Windows.Forms.Button btnd4;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRollTotal;
        private System.Windows.Forms.Button btnd8;
    }
}