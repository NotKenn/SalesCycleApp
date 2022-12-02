namespace AkutansiSiklusPenjualan
{
    partial class FormSales
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.invoiceIdSales = new System.Windows.Forms.TextBox();
            this.custIdSales = new System.Windows.Forms.TextBox();
            this.itemIdSales = new System.Windows.Forms.TextBox();
            this.WarehouseSales = new System.Windows.Forms.TextBox();
            this.dateTimeSales = new System.Windows.Forms.DateTimePicker();
            this.addBtnSales = new System.Windows.Forms.Button();
            this.editBtnSales = new System.Windows.Forms.Button();
            this.rmvBtnSales = new System.Windows.Forms.Button();
            this.srchBtnSales = new System.Windows.Forms.Button();
            this.dbAkutansiDataSet = new AkutansiSiklusPenjualan.dbAkutansiDataSet();
            this.dbAkutansiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new AkutansiSiklusPenjualan.dbAkutansiDataSetTableAdapters.CustomerTableAdapter();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new AkutansiSiklusPenjualan.dbAkutansiDataSetTableAdapters.ItemTableAdapter();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new AkutansiSiklusPenjualan.dbAkutansiDataSetTableAdapters.SalesTableAdapter();
            this.quantitySales = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAkutansiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAkutansiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 14F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 270);
            this.dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 12F);
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Invoice Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 12F);
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 12F);
            this.label4.Location = new System.Drawing.Point(14, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Item Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 12F);
            this.label5.Location = new System.Drawing.Point(290, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Warehouse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 12F);
            this.label6.Location = new System.Drawing.Point(290, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date and Time";
            // 
            // invoiceIdSales
            // 
            this.invoiceIdSales.Location = new System.Drawing.Point(131, 46);
            this.invoiceIdSales.Name = "invoiceIdSales";
            this.invoiceIdSales.Size = new System.Drawing.Size(100, 20);
            this.invoiceIdSales.TabIndex = 7;
            // 
            // custIdSales
            // 
            this.custIdSales.Location = new System.Drawing.Point(131, 83);
            this.custIdSales.Name = "custIdSales";
            this.custIdSales.Size = new System.Drawing.Size(100, 20);
            this.custIdSales.TabIndex = 8;
            // 
            // itemIdSales
            // 
            this.itemIdSales.Location = new System.Drawing.Point(131, 115);
            this.itemIdSales.Name = "itemIdSales";
            this.itemIdSales.Size = new System.Drawing.Size(100, 20);
            this.itemIdSales.TabIndex = 9;
            // 
            // WarehouseSales
            // 
            this.WarehouseSales.Location = new System.Drawing.Point(401, 46);
            this.WarehouseSales.Name = "WarehouseSales";
            this.WarehouseSales.Size = new System.Drawing.Size(100, 20);
            this.WarehouseSales.TabIndex = 10;
            // 
            // dateTimeSales
            // 
            this.dateTimeSales.Location = new System.Drawing.Point(401, 112);
            this.dateTimeSales.Name = "dateTimeSales";
            this.dateTimeSales.Size = new System.Drawing.Size(200, 20);
            this.dateTimeSales.TabIndex = 11;
            // 
            // addBtnSales
            // 
            this.addBtnSales.Location = new System.Drawing.Point(13, 139);
            this.addBtnSales.Name = "addBtnSales";
            this.addBtnSales.Size = new System.Drawing.Size(75, 23);
            this.addBtnSales.TabIndex = 12;
            this.addBtnSales.Text = "Add";
            this.addBtnSales.UseVisualStyleBackColor = true;
            this.addBtnSales.Click += new System.EventHandler(this.addBtnSales_Click);
            // 
            // editBtnSales
            // 
            this.editBtnSales.Location = new System.Drawing.Point(94, 139);
            this.editBtnSales.Name = "editBtnSales";
            this.editBtnSales.Size = new System.Drawing.Size(75, 23);
            this.editBtnSales.TabIndex = 13;
            this.editBtnSales.Text = "Edit";
            this.editBtnSales.UseVisualStyleBackColor = true;
            this.editBtnSales.Click += new System.EventHandler(this.editBtnSales_Click);
            // 
            // rmvBtnSales
            // 
            this.rmvBtnSales.Location = new System.Drawing.Point(175, 139);
            this.rmvBtnSales.Name = "rmvBtnSales";
            this.rmvBtnSales.Size = new System.Drawing.Size(75, 23);
            this.rmvBtnSales.TabIndex = 14;
            this.rmvBtnSales.Text = "Remove";
            this.rmvBtnSales.UseVisualStyleBackColor = true;
            this.rmvBtnSales.Click += new System.EventHandler(this.rmvBtnSales_Click);
            // 
            // srchBtnSales
            // 
            this.srchBtnSales.Location = new System.Drawing.Point(256, 139);
            this.srchBtnSales.Name = "srchBtnSales";
            this.srchBtnSales.Size = new System.Drawing.Size(75, 23);
            this.srchBtnSales.TabIndex = 15;
            this.srchBtnSales.Text = "Search";
            this.srchBtnSales.UseVisualStyleBackColor = true;
            this.srchBtnSales.Click += new System.EventHandler(this.srchBtnSales_Click);
            // 
            // dbAkutansiDataSet
            // 
            this.dbAkutansiDataSet.DataSetName = "dbAkutansiDataSet";
            this.dbAkutansiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbAkutansiDataSetBindingSource
            // 
            this.dbAkutansiDataSetBindingSource.DataSource = this.dbAkutansiDataSet;
            this.dbAkutansiDataSetBindingSource.Position = 0;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.dbAkutansiDataSetBindingSource;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.dbAkutansiDataSetBindingSource;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.dbAkutansiDataSetBindingSource;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // quantitySales
            // 
            this.quantitySales.Location = new System.Drawing.Point(401, 83);
            this.quantitySales.Name = "quantitySales";
            this.quantitySales.Size = new System.Drawing.Size(100, 20);
            this.quantitySales.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("High Tower Text", 12F);
            this.label7.Location = new System.Drawing.Point(290, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Qty";
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quantitySales);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.srchBtnSales);
            this.Controls.Add(this.rmvBtnSales);
            this.Controls.Add(this.editBtnSales);
            this.Controls.Add(this.addBtnSales);
            this.Controls.Add(this.dateTimeSales);
            this.Controls.Add(this.WarehouseSales);
            this.Controls.Add(this.itemIdSales);
            this.Controls.Add(this.custIdSales);
            this.Controls.Add(this.invoiceIdSales);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.FormSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAkutansiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbAkutansiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox invoiceIdSales;
        private System.Windows.Forms.TextBox custIdSales;
        private System.Windows.Forms.TextBox itemIdSales;
        private System.Windows.Forms.TextBox WarehouseSales;
        private System.Windows.Forms.DateTimePicker dateTimeSales;
        private System.Windows.Forms.Button addBtnSales;
        private System.Windows.Forms.Button editBtnSales;
        private System.Windows.Forms.Button rmvBtnSales;
        private System.Windows.Forms.Button srchBtnSales;
        private dbAkutansiDataSet dbAkutansiDataSet;
        private System.Windows.Forms.BindingSource dbAkutansiDataSetBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private dbAkutansiDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private dbAkutansiDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private dbAkutansiDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.TextBox quantitySales;
        private System.Windows.Forms.Label label7;
    }
}