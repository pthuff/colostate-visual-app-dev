namespace PHuffProgram4
{
    partial class Program4
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
            this.numericValue = new System.Windows.Forms.NumericUpDown();
            this.numericDuration = new System.Windows.Forms.NumericUpDown();
            this.numericRate = new System.Windows.Forms.NumericUpDown();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.btnFutureValue = new System.Windows.Forms.Button();
            this.lblFutureValueReturn = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRate)).BeginInit();
            this.SuspendLayout();
            // 
            // numericValue
            // 
            this.numericValue.DecimalPlaces = 2;
            this.numericValue.Location = new System.Drawing.Point(396, 172);
            this.numericValue.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numericValue.Name = "numericValue";
            this.numericValue.Size = new System.Drawing.Size(120, 22);
            this.numericValue.TabIndex = 0;
            this.numericValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericDuration
            // 
            this.numericDuration.Location = new System.Drawing.Point(396, 200);
            this.numericDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericDuration.Name = "numericDuration";
            this.numericDuration.Size = new System.Drawing.Size(120, 22);
            this.numericDuration.TabIndex = 1;
            this.numericDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericRate
            // 
            this.numericRate.DecimalPlaces = 2;
            this.numericRate.Location = new System.Drawing.Point(396, 228);
            this.numericRate.Name = "numericRate";
            this.numericRate.Size = new System.Drawing.Size(120, 22);
            this.numericRate.TabIndex = 2;
            this.numericRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.BackColor = System.Drawing.SystemColors.Info;
            this.lblValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValue.Location = new System.Drawing.Point(244, 174);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(125, 18);
            this.lblValue.TabIndex = 3;
            this.lblValue.Text = "Initial Investment ($)";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.SystemColors.Info;
            this.lblDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDuration.Location = new System.Drawing.Point(253, 202);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(107, 18);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "Duration (Years)";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.SystemColors.Info;
            this.lblRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRate.Location = new System.Drawing.Point(245, 230);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(122, 18);
            this.lblRate.TabIndex = 5;
            this.lblRate.Text = "Rate of Interest (%)";
            // 
            // btnFutureValue
            // 
            this.btnFutureValue.AutoSize = true;
            this.btnFutureValue.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFutureValue.Location = new System.Drawing.Point(222, 263);
            this.btnFutureValue.Name = "btnFutureValue";
            this.btnFutureValue.Size = new System.Drawing.Size(167, 26);
            this.btnFutureValue.TabIndex = 6;
            this.btnFutureValue.Text = "Calculate Future Value";
            this.btnFutureValue.UseVisualStyleBackColor = false;
            this.btnFutureValue.Click += new System.EventHandler(this.btnFutureValue_Click);
            // 
            // lblFutureValueReturn
            // 
            this.lblFutureValueReturn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFutureValueReturn.Location = new System.Drawing.Point(396, 263);
            this.lblFutureValueReturn.Name = "lblFutureValueReturn";
            this.lblFutureValueReturn.Size = new System.Drawing.Size(131, 26);
            this.lblFutureValueReturn.TabIndex = 7;
            this.lblFutureValueReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.Location = new System.Drawing.Point(253, 295);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset Values";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(337, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(298, 467);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(153, 16);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "Developed by: Paul Huff";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(265, 89);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(219, 24);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Calculate Future Value";
            // 
            // Program4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 508);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblFutureValueReturn);
            this.Controls.Add(this.btnFutureValue);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.numericRate);
            this.Controls.Add(this.numericDuration);
            this.Controls.Add(this.numericValue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Program4";
            this.Text = "Assignment 2 - Program 4";
            ((System.ComponentModel.ISupportInitialize)(this.numericValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericValue;
        private System.Windows.Forms.NumericUpDown numericDuration;
        private System.Windows.Forms.NumericUpDown numericRate;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnFutureValue;
        private System.Windows.Forms.Label lblFutureValueReturn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
    }
}

