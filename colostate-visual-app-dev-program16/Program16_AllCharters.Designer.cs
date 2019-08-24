namespace PhuffProgram16
{
    partial class Program16_AllCharters
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridViewCharters = new System.Windows.Forms.DataGridView();
            this.charterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yachtTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yachtSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charterHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charterFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCharters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(335, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(98, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "All Charters";
            // 
            // dataGridViewCharters
            // 
            this.dataGridViewCharters.AutoGenerateColumns = false;
            this.dataGridViewCharters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCharters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.yachtTypeDataGridViewTextBoxColumn,
            this.yachtSizeDataGridViewTextBoxColumn,
            this.charterHoursDataGridViewTextBoxColumn,
            this.charterFeeDataGridViewTextBoxColumn});
            this.dataGridViewCharters.DataSource = this.charterBindingSource;
            this.dataGridViewCharters.Location = new System.Drawing.Point(0, 29);
            this.dataGridViewCharters.Name = "dataGridViewCharters";
            this.dataGridViewCharters.Size = new System.Drawing.Size(768, 380);
            this.dataGridViewCharters.TabIndex = 2;
            // 
            // charterBindingSource
            // 
            this.charterBindingSource.DataSource = typeof(PhuffProgram16.Charter);
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // yachtTypeDataGridViewTextBoxColumn
            // 
            this.yachtTypeDataGridViewTextBoxColumn.DataPropertyName = "YachtType";
            this.yachtTypeDataGridViewTextBoxColumn.HeaderText = "Yacht Type";
            this.yachtTypeDataGridViewTextBoxColumn.Name = "yachtTypeDataGridViewTextBoxColumn";
            this.yachtTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.yachtTypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // yachtSizeDataGridViewTextBoxColumn
            // 
            this.yachtSizeDataGridViewTextBoxColumn.DataPropertyName = "YachtSize";
            this.yachtSizeDataGridViewTextBoxColumn.HeaderText = "YachtSize";
            this.yachtSizeDataGridViewTextBoxColumn.Name = "yachtSizeDataGridViewTextBoxColumn";
            this.yachtSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // charterHoursDataGridViewTextBoxColumn
            // 
            this.charterHoursDataGridViewTextBoxColumn.DataPropertyName = "CharterHours";
            this.charterHoursDataGridViewTextBoxColumn.HeaderText = "CharterHours";
            this.charterHoursDataGridViewTextBoxColumn.Name = "charterHoursDataGridViewTextBoxColumn";
            this.charterHoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // charterFeeDataGridViewTextBoxColumn
            // 
            this.charterFeeDataGridViewTextBoxColumn.DataPropertyName = "CharterFee";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.charterFeeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.charterFeeDataGridViewTextBoxColumn.HeaderText = "CharterFee";
            this.charterFeeDataGridViewTextBoxColumn.Name = "charterFeeDataGridViewTextBoxColumn";
            this.charterFeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.charterFeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Program16_AllCharters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 408);
            this.Controls.Add(this.dataGridViewCharters);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Program16_AllCharters";
            this.Text = "Assignment 7 - Program 16 - All Charters";
            this.Load += new System.EventHandler(this.Program16_AllCharters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCharters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridViewCharters;
        private System.Windows.Forms.BindingSource charterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yachtTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yachtSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charterHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charterFeeDataGridViewTextBoxColumn;
    }
}