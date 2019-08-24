namespace PHuffProgram11
{
    partial class Program11
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
            this.groupBoxWater = new System.Windows.Forms.GroupBox();
            this.textBoxTank = new System.Windows.Forms.TextBox();
            this.buttonDrain = new System.Windows.Forms.Button();
            this.buttonAdjust = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.labelReturn = new System.Windows.Forms.Label();
            this.numericUpDownDrain = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAdd = new System.Windows.Forms.NumericUpDown();
            this.labelDrain = new System.Windows.Forms.Label();
            this.labelAdd = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDev = new System.Windows.Forms.Label();
            this.groupBoxTank = new System.Windows.Forms.GroupBox();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelRadius = new System.Windows.Forms.Label();
            this.numericUpDownDepth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.groupBoxWater.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdd)).BeginInit();
            this.groupBoxTank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(152, 29);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(202, 22);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Calculate a Water Tank";
            // 
            // groupBoxWater
            // 
            this.groupBoxWater.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxWater.Controls.Add(this.textBoxTank);
            this.groupBoxWater.Controls.Add(this.buttonDrain);
            this.groupBoxWater.Controls.Add(this.buttonAdjust);
            this.groupBoxWater.Controls.Add(this.buttonFill);
            this.groupBoxWater.Controls.Add(this.labelReturn);
            this.groupBoxWater.Controls.Add(this.numericUpDownDrain);
            this.groupBoxWater.Controls.Add(this.numericUpDownAdd);
            this.groupBoxWater.Controls.Add(this.labelDrain);
            this.groupBoxWater.Controls.Add(this.labelAdd);
            this.groupBoxWater.Location = new System.Drawing.Point(58, 212);
            this.groupBoxWater.Name = "groupBoxWater";
            this.groupBoxWater.Size = new System.Drawing.Size(395, 498);
            this.groupBoxWater.TabIndex = 1;
            this.groupBoxWater.TabStop = false;
            this.groupBoxWater.Text = "Water Level Adjustments";
            // 
            // textBoxTank
            // 
            this.textBoxTank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTank.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxTank.Location = new System.Drawing.Point(28, 309);
            this.textBoxTank.Multiline = true;
            this.textBoxTank.Name = "textBoxTank";
            this.textBoxTank.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTank.Size = new System.Drawing.Size(339, 168);
            this.textBoxTank.TabIndex = 9;
            this.textBoxTank.TabStop = false;
            // 
            // buttonDrain
            // 
            this.buttonDrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDrain.Enabled = false;
            this.buttonDrain.Location = new System.Drawing.Point(208, 268);
            this.buttonDrain.Name = "buttonDrain";
            this.buttonDrain.Size = new System.Drawing.Size(100, 35);
            this.buttonDrain.TabIndex = 7;
            this.buttonDrain.TabStop = false;
            this.buttonDrain.Text = "Drain Tank";
            this.buttonDrain.UseVisualStyleBackColor = true;
            this.buttonDrain.Click += new System.EventHandler(this.buttonDrain_Click);
            // 
            // buttonAdjust
            // 
            this.buttonAdjust.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdjust.Location = new System.Drawing.Point(119, 193);
            this.buttonAdjust.Name = "buttonAdjust";
            this.buttonAdjust.Size = new System.Drawing.Size(157, 35);
            this.buttonAdjust.TabIndex = 5;
            this.buttonAdjust.Text = "Adjust Water Level";
            this.buttonAdjust.UseVisualStyleBackColor = true;
            this.buttonAdjust.Click += new System.EventHandler(this.buttonAdjust_Click);
            // 
            // buttonFill
            // 
            this.buttonFill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFill.Enabled = false;
            this.buttonFill.Location = new System.Drawing.Point(86, 268);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(100, 35);
            this.buttonFill.TabIndex = 6;
            this.buttonFill.TabStop = false;
            this.buttonFill.Text = "Fill Tank";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // labelReturn
            // 
            this.labelReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReturn.BackColor = System.Drawing.SystemColors.Info;
            this.labelReturn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelReturn.Location = new System.Drawing.Point(28, 122);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(339, 63);
            this.labelReturn.TabIndex = 2;
            // 
            // numericUpDownDrain
            // 
            this.numericUpDownDrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownDrain.Location = new System.Drawing.Point(208, 84);
            this.numericUpDownDrain.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDrain.Name = "numericUpDownDrain";
            this.numericUpDownDrain.Size = new System.Drawing.Size(159, 26);
            this.numericUpDownDrain.TabIndex = 4;
            this.numericUpDownDrain.ThousandsSeparator = true;
            this.numericUpDownDrain.ValueChanged += new System.EventHandler(this.numericUpDownDrain_ValueChanged);
            // 
            // numericUpDownAdd
            // 
            this.numericUpDownAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownAdd.Location = new System.Drawing.Point(208, 47);
            this.numericUpDownAdd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAdd.Name = "numericUpDownAdd";
            this.numericUpDownAdd.Size = new System.Drawing.Size(159, 26);
            this.numericUpDownAdd.TabIndex = 3;
            this.numericUpDownAdd.ThousandsSeparator = true;
            this.numericUpDownAdd.ValueChanged += new System.EventHandler(this.numericUpDownAdd_ValueChanged);
            // 
            // labelDrain
            // 
            this.labelDrain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDrain.AutoSize = true;
            this.labelDrain.Location = new System.Drawing.Point(40, 87);
            this.labelDrain.Name = "labelDrain";
            this.labelDrain.Size = new System.Drawing.Size(146, 20);
            this.labelDrain.TabIndex = 0;
            this.labelDrain.Text = "Drain Water (1Gal):";
            // 
            // labelAdd
            // 
            this.labelAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(49, 50);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(137, 20);
            this.labelAdd.TabIndex = 0;
            this.labelAdd.Text = "Add Water (1Gal):";
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonReset.Enabled = false;
            this.buttonReset.Location = new System.Drawing.Point(167, 716);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(77, 30);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.TabStop = false;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.Location = new System.Drawing.Point(266, 716);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(77, 30);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.TabStop = false;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDev
            // 
            this.labelDev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDev.AutoSize = true;
            this.labelDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDev.Location = new System.Drawing.Point(177, 795);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(153, 16);
            this.labelDev.TabIndex = 4;
            this.labelDev.Text = "Developed by: Paul Huff";
            // 
            // groupBoxTank
            // 
            this.groupBoxTank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTank.Controls.Add(this.labelDepth);
            this.groupBoxTank.Controls.Add(this.labelRadius);
            this.groupBoxTank.Controls.Add(this.numericUpDownDepth);
            this.groupBoxTank.Controls.Add(this.numericUpDownRadius);
            this.groupBoxTank.Location = new System.Drawing.Point(58, 65);
            this.groupBoxTank.Name = "groupBoxTank";
            this.groupBoxTank.Size = new System.Drawing.Size(395, 129);
            this.groupBoxTank.TabIndex = 5;
            this.groupBoxTank.TabStop = false;
            this.groupBoxTank.Text = "Water Tank Dimensions";
            // 
            // labelDepth
            // 
            this.labelDepth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDepth.AutoSize = true;
            this.labelDepth.Location = new System.Drawing.Point(66, 83);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(120, 20);
            this.labelDepth.TabIndex = 0;
            this.labelDepth.Text = "Tank Depth (ft):";
            // 
            // labelRadius
            // 
            this.labelRadius.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(60, 46);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(126, 20);
            this.labelRadius.TabIndex = 0;
            this.labelRadius.Text = "Tank Radius (ft):";
            // 
            // numericUpDownDepth
            // 
            this.numericUpDownDepth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownDepth.Location = new System.Drawing.Point(208, 80);
            this.numericUpDownDepth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDepth.Name = "numericUpDownDepth";
            this.numericUpDownDepth.Size = new System.Drawing.Size(159, 26);
            this.numericUpDownDepth.TabIndex = 2;
            this.numericUpDownDepth.ThousandsSeparator = true;
            // 
            // numericUpDownRadius
            // 
            this.numericUpDownRadius.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownRadius.Location = new System.Drawing.Point(208, 43);
            this.numericUpDownRadius.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownRadius.Name = "numericUpDownRadius";
            this.numericUpDownRadius.Size = new System.Drawing.Size(159, 26);
            this.numericUpDownRadius.TabIndex = 1;
            this.numericUpDownRadius.ThousandsSeparator = true;
            // 
            // Program11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 818);
            this.Controls.Add(this.groupBoxTank);
            this.Controls.Add(this.labelDev);
            this.Controls.Add(this.groupBoxWater);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Program11";
            this.Text = "Assignment 5 - Program 11";
            this.groupBoxWater.ResumeLayout(false);
            this.groupBoxWater.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAdd)).EndInit();
            this.groupBoxTank.ResumeLayout(false);
            this.groupBoxTank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxWater;
        private System.Windows.Forms.Label labelDrain;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownDrain;
        private System.Windows.Forms.NumericUpDown numericUpDownAdd;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.Button buttonDrain;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelDev;
        private System.Windows.Forms.TextBox textBoxTank;
        private System.Windows.Forms.GroupBox groupBoxTank;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.NumericUpDown numericUpDownRadius;
        private System.Windows.Forms.Button buttonAdjust;
    }
}

