namespace CIS605AS6
{
    partial class Program14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program14));
            this.grpStockInfo = new System.Windows.Forms.GroupBox();
            this.txtPrices = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSmallest = new System.Windows.Forms.Label();
            this.grpTriggers = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpAnalysis = new System.Windows.Forms.GroupBox();
            this.lblLongest = new System.Windows.Forms.Label();
            this.btnLongest = new System.Windows.Forms.Button();
            this.lblPositive = new System.Windows.Forms.Label();
            this.lblLargest = new System.Windows.Forms.Label();
            this.btnPositive = new System.Windows.Forms.Button();
            this.btnLargest = new System.Windows.Forms.Button();
            this.btnSmallest = new System.Windows.Forms.Button();
            this.grpStockInfo.SuspendLayout();
            this.grpTriggers.SuspendLayout();
            this.grpAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStockInfo
            // 
            this.grpStockInfo.Controls.Add(this.txtPrices);
            this.grpStockInfo.Controls.Add(this.txtSymbol);
            this.grpStockInfo.Controls.Add(this.btnCreate);
            this.grpStockInfo.Controls.Add(this.label2);
            this.grpStockInfo.Controls.Add(this.label1);
            this.grpStockInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpStockInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStockInfo.Location = new System.Drawing.Point(15, 72);
            this.grpStockInfo.Name = "grpStockInfo";
            this.grpStockInfo.Size = new System.Drawing.Size(353, 712);
            this.grpStockInfo.TabIndex = 0;
            this.grpStockInfo.TabStop = false;
            this.grpStockInfo.Text = "Stock Info:";
            // 
            // txtPrices
            // 
            this.txtPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrices.Location = new System.Drawing.Point(196, 100);
            this.txtPrices.Multiline = true;
            this.txtPrices.Name = "txtPrices";
            this.txtPrices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrices.Size = new System.Drawing.Size(138, 587);
            this.txtPrices.TabIndex = 10;
            this.txtPrices.Text = resources.GetString("txtPrices.Text");
            this.txtPrices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSymbol
            // 
            this.txtSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbol.Location = new System.Drawing.Point(196, 42);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(138, 26);
            this.txtSymbol.TabIndex = 9;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(15, 606);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(161, 81);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Create StockAnalyzer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock Prices:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticker Symbol:";
            // 
            // lblSmallest
            // 
            this.lblSmallest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSmallest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmallest.Location = new System.Drawing.Point(336, 37);
            this.lblSmallest.Name = "lblSmallest";
            this.lblSmallest.Size = new System.Drawing.Size(166, 41);
            this.lblSmallest.TabIndex = 16;
            this.lblSmallest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpTriggers
            // 
            this.grpTriggers.Controls.Add(this.btnExit);
            this.grpTriggers.Controls.Add(this.btnReset);
            this.grpTriggers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTriggers.Location = new System.Drawing.Point(390, 365);
            this.grpTriggers.Name = "grpTriggers";
            this.grpTriggers.Size = new System.Drawing.Size(419, 86);
            this.grpTriggers.TabIndex = 1;
            this.grpTriggers.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(227, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(44, 21);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(148, 45);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Create and use StockAnalyzer";
            // 
            // grpAnalysis
            // 
            this.grpAnalysis.Controls.Add(this.lblLongest);
            this.grpAnalysis.Controls.Add(this.btnLongest);
            this.grpAnalysis.Controls.Add(this.lblPositive);
            this.grpAnalysis.Controls.Add(this.lblLargest);
            this.grpAnalysis.Controls.Add(this.btnPositive);
            this.grpAnalysis.Controls.Add(this.btnLargest);
            this.grpAnalysis.Controls.Add(this.btnSmallest);
            this.grpAnalysis.Controls.Add(this.lblSmallest);
            this.grpAnalysis.Enabled = false;
            this.grpAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAnalysis.Location = new System.Drawing.Point(384, 72);
            this.grpAnalysis.Name = "grpAnalysis";
            this.grpAnalysis.Size = new System.Drawing.Size(529, 287);
            this.grpAnalysis.TabIndex = 17;
            this.grpAnalysis.TabStop = false;
            this.grpAnalysis.Text = "Display Stats:";
            // 
            // lblLongest
            // 
            this.lblLongest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLongest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongest.Location = new System.Drawing.Point(336, 219);
            this.lblLongest.Name = "lblLongest";
            this.lblLongest.Size = new System.Drawing.Size(166, 41);
            this.lblLongest.TabIndex = 24;
            this.lblLongest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLongest
            // 
            this.btnLongest.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLongest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLongest.Location = new System.Drawing.Point(6, 215);
            this.btnLongest.Name = "btnLongest";
            this.btnLongest.Size = new System.Drawing.Size(277, 45);
            this.btnLongest.TabIndex = 23;
            this.btnLongest.Text = "Longest Decline Streak";
            this.btnLongest.UseVisualStyleBackColor = true;
            this.btnLongest.Click += new System.EventHandler(this.btnLongest_Click);
            // 
            // lblPositive
            // 
            this.lblPositive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositive.Location = new System.Drawing.Point(336, 158);
            this.lblPositive.Name = "lblPositive";
            this.lblPositive.Size = new System.Drawing.Size(166, 41);
            this.lblPositive.TabIndex = 21;
            this.lblPositive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLargest
            // 
            this.lblLargest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLargest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargest.Location = new System.Drawing.Point(336, 100);
            this.lblLargest.Name = "lblLargest";
            this.lblLargest.Size = new System.Drawing.Size(166, 41);
            this.lblLargest.TabIndex = 20;
            this.lblLargest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPositive
            // 
            this.btnPositive.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPositive.Location = new System.Drawing.Point(6, 154);
            this.btnPositive.Name = "btnPositive";
            this.btnPositive.Size = new System.Drawing.Size(277, 45);
            this.btnPositive.TabIndex = 18;
            this.btnPositive.Text = "Times Positive Change";
            this.btnPositive.UseVisualStyleBackColor = true;
            this.btnPositive.Click += new System.EventHandler(this.btnPositive_Click);
            // 
            // btnLargest
            // 
            this.btnLargest.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLargest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLargest.Location = new System.Drawing.Point(6, 95);
            this.btnLargest.Name = "btnLargest";
            this.btnLargest.Size = new System.Drawing.Size(277, 45);
            this.btnLargest.TabIndex = 17;
            this.btnLargest.Text = "Largest Percentage Change";
            this.btnLargest.UseVisualStyleBackColor = true;
            this.btnLargest.Click += new System.EventHandler(this.btnLargest_Click);
            // 
            // btnSmallest
            // 
            this.btnSmallest.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSmallest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmallest.Location = new System.Drawing.Point(6, 36);
            this.btnSmallest.Name = "btnSmallest";
            this.btnSmallest.Size = new System.Drawing.Size(277, 45);
            this.btnSmallest.TabIndex = 1;
            this.btnSmallest.Text = "Smallest Change";
            this.btnSmallest.UseVisualStyleBackColor = true;
            this.btnSmallest.Click += new System.EventHandler(this.btnSmallest_Click);
            // 
            // Program14
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(926, 789);
            this.Controls.Add(this.grpAnalysis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpTriggers);
            this.Controls.Add(this.grpStockInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Program14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment Set 6 - Program 14";
            this.grpStockInfo.ResumeLayout(false);
            this.grpStockInfo.PerformLayout();
            this.grpTriggers.ResumeLayout(false);
            this.grpAnalysis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStockInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTriggers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSmallest;
        private System.Windows.Forms.TextBox txtPrices;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.GroupBox grpAnalysis;
        private System.Windows.Forms.Button btnSmallest;
        private System.Windows.Forms.Label lblLongest;
        private System.Windows.Forms.Button btnLongest;
        private System.Windows.Forms.Label lblPositive;
        private System.Windows.Forms.Label lblLargest;
        private System.Windows.Forms.Button btnPositive;
        private System.Windows.Forms.Button btnLargest;
    }
}

