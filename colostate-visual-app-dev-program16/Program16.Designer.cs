namespace PhuffProgram16
{
    partial class Program16
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
            this.components = new System.ComponentModel.Container();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAllCharters = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNumOfCharters = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChartersSummary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAddYacht = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveYacht = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.contextMenuStripType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.lblType = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.lblDev = new System.Windows.Forms.Label();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.contextMenuStripType.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDisplay,
            this.mnuEdit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(555, 29);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuMain";
            // 
            // mnuDisplay
            // 
            this.mnuDisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAllCharters,
            this.mnuNumOfCharters,
            this.mnuChartersSummary,
            this.toolStripSeparator1,
            this.mnuExit});
            this.mnuDisplay.Name = "mnuDisplay";
            this.mnuDisplay.Size = new System.Drawing.Size(73, 25);
            this.mnuDisplay.Text = "&Display";
            // 
            // mnuAllCharters
            // 
            this.mnuAllCharters.Enabled = false;
            this.mnuAllCharters.Name = "mnuAllCharters";
            this.mnuAllCharters.Size = new System.Drawing.Size(329, 26);
            this.mnuAllCharters.Text = "All Charters";
            this.mnuAllCharters.Click += new System.EventHandler(this.mnuAllCharters_Click);
            // 
            // mnuNumOfCharters
            // 
            this.mnuNumOfCharters.Enabled = false;
            this.mnuNumOfCharters.Name = "mnuNumOfCharters";
            this.mnuNumOfCharters.Size = new System.Drawing.Size(329, 26);
            this.mnuNumOfCharters.Text = "Number of Charters for a Yacht Size";
            this.mnuNumOfCharters.Click += new System.EventHandler(this.mnuNumOfCharters_Click);
            // 
            // mnuChartersSummary
            // 
            this.mnuChartersSummary.Enabled = false;
            this.mnuChartersSummary.Name = "mnuChartersSummary";
            this.mnuChartersSummary.Size = new System.Drawing.Size(329, 26);
            this.mnuChartersSummary.Text = "Charters Summary";
            this.mnuChartersSummary.Click += new System.EventHandler(this.mnuChartersSummary_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(326, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(329, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReset,
            this.toolStripSeparator2,
            this.mnuAddYacht,
            this.mnuRemoveYacht});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(48, 25);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuReset
            // 
            this.mnuReset.Name = "mnuReset";
            this.mnuReset.Size = new System.Drawing.Size(234, 26);
            this.mnuReset.Text = "Reset for Next Charter";
            this.mnuReset.Click += new System.EventHandler(this.mnuReset_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(231, 6);
            // 
            // mnuAddYacht
            // 
            this.mnuAddYacht.Name = "mnuAddYacht";
            this.mnuAddYacht.Size = new System.Drawing.Size(234, 26);
            this.mnuAddYacht.Text = "Add Yacht Type";
            this.mnuAddYacht.Click += new System.EventHandler(this.mnuAddYacht_Click);
            // 
            // mnuRemoveYacht
            // 
            this.mnuRemoveYacht.Name = "mnuRemoveYacht";
            this.mnuRemoveYacht.Size = new System.Drawing.Size(234, 26);
            this.mnuRemoveYacht.Text = "Remove Yacht Type";
            this.mnuRemoveYacht.Click += new System.EventHandler(this.mnuRemoveYacht_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(191, 73);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 22);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Create a Charter";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(89, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Customer Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(244, 128);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(214, 26);
            this.textBoxName.TabIndex = 3;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(122, 187);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(98, 20);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Hours Used:";
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.DecimalPlaces = 2;
            this.numericUpDownHours.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericUpDownHours.Location = new System.Drawing.Point(244, 184);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownHours.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownHours.TabIndex = 4;
            this.numericUpDownHours.Value = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            // 
            // comboBoxType
            // 
            this.comboBoxType.ContextMenuStrip = this.contextMenuStripType;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Express Cruiser",
            "Flybridge",
            "Sedan Bridge",
            "Moto Yacht",
            "Tri-Deck",
            "Sportfish",
            "Skylounge",
            "Mega Yacht"});
            this.comboBoxType.Location = new System.Drawing.Point(244, 240);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(182, 28);
            this.comboBoxType.TabIndex = 5;
            // 
            // contextMenuStripType
            // 
            this.contextMenuStripType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAdd,
            this.toolStripMenuItemRemove});
            this.contextMenuStripType.Name = "contextMenuStripType";
            this.contextMenuStripType.Size = new System.Drawing.Size(181, 70);
            // 
            // toolStripMenuItemAdd
            // 
            this.toolStripMenuItemAdd.Name = "toolStripMenuItemAdd";
            this.toolStripMenuItemAdd.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemAdd.Text = "Add Yacht Type";
            this.toolStripMenuItemAdd.Click += new System.EventHandler(this.toolStripMenuItemAdd_Click);
            // 
            // toolStripMenuItemRemove
            // 
            this.toolStripMenuItemRemove.Name = "toolStripMenuItemRemove";
            this.toolStripMenuItemRemove.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemRemove.Text = "Remove Yacht Type";
            this.toolStripMenuItemRemove.Click += new System.EventHandler(this.toolStripMenuItemRemove_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(113, 244);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(104, 20);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Charter Type:";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "22",
            "24",
            "30",
            "32",
            "36",
            "38",
            "45"});
            this.comboBoxSize.Location = new System.Drawing.Point(244, 298);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(182, 28);
            this.comboBoxSize.TabIndex = 5;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(116, 302);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(101, 20);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Charter Size:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(212, 359);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 33);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add Charter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.Location = new System.Drawing.Point(196, 457);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(153, 16);
            this.lblDev.TabIndex = 7;
            this.lblDev.Text = "Developed by: Paul Huff";
            // 
            // Program16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 477);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Program16";
            this.Text = "Assignment 7 - Program 16";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.contextMenuStripType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplay;
        private System.Windows.Forms.ToolStripMenuItem mnuAllCharters;
        private System.Windows.Forms.ToolStripMenuItem mnuNumOfCharters;
        private System.Windows.Forms.ToolStripMenuItem mnuChartersSummary;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuAddYacht;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveYacht;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripType;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRemove;
    }
}

