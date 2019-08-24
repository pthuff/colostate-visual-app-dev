namespace PHuffProgram13
{
    partial class Program13
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
            this.comboBoxTeams = new System.Windows.Forms.ComboBox();
            this.comboBoxChamps = new System.Windows.Forms.ComboBox();
            this.labelTeams = new System.Windows.Forms.Label();
            this.labelChamps = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonWins = new System.Windows.Forms.Button();
            this.buttonBToB = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDev = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTeams
            // 
            this.comboBoxTeams.FormattingEnabled = true;
            this.comboBoxTeams.Items.AddRange(new object[] {
            "Cardinals",
            "Falcons",
            "Ravens",
            "Bills",
            "Panthers",
            "Bears",
            "Bengals",
            "Browns",
            "Cowboys",
            "Broncos",
            "Lions",
            "Packers",
            "Texans",
            "Colts",
            "Jaguars",
            "Chiefs",
            "Dolphins",
            "Vikings",
            "Patriots",
            "Saints",
            "Giants",
            "Jets",
            "Raiders",
            "Eagles",
            "Steelers",
            "Chargers",
            "49ers",
            "Seahawks",
            "Rams",
            "Buccaneers",
            "Titans",
            "Redskins"});
            this.comboBoxTeams.Location = new System.Drawing.Point(28, 96);
            this.comboBoxTeams.Name = "comboBoxTeams";
            this.comboBoxTeams.Size = new System.Drawing.Size(162, 28);
            this.comboBoxTeams.TabIndex = 1;
            // 
            // comboBoxChamps
            // 
            this.comboBoxChamps.FormattingEnabled = true;
            this.comboBoxChamps.Items.AddRange(new object[] {
            "Packers",
            "Packers",
            "Jets",
            "Chiefs",
            "Colts",
            "Cowboys",
            "Dolphins",
            "Dolphins",
            "Steelers",
            "Steelers",
            "Raiders",
            "Cowboys",
            "Steelers",
            "Steelers",
            "Raiders",
            "49ers",
            "Redskins",
            "Raiders",
            "49ers",
            "Bears",
            "Giants",
            "Redskins",
            "49ers",
            "49ers",
            "Giants",
            "Redskins",
            "Cowboys",
            "Cowboys",
            "49ers",
            "Cowboys",
            "Packers",
            "Broncos",
            "Broncos",
            "Rams",
            "Ravens",
            "Patriots",
            "Buccaneers",
            "Patriots",
            "Patriots",
            "Steelers",
            "Colts",
            "Giants",
            "Steelers",
            "Saints",
            "Packers",
            "Giants",
            "Ravens",
            "Seahawks",
            "Patriots",
            "Broncos",
            "Patriots",
            "Eagles"});
            this.comboBoxChamps.Location = new System.Drawing.Point(211, 96);
            this.comboBoxChamps.Name = "comboBoxChamps";
            this.comboBoxChamps.Size = new System.Drawing.Size(162, 28);
            this.comboBoxChamps.TabIndex = 1;
            // 
            // labelTeams
            // 
            this.labelTeams.AutoSize = true;
            this.labelTeams.Location = new System.Drawing.Point(64, 55);
            this.labelTeams.Name = "labelTeams";
            this.labelTeams.Size = new System.Drawing.Size(91, 20);
            this.labelTeams.TabIndex = 2;
            this.labelTeams.Text = "NFL Teams";
            // 
            // labelChamps
            // 
            this.labelChamps.AutoSize = true;
            this.labelChamps.Location = new System.Drawing.Point(247, 45);
            this.labelChamps.Name = "labelChamps";
            this.labelChamps.Size = new System.Drawing.Size(90, 40);
            this.labelChamps.TabIndex = 2;
            this.labelChamps.Text = "Super Bowl\r\nChampions";
            // 
            // labelReturn
            // 
            this.labelReturn.BackColor = System.Drawing.SystemColors.Info;
            this.labelReturn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelReturn.Location = new System.Drawing.Point(394, 96);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(398, 28);
            this.labelReturn.TabIndex = 3;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(813, 96);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(84, 28);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonWins
            // 
            this.buttonWins.Location = new System.Drawing.Point(394, 51);
            this.buttonWins.Name = "buttonWins";
            this.buttonWins.Size = new System.Drawing.Size(154, 28);
            this.buttonWins.TabIndex = 4;
            this.buttonWins.Text = "How many wins?";
            this.buttonWins.UseVisualStyleBackColor = true;
            this.buttonWins.Click += new System.EventHandler(this.buttonWins_Click);
            // 
            // buttonBToB
            // 
            this.buttonBToB.Location = new System.Drawing.Point(565, 51);
            this.buttonBToB.Name = "buttonBToB";
            this.buttonBToB.Size = new System.Drawing.Size(332, 28);
            this.buttonBToB.TabIndex = 4;
            this.buttonBToB.Text = "How many times back-to-back champions?";
            this.buttonBToB.UseVisualStyleBackColor = true;
            this.buttonBToB.Click += new System.EventHandler(this.buttonBToB_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(371, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(150, 18);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "NFL Championships";
            // 
            // labelDev
            // 
            this.labelDev.AutoSize = true;
            this.labelDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDev.Location = new System.Drawing.Point(370, 166);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(153, 16);
            this.labelDev.TabIndex = 6;
            this.labelDev.Text = "Developed by: Paul Huff";
            // 
            // Program13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 187);
            this.Controls.Add(this.labelDev);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBToB);
            this.Controls.Add(this.buttonWins);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelReturn);
            this.Controls.Add(this.labelChamps);
            this.Controls.Add(this.labelTeams);
            this.Controls.Add(this.comboBoxChamps);
            this.Controls.Add(this.comboBoxTeams);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Program13";
            this.Text = "Assignment 5 - Program 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTeams;
        private System.Windows.Forms.ComboBox comboBoxChamps;
        private System.Windows.Forms.Label labelTeams;
        private System.Windows.Forms.Label labelChamps;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonWins;
        private System.Windows.Forms.Button buttonBToB;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDev;
    }
}

