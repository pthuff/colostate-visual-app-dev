namespace PHuffProgram12
{
    partial class Program12
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxProjectile = new System.Windows.Forms.GroupBox();
            this.numericUpDownVelocity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.buttonThrow = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDev = new System.Windows.Forms.Label();
            this.groupBoxProjectile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVelocity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(142, 44);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(187, 22);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Calculate a Projectile";
            // 
            // groupBoxProjectile
            // 
            this.groupBoxProjectile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxProjectile.Controls.Add(this.numericUpDownVelocity);
            this.groupBoxProjectile.Controls.Add(this.numericUpDownHeight);
            this.groupBoxProjectile.Controls.Add(this.label1);
            this.groupBoxProjectile.Controls.Add(this.labelHeight);
            this.groupBoxProjectile.Controls.Add(this.labelReturn);
            this.groupBoxProjectile.Controls.Add(this.buttonThrow);
            this.groupBoxProjectile.Location = new System.Drawing.Point(54, 95);
            this.groupBoxProjectile.Name = "groupBoxProjectile";
            this.groupBoxProjectile.Size = new System.Drawing.Size(385, 255);
            this.groupBoxProjectile.TabIndex = 1;
            this.groupBoxProjectile.TabStop = false;
            this.groupBoxProjectile.Text = "Projectile Information";
            // 
            // numericUpDownVelocity
            // 
            this.numericUpDownVelocity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownVelocity.Location = new System.Drawing.Point(216, 80);
            this.numericUpDownVelocity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownVelocity.Name = "numericUpDownVelocity";
            this.numericUpDownVelocity.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownVelocity.TabIndex = 2;
            this.numericUpDownVelocity.ThousandsSeparator = true;
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownHeight.Location = new System.Drawing.Point(216, 40);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownHeight.TabIndex = 1;
            this.numericUpDownHeight.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initial Velocity (ft/sec):";
            // 
            // labelHeight
            // 
            this.labelHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(67, 43);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(125, 20);
            this.labelHeight.TabIndex = 2;
            this.labelHeight.Text = "Initial Height (ft):";
            // 
            // labelReturn
            // 
            this.labelReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReturn.BackColor = System.Drawing.SystemColors.Info;
            this.labelReturn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelReturn.Location = new System.Drawing.Point(6, 187);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(365, 44);
            this.labelReturn.TabIndex = 6;
            // 
            // buttonThrow
            // 
            this.buttonThrow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonThrow.Location = new System.Drawing.Point(123, 145);
            this.buttonThrow.Name = "buttonThrow";
            this.buttonThrow.Size = new System.Drawing.Size(130, 32);
            this.buttonThrow.TabIndex = 3;
            this.buttonThrow.Text = "Throw in Air";
            this.buttonThrow.UseVisualStyleBackColor = true;
            this.buttonThrow.Click += new System.EventHandler(this.buttonThrow_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReset.Location = new System.Drawing.Point(149, 356);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(80, 28);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.Location = new System.Drawing.Point(242, 356);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 28);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDev
            // 
            this.labelDev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDev.AutoSize = true;
            this.labelDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDev.Location = new System.Drawing.Point(159, 427);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(153, 16);
            this.labelDev.TabIndex = 2;
            this.labelDev.Text = "Developed by: Paul Huff";
            // 
            // Program12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 452);
            this.Controls.Add(this.labelDev);
            this.Controls.Add(this.groupBoxProjectile);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Program12";
            this.Text = "Assignment 5 - Program 12";
            this.groupBoxProjectile.ResumeLayout(false);
            this.groupBoxProjectile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVelocity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxProjectile;
        private System.Windows.Forms.Button buttonThrow;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelDev;
        private System.Windows.Forms.NumericUpDown numericUpDownVelocity;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHeight;
    }
}

