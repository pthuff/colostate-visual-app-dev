namespace PHuffProgram5
{
    partial class Program5
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
            this.gboxPaintJob = new System.Windows.Forms.GroupBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblFootage = new System.Windows.Forms.Label();
            this.numCost = new System.Windows.Forms.NumericUpDown();
            this.numFootage = new System.Windows.Forms.NumericUpDown();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDev = new System.Windows.Forms.Label();
            this.gboxPaintJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFootage)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxPaintJob
            // 
            this.gboxPaintJob.BackColor = System.Drawing.SystemColors.Control;
            this.gboxPaintJob.Controls.Add(this.btnClear);
            this.gboxPaintJob.Controls.Add(this.btnEstimate);
            this.gboxPaintJob.Controls.Add(this.numFootage);
            this.gboxPaintJob.Controls.Add(this.numCost);
            this.gboxPaintJob.Controls.Add(this.lblFootage);
            this.gboxPaintJob.Controls.Add(this.lblCost);
            this.gboxPaintJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPaintJob.Location = new System.Drawing.Point(257, 137);
            this.gboxPaintJob.Name = "gboxPaintJob";
            this.gboxPaintJob.Size = new System.Drawing.Size(379, 224);
            this.gboxPaintJob.TabIndex = 0;
            this.gboxPaintJob.TabStop = false;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.BackColor = System.Drawing.SystemColors.Info;
            this.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCost.Location = new System.Drawing.Point(30, 41);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(158, 22);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Cost of Paint (1 Gal.)";
            // 
            // lblFootage
            // 
            this.lblFootage.AutoSize = true;
            this.lblFootage.BackColor = System.Drawing.SystemColors.Info;
            this.lblFootage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFootage.Location = new System.Drawing.Point(9, 73);
            this.lblFootage.Name = "lblFootage";
            this.lblFootage.Size = new System.Drawing.Size(201, 22);
            this.lblFootage.TabIndex = 1;
            this.lblFootage.Text = "Square Footage of Vehicle";
            // 
            // numCost
            // 
            this.numCost.DecimalPlaces = 2;
            this.numCost.Location = new System.Drawing.Point(234, 39);
            this.numCost.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(120, 26);
            this.numCost.TabIndex = 2;
            // 
            // numFootage
            // 
            this.numFootage.Location = new System.Drawing.Point(234, 71);
            this.numFootage.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numFootage.Name = "numFootage";
            this.numFootage.Size = new System.Drawing.Size(120, 26);
            this.numFootage.TabIndex = 3;
            // 
            // btnEstimate
            // 
            this.btnEstimate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEstimate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEstimate.Location = new System.Drawing.Point(111, 122);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(157, 34);
            this.btnEstimate.TabIndex = 4;
            this.btnEstimate.Text = "Estimate Paint Job";
            this.btnEstimate.UseVisualStyleBackColor = false;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(317, 102);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Paint Job Calculator";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(146, 172);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(403, 420);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Location = new System.Drawing.Point(370, 529);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(153, 16);
            this.lblDev.TabIndex = 3;
            this.lblDev.Text = "Developed by: Paul Huff";
            // 
            // Program5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(906, 554);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gboxPaintJob);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Program5";
            this.Text = "Assignment 2 - Program 5";
            this.gboxPaintJob.ResumeLayout(false);
            this.gboxPaintJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFootage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxPaintJob;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblFootage;
        private System.Windows.Forms.NumericUpDown numFootage;
        private System.Windows.Forms.NumericUpDown numCost;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDev;
    }
}

