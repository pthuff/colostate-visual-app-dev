namespace PHuffProgram1
{
    partial class Program1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblReturnValue = new System.Windows.Forms.Label();
            this.btnActor = new System.Windows.Forms.Button();
            this.btnActress = new System.Windows.Forms.Button();
            this.btnDirector = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(304, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 39);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Top Gun";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblName.Click += new System.EventHandler(this.lblMovieName_Click);
            // 
            // lblReturnValue
            // 
            this.lblReturnValue.BackColor = System.Drawing.SystemColors.Control;
            this.lblReturnValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReturnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReturnValue.Location = new System.Drawing.Point(207, 155);
            this.lblReturnValue.Name = "lblReturnValue";
            this.lblReturnValue.Size = new System.Drawing.Size(343, 42);
            this.lblReturnValue.TabIndex = 5;
            this.lblReturnValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReturnValue.Click += new System.EventHandler(this.lblReturnValue_Click);
            // 
            // btnActor
            // 
            this.btnActor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActor.Location = new System.Drawing.Point(64, 247);
            this.btnActor.Name = "btnActor";
            this.btnActor.Size = new System.Drawing.Size(151, 37);
            this.btnActor.TabIndex = 6;
            this.btnActor.Text = "Lead Actor";
            this.btnActor.UseVisualStyleBackColor = true;
            this.btnActor.Click += new System.EventHandler(this.btnActor_Click);
            // 
            // btnActress
            // 
            this.btnActress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActress.Location = new System.Drawing.Point(221, 247);
            this.btnActress.Name = "btnActress";
            this.btnActress.Size = new System.Drawing.Size(151, 37);
            this.btnActress.TabIndex = 7;
            this.btnActress.Text = "Lead Actress";
            this.btnActress.UseVisualStyleBackColor = true;
            this.btnActress.Click += new System.EventHandler(this.btnActress_Click);
            // 
            // btnDirector
            // 
            this.btnDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDirector.Location = new System.Drawing.Point(378, 247);
            this.btnDirector.Name = "btnDirector";
            this.btnDirector.Size = new System.Drawing.Size(151, 37);
            this.btnDirector.TabIndex = 8;
            this.btnDirector.Text = "Director";
            this.btnDirector.UseVisualStyleBackColor = true;
            this.btnDirector.Click += new System.EventHandler(this.btnDirector_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(535, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Paul Huff";
            // 
            // Program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDirector);
            this.Controls.Add(this.btnActress);
            this.Controls.Add(this.btnActor);
            this.Controls.Add(this.lblReturnValue);
            this.Controls.Add(this.lblName);
            this.Name = "Program1";
            this.Text = "Assignment 1 - Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblReturnValue;
        private System.Windows.Forms.Button btnActor;
        private System.Windows.Forms.Button btnActress;
        private System.Windows.Forms.Button btnDirector;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

