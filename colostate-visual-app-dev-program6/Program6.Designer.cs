namespace PHuffProgram6
{
    partial class Program6
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
            this.groupBoxWalk = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelDistance = new System.Windows.Forms.Label();
            this.buttonWalk = new System.Windows.Forms.Button();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStep = new System.Windows.Forms.NumericUpDown();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelSteps = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDev = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxWalk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxWalk
            // 
            this.groupBoxWalk.Controls.Add(this.buttonReset);
            this.groupBoxWalk.Controls.Add(this.labelDistance);
            this.groupBoxWalk.Controls.Add(this.buttonWalk);
            this.groupBoxWalk.Controls.Add(this.numericUpDownLength);
            this.groupBoxWalk.Controls.Add(this.numericUpDownStep);
            this.groupBoxWalk.Controls.Add(this.labelLength);
            this.groupBoxWalk.Controls.Add(this.labelSteps);
            this.groupBoxWalk.Controls.Add(this.textBoxName);
            this.groupBoxWalk.Controls.Add(this.labelName);
            this.groupBoxWalk.Location = new System.Drawing.Point(169, 111);
            this.groupBoxWalk.Name = "groupBoxWalk";
            this.groupBoxWalk.Size = new System.Drawing.Size(312, 212);
            this.groupBoxWalk.TabIndex = 0;
            this.groupBoxWalk.TabStop = false;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReset.Location = new System.Drawing.Point(18, 172);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(135, 23);
            this.buttonReset.TabIndex = 9;
            this.buttonReset.Text = "Reset Values";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelDistance
            // 
            this.labelDistance.BackColor = System.Drawing.SystemColors.Info;
            this.labelDistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDistance.Location = new System.Drawing.Point(168, 145);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(120, 20);
            this.labelDistance.TabIndex = 8;
            this.labelDistance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonWalk
            // 
            this.buttonWalk.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonWalk.Location = new System.Drawing.Point(18, 143);
            this.buttonWalk.Name = "buttonWalk";
            this.buttonWalk.Size = new System.Drawing.Size(135, 23);
            this.buttonWalk.TabIndex = 7;
            this.buttonWalk.Text = "Calculate Distance";
            this.buttonWalk.UseVisualStyleBackColor = false;
            this.buttonWalk.Click += new System.EventHandler(this.buttonWalk_Click);
            // 
            // numericUpDownLength
            // 
            this.numericUpDownLength.DecimalPlaces = 2;
            this.numericUpDownLength.Location = new System.Drawing.Point(168, 95);
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownLength.TabIndex = 6;
            // 
            // numericUpDownStep
            // 
            this.numericUpDownStep.Location = new System.Drawing.Point(168, 62);
            this.numericUpDownStep.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownStep.Name = "numericUpDownStep";
            this.numericUpDownStep.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownStep.TabIndex = 5;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(18, 97);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(144, 16);
            this.labelLength.TabIndex = 4;
            this.labelLength.Text = "Length of step (Inches):";
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(18, 64);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(111, 16);
            this.labelSteps.TabIndex = 3;
            this.labelSteps.Text = "Number of Steps:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(128, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(18, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 16);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Walker\'s Name:";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(288, 344);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDev
            // 
            this.labelDev.AutoSize = true;
            this.labelDev.Location = new System.Drawing.Point(249, 436);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(153, 16);
            this.labelDev.TabIndex = 2;
            this.labelDev.Text = "Developed by: Paul Huff";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(218, 83);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(214, 24);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Calculate Your Walk";
            // 
            // Program6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 456);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelDev);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxWalk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Program6";
            this.Text = "Assignment 3 - Program 6";
            this.groupBoxWalk.ResumeLayout(false);
            this.groupBoxWalk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWalk;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.NumericUpDown numericUpDownStep;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Button buttonWalk;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelDev;
        private System.Windows.Forms.Label labelTitle;
    }
}

