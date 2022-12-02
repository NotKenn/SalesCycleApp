namespace AkutansiSiklusPenjualan
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSales = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSales,
            this.menuItem,
            this.menuCustomer,
            this.menuAboutUs,
            this.menuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSales
            // 
            this.menuSales.Name = "menuSales";
            this.menuSales.Size = new System.Drawing.Size(50, 22);
            this.menuSales.Text = "Sales";
            this.menuSales.Click += new System.EventHandler(this.menuSales_Click);
            // 
            // menuItem
            // 
            this.menuItem.Name = "menuItem";
            this.menuItem.Size = new System.Drawing.Size(47, 22);
            this.menuItem.Text = "Item";
            this.menuItem.Click += new System.EventHandler(this.menuItem_Click);
            // 
            // menuCustomer
            // 
            this.menuCustomer.Name = "menuCustomer";
            this.menuCustomer.Size = new System.Drawing.Size(80, 22);
            this.menuCustomer.Text = "Customer";
            this.menuCustomer.Click += new System.EventHandler(this.menuCustomer_Click);
            // 
            // menuAboutUs
            // 
            this.menuAboutUs.Name = "menuAboutUs";
            this.menuAboutUs.Size = new System.Drawing.Size(79, 22);
            this.menuAboutUs.Text = "About Us";
            this.menuAboutUs.Click += new System.EventHandler(this.menuAboutUs_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(49, 22);
            this.menuHelp.Text = "Help";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 16F);
            this.label2.Location = new System.Drawing.Point(12, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(667, 130);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome To Our Sales Cycle Recorder System!\r\n\r\nTo Start, Inputs Customer Name, It" +
    "ems, And Invoices on the Sales Tab\r\n\r\nMore Info Regarding The Apps On Help Tab\r\n" +
    "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 285);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1025, 573);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSales;
        private System.Windows.Forms.ToolStripMenuItem menuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCustomer;
        private System.Windows.Forms.ToolStripMenuItem menuAboutUs;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

