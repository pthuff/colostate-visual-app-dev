namespace PHuffProgram3
{
    partial class Program3
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
            this.pictureBoxBroadmoor = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.lblSelection = new System.Windows.Forms.Label();
            this.radioBtnRed = new System.Windows.Forms.RadioButton();
            this.radioBtnGreen = new System.Windows.Forms.RadioButton();
            this.radioBtnBlue = new System.Windows.Forms.RadioButton();
            this.radioBtnOrange = new System.Windows.Forms.RadioButton();
            this.groupBoxRadioBtn = new System.Windows.Forms.GroupBox();
            this.groupBoxCheckBox = new System.Windows.Forms.GroupBox();
            this.checkBoxDev = new System.Windows.Forms.CheckBox();
            this.checkBoxLogo = new System.Windows.Forms.CheckBox();
            this.checkBoxTagline = new System.Windows.Forms.CheckBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.lblDev = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBroadmoor)).BeginInit();
            this.groupBoxRadioBtn.SuspendLayout();
            this.groupBoxCheckBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBroadmoor
            // 
            this.pictureBoxBroadmoor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxBroadmoor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBroadmoor.ImageLocation = "S:\\CIS605\\Huff,Paul (pthuff)\\Assignments\\Assignment 2\\PHuffProgram3\\images\\braodm" +
    "oor.jpg";
            this.pictureBoxBroadmoor.Location = new System.Drawing.Point(527, 296);
            this.pictureBoxBroadmoor.Name = "pictureBoxBroadmoor";
            this.pictureBoxBroadmoor.Size = new System.Drawing.Size(130, 88);
            this.pictureBoxBroadmoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBroadmoor.TabIndex = 0;
            this.pictureBoxBroadmoor.TabStop = false;
            this.pictureBoxBroadmoor.Click += new System.EventHandler(this.pictureBoxBroadmoor_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(291, 213);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(312, 34);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "The Broadmoor Hotel";
            // 
            // lblTagline
            // 
            this.lblTagline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTagline.AutoSize = true;
            this.lblTagline.Location = new System.Drawing.Point(609, 224);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(284, 20);
            this.lblTagline.TabIndex = 2;
            this.lblTagline.Text = "Destination Resort in Colorado Springs";
            // 
            // labelColor
            // 
            this.labelColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(6, 22);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(94, 20);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "Pick A Color";
            // 
            // lblSelection
            // 
            this.lblSelection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelection.AutoSize = true;
            this.lblSelection.Location = new System.Drawing.Point(6, 22);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(86, 20);
            this.lblSelection.TabIndex = 4;
            this.lblSelection.Text = "Show/Hide";
            // 
            // radioBtnRed
            // 
            this.radioBtnRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtnRed.AutoSize = true;
            this.radioBtnRed.Location = new System.Drawing.Point(10, 45);
            this.radioBtnRed.Name = "radioBtnRed";
            this.radioBtnRed.Size = new System.Drawing.Size(57, 24);
            this.radioBtnRed.TabIndex = 5;
            this.radioBtnRed.TabStop = true;
            this.radioBtnRed.Text = "&Red";
            this.radioBtnRed.UseVisualStyleBackColor = true;
            this.radioBtnRed.CheckedChanged += new System.EventHandler(this.radioBtnRed_CheckedChanged);
            // 
            // radioBtnGreen
            // 
            this.radioBtnGreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtnGreen.AutoSize = true;
            this.radioBtnGreen.Location = new System.Drawing.Point(10, 75);
            this.radioBtnGreen.Name = "radioBtnGreen";
            this.radioBtnGreen.Size = new System.Drawing.Size(72, 24);
            this.radioBtnGreen.TabIndex = 6;
            this.radioBtnGreen.TabStop = true;
            this.radioBtnGreen.Text = "&Green";
            this.radioBtnGreen.UseVisualStyleBackColor = true;
            this.radioBtnGreen.CheckedChanged += new System.EventHandler(this.radioBtnGreen_CheckedChanged);
            // 
            // radioBtnBlue
            // 
            this.radioBtnBlue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtnBlue.AutoSize = true;
            this.radioBtnBlue.Location = new System.Drawing.Point(10, 105);
            this.radioBtnBlue.Name = "radioBtnBlue";
            this.radioBtnBlue.Size = new System.Drawing.Size(59, 24);
            this.radioBtnBlue.TabIndex = 7;
            this.radioBtnBlue.TabStop = true;
            this.radioBtnBlue.Text = "&Blue";
            this.radioBtnBlue.UseVisualStyleBackColor = true;
            this.radioBtnBlue.CheckedChanged += new System.EventHandler(this.radioBtnBlue_CheckedChanged);
            // 
            // radioBtnOrange
            // 
            this.radioBtnOrange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtnOrange.AutoSize = true;
            this.radioBtnOrange.Location = new System.Drawing.Point(10, 135);
            this.radioBtnOrange.Name = "radioBtnOrange";
            this.radioBtnOrange.Size = new System.Drawing.Size(80, 24);
            this.radioBtnOrange.TabIndex = 8;
            this.radioBtnOrange.TabStop = true;
            this.radioBtnOrange.Text = "&Orange";
            this.radioBtnOrange.UseVisualStyleBackColor = true;
            this.radioBtnOrange.CheckedChanged += new System.EventHandler(this.radioBtnOrange_CheckedChanged);
            // 
            // groupBoxRadioBtn
            // 
            this.groupBoxRadioBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxRadioBtn.Controls.Add(this.labelColor);
            this.groupBoxRadioBtn.Controls.Add(this.radioBtnOrange);
            this.groupBoxRadioBtn.Controls.Add(this.radioBtnRed);
            this.groupBoxRadioBtn.Controls.Add(this.radioBtnBlue);
            this.groupBoxRadioBtn.Controls.Add(this.radioBtnGreen);
            this.groupBoxRadioBtn.Location = new System.Drawing.Point(321, 257);
            this.groupBoxRadioBtn.Name = "groupBoxRadioBtn";
            this.groupBoxRadioBtn.Size = new System.Drawing.Size(200, 172);
            this.groupBoxRadioBtn.TabIndex = 9;
            this.groupBoxRadioBtn.TabStop = false;
            // 
            // groupBoxCheckBox
            // 
            this.groupBoxCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxCheckBox.Controls.Add(this.checkBoxDev);
            this.groupBoxCheckBox.Controls.Add(this.checkBoxLogo);
            this.groupBoxCheckBox.Controls.Add(this.checkBoxTagline);
            this.groupBoxCheckBox.Controls.Add(this.checkBoxName);
            this.groupBoxCheckBox.Controls.Add(this.lblSelection);
            this.groupBoxCheckBox.Location = new System.Drawing.Point(663, 257);
            this.groupBoxCheckBox.Name = "groupBoxCheckBox";
            this.groupBoxCheckBox.Size = new System.Drawing.Size(200, 172);
            this.groupBoxCheckBox.TabIndex = 10;
            this.groupBoxCheckBox.TabStop = false;
            // 
            // checkBoxDev
            // 
            this.checkBoxDev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxDev.AutoSize = true;
            this.checkBoxDev.Checked = true;
            this.checkBoxDev.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDev.Location = new System.Drawing.Point(10, 139);
            this.checkBoxDev.Name = "checkBoxDev";
            this.checkBoxDev.Size = new System.Drawing.Size(100, 24);
            this.checkBoxDev.TabIndex = 8;
            this.checkBoxDev.Text = "&Developer";
            this.checkBoxDev.UseVisualStyleBackColor = true;
            this.checkBoxDev.CheckedChanged += new System.EventHandler(this.checkBoxDev_CheckedChanged);
            // 
            // checkBoxLogo
            // 
            this.checkBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxLogo.AutoSize = true;
            this.checkBoxLogo.Checked = true;
            this.checkBoxLogo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLogo.Location = new System.Drawing.Point(10, 108);
            this.checkBoxLogo.Name = "checkBoxLogo";
            this.checkBoxLogo.Size = new System.Drawing.Size(64, 24);
            this.checkBoxLogo.TabIndex = 7;
            this.checkBoxLogo.Text = "&Logo";
            this.checkBoxLogo.UseVisualStyleBackColor = true;
            this.checkBoxLogo.CheckedChanged += new System.EventHandler(this.checkBoxLogo_CheckedChanged);
            // 
            // checkBoxTagline
            // 
            this.checkBoxTagline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxTagline.AutoSize = true;
            this.checkBoxTagline.Checked = true;
            this.checkBoxTagline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTagline.Location = new System.Drawing.Point(10, 77);
            this.checkBoxTagline.Name = "checkBoxTagline";
            this.checkBoxTagline.Size = new System.Drawing.Size(79, 24);
            this.checkBoxTagline.TabIndex = 6;
            this.checkBoxTagline.Text = "&Tagline";
            this.checkBoxTagline.UseVisualStyleBackColor = true;
            this.checkBoxTagline.CheckedChanged += new System.EventHandler(this.checkBoxTagline_CheckedChanged);
            // 
            // checkBoxName
            // 
            this.checkBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Checked = true;
            this.checkBoxName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxName.Location = new System.Drawing.Point(10, 46);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(70, 24);
            this.checkBoxName.TabIndex = 5;
            this.checkBoxName.Text = "&Name";
            this.checkBoxName.UseVisualStyleBackColor = true;
            this.checkBoxName.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
            // 
            // lblDev
            // 
            this.lblDev.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDev.AutoSize = true;
            this.lblDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDev.Location = new System.Drawing.Point(517, 639);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(150, 16);
            this.lblDev.TabIndex = 11;
            this.lblDev.Text = "Developed by: Paul huff";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(537, 529);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 35);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Program3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.groupBoxCheckBox);
            this.Controls.Add(this.groupBoxRadioBtn);
            this.Controls.Add(this.lblTagline);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBoxBroadmoor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Program3";
            this.Text = "Assignment 2 - Program 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBroadmoor)).EndInit();
            this.groupBoxRadioBtn.ResumeLayout(false);
            this.groupBoxRadioBtn.PerformLayout();
            this.groupBoxCheckBox.ResumeLayout(false);
            this.groupBoxCheckBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBroadmoor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.RadioButton radioBtnRed;
        private System.Windows.Forms.RadioButton radioBtnGreen;
        private System.Windows.Forms.RadioButton radioBtnBlue;
        private System.Windows.Forms.RadioButton radioBtnOrange;
        private System.Windows.Forms.GroupBox groupBoxRadioBtn;
        private System.Windows.Forms.GroupBox groupBoxCheckBox;
        private System.Windows.Forms.CheckBox checkBoxTagline;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxDev;
        private System.Windows.Forms.CheckBox checkBoxLogo;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.Button btnExit;
    }
}

