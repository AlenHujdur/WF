namespace WindowsFormsApp1
{
    partial class Sales
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesRecordIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productFKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDataSet = new WindowsFormsApp1.SalesDataSet();
            this.salesRecordsTableAdapter = new WindowsFormsApp1.SalesDataSetTableAdapters.SalesRecordsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesRecordIdDataGridViewTextBoxColumn,
            this.customerFKDataGridViewTextBoxColumn,
            this.productFKDataGridViewTextBoxColumn,
            this.infoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesRecordsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(454, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // salesRecordIdDataGridViewTextBoxColumn
            // 
            this.salesRecordIdDataGridViewTextBoxColumn.DataPropertyName = "SalesRecordId";
            this.salesRecordIdDataGridViewTextBoxColumn.HeaderText = "SalesRecordId";
            this.salesRecordIdDataGridViewTextBoxColumn.Name = "salesRecordIdDataGridViewTextBoxColumn";
            this.salesRecordIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerFKDataGridViewTextBoxColumn
            // 
            this.customerFKDataGridViewTextBoxColumn.DataPropertyName = "CustomerFK";
            this.customerFKDataGridViewTextBoxColumn.HeaderText = "CustomerFK";
            this.customerFKDataGridViewTextBoxColumn.Name = "customerFKDataGridViewTextBoxColumn";
            // 
            // productFKDataGridViewTextBoxColumn
            // 
            this.productFKDataGridViewTextBoxColumn.DataPropertyName = "ProductFK";
            this.productFKDataGridViewTextBoxColumn.HeaderText = "ProductFK";
            this.productFKDataGridViewTextBoxColumn.Name = "productFKDataGridViewTextBoxColumn";
            // 
            // infoDataGridViewTextBoxColumn
            // 
            this.infoDataGridViewTextBoxColumn.DataPropertyName = "Info";
            this.infoDataGridViewTextBoxColumn.HeaderText = "Info";
            this.infoDataGridViewTextBoxColumn.Name = "infoDataGridViewTextBoxColumn";
            // 
            // salesRecordsBindingSource
            // 
            this.salesRecordsBindingSource.DataMember = "SalesRecords";
            this.salesRecordsBindingSource.DataSource = this.salesDataSet;
            // 
            // salesDataSet
            // 
            this.salesDataSet.DataSetName = "SalesDataSet";
            this.salesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesRecordsTableAdapter
            // 
            this.salesRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SalesDataSet salesDataSet;
        private System.Windows.Forms.BindingSource salesRecordsBindingSource;
        private SalesDataSetTableAdapters.SalesRecordsTableAdapter salesRecordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesRecordIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productFKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoDataGridViewTextBoxColumn;
    }
}

