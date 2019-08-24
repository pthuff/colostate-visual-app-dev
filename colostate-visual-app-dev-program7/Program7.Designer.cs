namespace PHuffProgram7
{
    partial class Program7
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
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxRental = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCharge = new System.Windows.Forms.Label();
            this.buttonCharge = new System.Windows.Forms.Button();
            this.numericUpDownDays = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEndOdo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBeginOdo = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDays = new System.Windows.Forms.Label();
            this.labelEndOdo = new System.Windows.Forms.Label();
            this.labelBeginOdo = new System.Windows.Forms.Label();
            this.labelDev = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxRental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndOdo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginOdo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.Indigo;
            this.labelName.Location = new System.Drawing.Point(6, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(108, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Customer Name:";
            // 
            // groupBoxRental
            // 
            this.groupBoxRental.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxRental.BackColor = System.Drawing.Color.Ivory;
            this.groupBoxRental.Controls.Add(this.labelTitle);
            this.groupBoxRental.Controls.Add(this.labelCharge);
            this.groupBoxRental.Controls.Add(this.buttonCharge);
            this.groupBoxRental.Controls.Add(this.numericUpDownDays);
            this.groupBoxRental.Controls.Add(this.numericUpDownEndOdo);
            this.groupBoxRental.Controls.Add(this.numericUpDownBeginOdo);
            this.groupBoxRental.Controls.Add(this.textBoxName);
            this.groupBoxRental.Controls.Add(this.labelDays);
            this.groupBoxRental.Controls.Add(this.labelEndOdo);
            this.groupBoxRental.Controls.Add(this.labelBeginOdo);
            this.groupBoxRental.Controls.Add(this.labelName);
            this.groupBoxRental.Location = new System.Drawing.Point(233, 104);
            this.groupBoxRental.Name = "groupBoxRental";
            this.groupBoxRental.Size = new System.Drawing.Size(350, 229);
            this.groupBoxRental.TabIndex = 1;
            this.groupBoxRental.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Ivory;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(94, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(170, 19);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Calculate Rental Charge";
            // 
            // labelCharge
            // 
            this.labelCharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCharge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCharge.Location = new System.Drawing.Point(201, 189);
            this.labelCharge.Name = "labelCharge";
            this.labelCharge.Size = new System.Drawing.Size(137, 22);
            this.labelCharge.TabIndex = 9;
            // 
            // buttonCharge
            // 
            this.buttonCharge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCharge.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCharge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCharge.Location = new System.Drawing.Point(18, 189);
            this.buttonCharge.Name = "buttonCharge";
            this.buttonCharge.Size = new System.Drawing.Size(131, 23);
            this.buttonCharge.TabIndex = 8;
            this.buttonCharge.Text = "Rental Charge:";
            this.buttonCharge.UseVisualStyleBackColor = false;
            this.buttonCharge.Click += new System.EventHandler(this.buttonCharge_Click);
            // 
            // numericUpDownDays
            // 
            this.numericUpDownDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownDays.Location = new System.Drawing.Point(201, 143);
            this.numericUpDownDays.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownDays.Name = "numericUpDownDays";
            this.numericUpDownDays.Size = new System.Drawing.Size(137, 22);
            this.numericUpDownDays.TabIndex = 7;
            this.numericUpDownDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownEndOdo
            // 
            this.numericUpDownEndOdo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownEndOdo.Location = new System.Drawing.Point(201, 105);
            this.numericUpDownEndOdo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownEndOdo.Name = "numericUpDownEndOdo";
            this.numericUpDownEndOdo.Size = new System.Drawing.Size(137, 22);
            this.numericUpDownEndOdo.TabIndex = 6;
            this.numericUpDownEndOdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownEndOdo.ThousandsSeparator = true;
            // 
            // numericUpDownBeginOdo
            // 
            this.numericUpDownBeginOdo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownBeginOdo.Location = new System.Drawing.Point(201, 67);
            this.numericUpDownBeginOdo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownBeginOdo.Name = "numericUpDownBeginOdo";
            this.numericUpDownBeginOdo.Size = new System.Drawing.Size(137, 22);
            this.numericUpDownBeginOdo.TabIndex = 5;
            this.numericUpDownBeginOdo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownBeginOdo.ThousandsSeparator = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(120, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(218, 22);
            this.textBoxName.TabIndex = 4;
            // 
            // labelDays
            // 
            this.labelDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDays.AutoSize = true;
            this.labelDays.ForeColor = System.Drawing.Color.Indigo;
            this.labelDays.Location = new System.Drawing.Point(6, 145);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(155, 16);
            this.labelDays.TabIndex = 3;
            this.labelDays.Text = "Number of Days Rented:";
            // 
            // labelEndOdo
            // 
            this.labelEndOdo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelEndOdo.AutoSize = true;
            this.labelEndOdo.ForeColor = System.Drawing.Color.Indigo;
            this.labelEndOdo.Location = new System.Drawing.Point(6, 107);
            this.labelEndOdo.Name = "labelEndOdo";
            this.labelEndOdo.Size = new System.Drawing.Size(171, 16);
            this.labelEndOdo.TabIndex = 2;
            this.labelEndOdo.Text = "Ending Odometer Reading:";
            // 
            // labelBeginOdo
            // 
            this.labelBeginOdo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBeginOdo.AutoSize = true;
            this.labelBeginOdo.ForeColor = System.Drawing.Color.Indigo;
            this.labelBeginOdo.Location = new System.Drawing.Point(6, 69);
            this.labelBeginOdo.Name = "labelBeginOdo";
            this.labelBeginOdo.Size = new System.Drawing.Size(189, 16);
            this.labelBeginOdo.TabIndex = 1;
            this.labelBeginOdo.Text = "Beginning Odometer Reading:";
            // 
            // labelDev
            // 
            this.labelDev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDev.AutoSize = true;
            this.labelDev.Location = new System.Drawing.Point(332, 480);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(153, 16);
            this.labelDev.TabIndex = 3;
            this.labelDev.Text = "Developed by: Paul Huff";
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(371, 357);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Location = new System.Drawing.Point(371, 404);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Program7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 505);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelDev);
            this.Controls.Add(this.groupBoxRental);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Program7";
            this.Text = "Assignment 3 - Program 7";
            this.groupBoxRental.ResumeLayout(false);
            this.groupBoxRental.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndOdo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginOdo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxRental;
        private System.Windows.Forms.NumericUpDown numericUpDownDays;
        private System.Windows.Forms.NumericUpDown numericUpDownEndOdo;
        private System.Windows.Forms.NumericUpDown numericUpDownBeginOdo;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelEndOdo;
        private System.Windows.Forms.Label labelBeginOdo;
        private System.Windows.Forms.Label labelCharge;
        private System.Windows.Forms.Button buttonCharge;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDev;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
    }
}

