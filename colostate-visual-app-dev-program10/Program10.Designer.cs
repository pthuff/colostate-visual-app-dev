namespace PHuffProgram10
{
    partial class Program10
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
            this.groupBoxTax = new System.Windows.Forms.GroupBox();
            this.buttonTax = new System.Windows.Forms.Button();
            this.radioButtonRural = new System.Windows.Forms.RadioButton();
            this.radioButtonSuburban = new System.Windows.Forms.RadioButton();
            this.radioButtonUrban = new System.Windows.Forms.RadioButton();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLand = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBuilding = new System.Windows.Forms.NumericUpDown();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelLand = new System.Windows.Forms.Label();
            this.labelBuilding = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDev = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxTax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuilding)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTax
            // 
            this.groupBoxTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTax.Controls.Add(this.radioButtonRural);
            this.groupBoxTax.Controls.Add(this.radioButtonSuburban);
            this.groupBoxTax.Controls.Add(this.radioButtonUrban);
            this.groupBoxTax.Controls.Add(this.numericUpDownYear);
            this.groupBoxTax.Controls.Add(this.numericUpDownLand);
            this.groupBoxTax.Controls.Add(this.numericUpDownBuilding);
            this.groupBoxTax.Controls.Add(this.labelLocation);
            this.groupBoxTax.Controls.Add(this.labelYear);
            this.groupBoxTax.Controls.Add(this.labelLand);
            this.groupBoxTax.Controls.Add(this.labelBuilding);
            this.groupBoxTax.Controls.Add(this.textBoxName);
            this.groupBoxTax.Controls.Add(this.labelName);
            this.groupBoxTax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTax.Location = new System.Drawing.Point(81, 66);
            this.groupBoxTax.Name = "groupBoxTax";
            this.groupBoxTax.Size = new System.Drawing.Size(707, 365);
            this.groupBoxTax.TabIndex = 0;
            this.groupBoxTax.TabStop = false;
            this.groupBoxTax.Text = "Property Information";
            // 
            // buttonTax
            // 
            this.buttonTax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTax.Location = new System.Drawing.Point(105, 486);
            this.buttonTax.Name = "buttonTax";
            this.buttonTax.Size = new System.Drawing.Size(162, 38);
            this.buttonTax.TabIndex = 6;
            this.buttonTax.Text = "Create Property Tax";
            this.buttonTax.UseVisualStyleBackColor = true;
            this.buttonTax.Click += new System.EventHandler(this.buttonTax_Click);
            // 
            // radioButtonRural
            // 
            this.radioButtonRural.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonRural.AutoSize = true;
            this.radioButtonRural.Location = new System.Drawing.Point(351, 298);
            this.radioButtonRural.Name = "radioButtonRural";
            this.radioButtonRural.Size = new System.Drawing.Size(65, 24);
            this.radioButtonRural.TabIndex = 5;
            this.radioButtonRural.TabStop = true;
            this.radioButtonRural.Text = "Rural";
            this.radioButtonRural.UseVisualStyleBackColor = true;
            this.radioButtonRural.CheckedChanged += new System.EventHandler(this.radioButtonRural_CheckedChanged);
            // 
            // radioButtonSuburban
            // 
            this.radioButtonSuburban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonSuburban.AutoSize = true;
            this.radioButtonSuburban.Location = new System.Drawing.Point(351, 267);
            this.radioButtonSuburban.Name = "radioButtonSuburban";
            this.radioButtonSuburban.Size = new System.Drawing.Size(97, 24);
            this.radioButtonSuburban.TabIndex = 5;
            this.radioButtonSuburban.TabStop = true;
            this.radioButtonSuburban.Text = "Suburban";
            this.radioButtonSuburban.UseVisualStyleBackColor = true;
            this.radioButtonSuburban.CheckedChanged += new System.EventHandler(this.radioButtonSuburban_CheckedChanged);
            // 
            // radioButtonUrban
            // 
            this.radioButtonUrban.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonUrban.AutoSize = true;
            this.radioButtonUrban.Location = new System.Drawing.Point(351, 236);
            this.radioButtonUrban.Name = "radioButtonUrban";
            this.radioButtonUrban.Size = new System.Drawing.Size(71, 24);
            this.radioButtonUrban.TabIndex = 5;
            this.radioButtonUrban.TabStop = true;
            this.radioButtonUrban.Text = "Urban";
            this.radioButtonUrban.UseVisualStyleBackColor = true;
            this.radioButtonUrban.CheckedChanged += new System.EventHandler(this.radioButtonUrban_CheckedChanged);
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownYear.Location = new System.Drawing.Point(351, 186);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(147, 26);
            this.numericUpDownYear.TabIndex = 4;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numericUpDownYear.ValueChanged += new System.EventHandler(this.numericUpDownYear_ValueChanged);
            // 
            // numericUpDownLand
            // 
            this.numericUpDownLand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownLand.Location = new System.Drawing.Point(351, 146);
            this.numericUpDownLand.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownLand.Name = "numericUpDownLand";
            this.numericUpDownLand.Size = new System.Drawing.Size(147, 26);
            this.numericUpDownLand.TabIndex = 3;
            this.numericUpDownLand.ThousandsSeparator = true;
            // 
            // numericUpDownBuilding
            // 
            this.numericUpDownBuilding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDownBuilding.Location = new System.Drawing.Point(351, 106);
            this.numericUpDownBuilding.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownBuilding.Name = "numericUpDownBuilding";
            this.numericUpDownBuilding.Size = new System.Drawing.Size(147, 26);
            this.numericUpDownBuilding.TabIndex = 2;
            this.numericUpDownBuilding.ThousandsSeparator = true;
            // 
            // labelLocation
            // 
            this.labelLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(249, 269);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(74, 20);
            this.labelLocation.TabIndex = 2;
            this.labelLocation.Text = "Location:";
            // 
            // labelYear
            // 
            this.labelYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(241, 188);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(82, 20);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Year Built:";
            // 
            // labelLand
            // 
            this.labelLand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLand.AutoSize = true;
            this.labelLand.Location = new System.Drawing.Point(154, 148);
            this.labelLand.Name = "labelLand";
            this.labelLand.Size = new System.Drawing.Size(169, 20);
            this.labelLand.TabIndex = 2;
            this.labelLand.Text = "Land Square Footage:";
            // 
            // labelBuilding
            // 
            this.labelBuilding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelBuilding.AutoSize = true;
            this.labelBuilding.Location = new System.Drawing.Point(134, 108);
            this.labelBuilding.Name = "labelBuilding";
            this.labelBuilding.Size = new System.Drawing.Size(189, 20);
            this.labelBuilding.TabIndex = 2;
            this.labelBuilding.Text = "Building Square Footage:";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(351, 66);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(211, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(207, 69);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(116, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Owner\'s Name:";
            // 
            // labelResult
            // 
            this.labelResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResult.BackColor = System.Drawing.SystemColors.Info;
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Location = new System.Drawing.Point(286, 443);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(474, 124);
            this.labelResult.TabIndex = 7;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.Location = new System.Drawing.Point(338, 608);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(92, 38);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.Location = new System.Drawing.Point(455, 608);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(92, 38);
            this.buttonExit.TabIndex = 6;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDev
            // 
            this.labelDev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDev.AutoSize = true;
            this.labelDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDev.Location = new System.Drawing.Point(362, 681);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(153, 16);
            this.labelDev.TabIndex = 7;
            this.labelDev.Text = "Developed by: Paul Huff";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(313, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(250, 24);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Property Tax Calculator";
            // 
            // Program10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 698);
            this.Controls.Add(this.buttonTax);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelDev);
            this.Controls.Add(this.groupBoxTax);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Program10";
            this.Text = "Assignment 4 - Program 10";
            this.groupBoxTax.ResumeLayout(false);
            this.groupBoxTax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBuilding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTax;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.NumericUpDown numericUpDownLand;
        private System.Windows.Forms.NumericUpDown numericUpDownBuilding;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelLand;
        private System.Windows.Forms.Label labelBuilding;
        private System.Windows.Forms.RadioButton radioButtonRural;
        private System.Windows.Forms.RadioButton radioButtonSuburban;
        private System.Windows.Forms.RadioButton radioButtonUrban;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonTax;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelDev;
        private System.Windows.Forms.Label labelTitle;
    }
}

