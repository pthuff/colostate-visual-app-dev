namespace PHuffProgram8
{
    partial class Program8
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
            this.groupBoxCalculate = new System.Windows.Forms.GroupBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPay = new System.Windows.Forms.Label();
            this.buttonPayStub = new System.Windows.Forms.Button();
            this.numericUpDownRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDev = new System.Windows.Forms.Label();
            this.groupBoxSummary = new System.Windows.Forms.GroupBox();
            this.groupBoxCalculate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.groupBoxSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCalculate
            // 
            this.groupBoxCalculate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxCalculate.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBoxCalculate.Controls.Add(this.labelTitle);
            this.groupBoxCalculate.Controls.Add(this.labelPay);
            this.groupBoxCalculate.Controls.Add(this.buttonPayStub);
            this.groupBoxCalculate.Controls.Add(this.numericUpDownRate);
            this.groupBoxCalculate.Controls.Add(this.numericUpDownHours);
            this.groupBoxCalculate.Controls.Add(this.textBoxName);
            this.groupBoxCalculate.Controls.Add(this.labelRate);
            this.groupBoxCalculate.Controls.Add(this.labelHours);
            this.groupBoxCalculate.Controls.Add(this.labelName);
            this.groupBoxCalculate.Location = new System.Drawing.Point(159, 119);
            this.groupBoxCalculate.Name = "groupBoxCalculate";
            this.groupBoxCalculate.Size = new System.Drawing.Size(415, 208);
            this.groupBoxCalculate.TabIndex = 0;
            this.groupBoxCalculate.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.GhostWhite;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(145, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(123, 19);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Calculate Payroll";
            // 
            // labelPay
            // 
            this.labelPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPay.BackColor = System.Drawing.SystemColors.Info;
            this.labelPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPay.Location = new System.Drawing.Point(168, 159);
            this.labelPay.Name = "labelPay";
            this.labelPay.Size = new System.Drawing.Size(145, 22);
            this.labelPay.TabIndex = 7;
            this.labelPay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonPayStub
            // 
            this.buttonPayStub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPayStub.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPayStub.Location = new System.Drawing.Point(33, 156);
            this.buttonPayStub.Name = "buttonPayStub";
            this.buttonPayStub.Size = new System.Drawing.Size(122, 28);
            this.buttonPayStub.TabIndex = 6;
            this.buttonPayStub.Text = "Create Pay Stub";
            this.buttonPayStub.UseVisualStyleBackColor = false;
            this.buttonPayStub.Click += new System.EventHandler(this.buttonPayStub_Click);
            // 
            // numericUpDownRate
            // 
            this.numericUpDownRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownRate.DecimalPlaces = 2;
            this.numericUpDownRate.Location = new System.Drawing.Point(171, 98);
            this.numericUpDownRate.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownRate.Name = "numericUpDownRate";
            this.numericUpDownRate.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownRate.TabIndex = 5;
            this.numericUpDownRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownHours.Location = new System.Drawing.Point(171, 66);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownHours.TabIndex = 4;
            this.numericUpDownHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(171, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(191, 22);
            this.textBoxName.TabIndex = 3;
            // 
            // labelRate
            // 
            this.labelRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(42, 100);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(67, 16);
            this.labelRate.TabIndex = 2;
            this.labelRate.Text = "Pay Rate:";
            // 
            // labelHours
            // 
            this.labelHours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(42, 68);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(98, 16);
            this.labelHours.TabIndex = 1;
            this.labelHours.Text = "Hours Worked:";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(42, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(113, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Employee Name:";
            // 
            // buttonSummary
            // 
            this.buttonSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSummary.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSummary.Location = new System.Drawing.Point(6, 21);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(122, 28);
            this.buttonSummary.TabIndex = 8;
            this.buttonSummary.Text = "Display Summary";
            this.buttonSummary.UseVisualStyleBackColor = false;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(143, 21);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 28);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(329, 446);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDev
            // 
            this.labelDev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDev.AutoSize = true;
            this.labelDev.Location = new System.Drawing.Point(290, 529);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(153, 16);
            this.labelDev.TabIndex = 7;
            this.labelDev.Text = "Developed by: Paul Huff";
            // 
            // groupBoxSummary
            // 
            this.groupBoxSummary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxSummary.Controls.Add(this.buttonSummary);
            this.groupBoxSummary.Controls.Add(this.buttonReset);
            this.groupBoxSummary.Location = new System.Drawing.Point(254, 333);
            this.groupBoxSummary.Name = "groupBoxSummary";
            this.groupBoxSummary.Size = new System.Drawing.Size(224, 62);
            this.groupBoxSummary.TabIndex = 9;
            this.groupBoxSummary.TabStop = false;
            // 
            // Program8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 554);
            this.Controls.Add(this.labelDev);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxCalculate);
            this.Controls.Add(this.groupBoxSummary);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Program8";
            this.Text = "Assignment 3 - Program 8";
            this.groupBoxCalculate.ResumeLayout(false);
            this.groupBoxCalculate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.groupBoxSummary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCalculate;
        private System.Windows.Forms.NumericUpDown numericUpDownRate;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPay;
        private System.Windows.Forms.Button buttonPayStub;
        private System.Windows.Forms.Button buttonSummary;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelDev;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxSummary;
    }
}

