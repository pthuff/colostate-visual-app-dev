namespace PHuffProgram9
{
    partial class Program9
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
            this.groupBoxCateringEvent = new System.Windows.Forms.GroupBox();
            this.checkBoxWine = new System.Windows.Forms.CheckBox();
            this.checkBoxOpenBar = new System.Windows.Forms.CheckBox();
            this.labelDrinks = new System.Windows.Forms.Label();
            this.radioButtonGardenLasagna = new System.Windows.Forms.RadioButton();
            this.radioButtonChickenMarsala = new System.Windows.Forms.RadioButton();
            this.radioButtonPrimeRib = new System.Windows.Forms.RadioButton();
            this.labelEntre = new System.Windows.Forms.Label();
            this.labelGuests = new System.Windows.Forms.Label();
            this.numericUpDownGuests = new System.Windows.Forms.NumericUpDown();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelDev = new System.Windows.Forms.Label();
            this.groupBoxCateringEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCateringEvent
            // 
            this.groupBoxCateringEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxCateringEvent.Controls.Add(this.checkBoxWine);
            this.groupBoxCateringEvent.Controls.Add(this.checkBoxOpenBar);
            this.groupBoxCateringEvent.Controls.Add(this.labelDrinks);
            this.groupBoxCateringEvent.Controls.Add(this.radioButtonGardenLasagna);
            this.groupBoxCateringEvent.Controls.Add(this.radioButtonChickenMarsala);
            this.groupBoxCateringEvent.Controls.Add(this.radioButtonPrimeRib);
            this.groupBoxCateringEvent.Controls.Add(this.labelEntre);
            this.groupBoxCateringEvent.Controls.Add(this.labelGuests);
            this.groupBoxCateringEvent.Controls.Add(this.numericUpDownGuests);
            this.groupBoxCateringEvent.Controls.Add(this.labelName);
            this.groupBoxCateringEvent.Controls.Add(this.textBoxName);
            this.groupBoxCateringEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxCateringEvent.Location = new System.Drawing.Point(42, 98);
            this.groupBoxCateringEvent.Name = "groupBoxCateringEvent";
            this.groupBoxCateringEvent.Size = new System.Drawing.Size(382, 328);
            this.groupBoxCateringEvent.TabIndex = 0;
            this.groupBoxCateringEvent.TabStop = false;
            this.groupBoxCateringEvent.Text = "Event Information";
            // 
            // checkBoxWine
            // 
            this.checkBoxWine.AutoSize = true;
            this.checkBoxWine.Location = new System.Drawing.Point(184, 275);
            this.checkBoxWine.Name = "checkBoxWine";
            this.checkBoxWine.Size = new System.Drawing.Size(147, 24);
            this.checkBoxWine.TabIndex = 10;
            this.checkBoxWine.Text = "Wine with Dinner";
            this.checkBoxWine.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpenBar
            // 
            this.checkBoxOpenBar.AutoSize = true;
            this.checkBoxOpenBar.Location = new System.Drawing.Point(184, 245);
            this.checkBoxOpenBar.Name = "checkBoxOpenBar";
            this.checkBoxOpenBar.Size = new System.Drawing.Size(96, 24);
            this.checkBoxOpenBar.TabIndex = 9;
            this.checkBoxOpenBar.Text = "Open Bar";
            this.checkBoxOpenBar.UseVisualStyleBackColor = true;
            // 
            // labelDrinks
            // 
            this.labelDrinks.AutoSize = true;
            this.labelDrinks.Location = new System.Drawing.Point(101, 262);
            this.labelDrinks.Name = "labelDrinks";
            this.labelDrinks.Size = new System.Drawing.Size(58, 20);
            this.labelDrinks.TabIndex = 8;
            this.labelDrinks.Text = "Drinks:";
            // 
            // radioButtonGardenLasagna
            // 
            this.radioButtonGardenLasagna.AutoSize = true;
            this.radioButtonGardenLasagna.Location = new System.Drawing.Point(184, 199);
            this.radioButtonGardenLasagna.Name = "radioButtonGardenLasagna";
            this.radioButtonGardenLasagna.Size = new System.Drawing.Size(147, 24);
            this.radioButtonGardenLasagna.TabIndex = 7;
            this.radioButtonGardenLasagna.TabStop = true;
            this.radioButtonGardenLasagna.Text = "Garden Lasagna";
            this.radioButtonGardenLasagna.UseVisualStyleBackColor = true;
            this.radioButtonGardenLasagna.CheckedChanged += new System.EventHandler(this.radioButtonGardenLasagna_CheckedChanged);
            // 
            // radioButtonChickenMarsala
            // 
            this.radioButtonChickenMarsala.AutoSize = true;
            this.radioButtonChickenMarsala.Location = new System.Drawing.Point(184, 169);
            this.radioButtonChickenMarsala.Name = "radioButtonChickenMarsala";
            this.radioButtonChickenMarsala.Size = new System.Drawing.Size(144, 24);
            this.radioButtonChickenMarsala.TabIndex = 6;
            this.radioButtonChickenMarsala.TabStop = true;
            this.radioButtonChickenMarsala.Text = "Chicken Marsala";
            this.radioButtonChickenMarsala.UseVisualStyleBackColor = true;
            this.radioButtonChickenMarsala.CheckedChanged += new System.EventHandler(this.radioButtonChickenMarsala_CheckedChanged);
            // 
            // radioButtonPrimeRib
            // 
            this.radioButtonPrimeRib.AutoSize = true;
            this.radioButtonPrimeRib.Location = new System.Drawing.Point(184, 139);
            this.radioButtonPrimeRib.Name = "radioButtonPrimeRib";
            this.radioButtonPrimeRib.Size = new System.Drawing.Size(95, 24);
            this.radioButtonPrimeRib.TabIndex = 5;
            this.radioButtonPrimeRib.TabStop = true;
            this.radioButtonPrimeRib.Text = "Prime Rib";
            this.radioButtonPrimeRib.UseVisualStyleBackColor = true;
            this.radioButtonPrimeRib.CheckedChanged += new System.EventHandler(this.radioButtonPrimeRib_CheckedChanged);
            // 
            // labelEntre
            // 
            this.labelEntre.AutoSize = true;
            this.labelEntre.Location = new System.Drawing.Point(101, 171);
            this.labelEntre.Name = "labelEntre";
            this.labelEntre.Size = new System.Drawing.Size(52, 20);
            this.labelEntre.TabIndex = 4;
            this.labelEntre.Text = "Entre:";
            // 
            // labelGuests
            // 
            this.labelGuests.AutoSize = true;
            this.labelGuests.Location = new System.Drawing.Point(10, 94);
            this.labelGuests.Name = "labelGuests";
            this.labelGuests.Size = new System.Drawing.Size(143, 20);
            this.labelGuests.TabIndex = 3;
            this.labelGuests.Text = "Number of Guests:";
            // 
            // numericUpDownGuests
            // 
            this.numericUpDownGuests.Location = new System.Drawing.Point(184, 92);
            this.numericUpDownGuests.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownGuests.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownGuests.Name = "numericUpDownGuests";
            this.numericUpDownGuests.Size = new System.Drawing.Size(131, 26);
            this.numericUpDownGuests.TabIndex = 2;
            this.numericUpDownGuests.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Event Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(134, 52);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(231, 26);
            this.textBoxName.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(258, 53);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(271, 24);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Catering Event Calculator";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCreate.Location = new System.Drawing.Point(434, 184);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(177, 36);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Create Catering Event";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModify.Enabled = false;
            this.buttonModify.Location = new System.Drawing.Point(617, 184);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(177, 36);
            this.buttonModify.TabIndex = 2;
            this.buttonModify.Text = "Modify Catering Event";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // labelResult
            // 
            this.labelResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResult.BackColor = System.Drawing.SystemColors.Info;
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Location = new System.Drawing.Point(434, 238);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(360, 83);
            this.labelResult.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.Location = new System.Drawing.Point(534, 344);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(77, 36);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.Location = new System.Drawing.Point(617, 344);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(77, 36);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelDev
            // 
            this.labelDev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDev.AutoSize = true;
            this.labelDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDev.Location = new System.Drawing.Point(317, 500);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(153, 16);
            this.labelDev.TabIndex = 4;
            this.labelDev.Text = "Developed by: Paul Huff";
            // 
            // Program9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 519);
            this.Controls.Add(this.labelDev);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.groupBoxCateringEvent);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Program9";
            this.Text = "Assignment 4 - Program 9";
            this.groupBoxCateringEvent.ResumeLayout(false);
            this.groupBoxCateringEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCateringEvent;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RadioButton radioButtonPrimeRib;
        private System.Windows.Forms.Label labelEntre;
        private System.Windows.Forms.Label labelGuests;
        private System.Windows.Forms.NumericUpDown numericUpDownGuests;
        private System.Windows.Forms.RadioButton radioButtonGardenLasagna;
        private System.Windows.Forms.RadioButton radioButtonChickenMarsala;
        private System.Windows.Forms.CheckBox checkBoxWine;
        private System.Windows.Forms.CheckBox checkBoxOpenBar;
        private System.Windows.Forms.Label labelDrinks;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelDev;
    }
}

