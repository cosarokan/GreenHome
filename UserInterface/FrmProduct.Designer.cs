namespace UserInterface
{
    partial class FrmProduct
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProducerName = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.btnAddtoFavorite = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cBoxEvaluations = new System.Windows.Forms.ComboBox();
            this.btnToEvaluate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(431, 88);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(87, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProducerName
            // 
            this.lblProducerName.AutoSize = true;
            this.lblProducerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducerName.Location = new System.Drawing.Point(431, 120);
            this.lblProducerName.Name = "lblProducerName";
            this.lblProducerName.Size = new System.Drawing.Size(58, 13);
            this.lblProducerName.TabIndex = 2;
            this.lblProducerName.Text = "Producer";
            this.lblProducerName.Click += new System.EventHandler(this.lblProducerName_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(108, 246);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(137, 13);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "This product was shared by";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(242, 246);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(59, 13);
            this.lblCustomer.TabIndex = 4;
            this.lblCustomer.Text = "Customer";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(380, 88);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(47, 13);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "Product:";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(380, 120);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(53, 13);
            this.lblProducer.TabIndex = 5;
            this.lblProducer.Text = "Producer:";
            // 
            // btnAddtoFavorite
            // 
            this.btnAddtoFavorite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddtoFavorite.Location = new System.Drawing.Point(418, 185);
            this.btnAddtoFavorite.Name = "btnAddtoFavorite";
            this.btnAddtoFavorite.Size = new System.Drawing.Size(167, 50);
            this.btnAddtoFavorite.TabIndex = 6;
            this.btnAddtoFavorite.Text = "Add to Favorite";
            this.btnAddtoFavorite.UseVisualStyleBackColor = false;
            this.btnAddtoFavorite.Click += new System.EventHandler(this.btnAddtoFavorite_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(111, 303);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(244, 120);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Row";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Content";
            this.columnHeader2.Width = 120;
            // 
            // cBoxEvaluations
            // 
            this.cBoxEvaluations.FormattingEnabled = true;
            this.cBoxEvaluations.Location = new System.Drawing.Point(418, 303);
            this.cBoxEvaluations.Name = "cBoxEvaluations";
            this.cBoxEvaluations.Size = new System.Drawing.Size(167, 21);
            this.cBoxEvaluations.TabIndex = 10;
            // 
            // btnToEvaluate
            // 
            this.btnToEvaluate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnToEvaluate.Location = new System.Drawing.Point(418, 366);
            this.btnToEvaluate.Name = "btnToEvaluate";
            this.btnToEvaluate.Size = new System.Drawing.Size(167, 57);
            this.btnToEvaluate.TabIndex = 11;
            this.btnToEvaluate.Text = "To Evaluate";
            this.btnToEvaluate.UseVisualStyleBackColor = false;
            this.btnToEvaluate.Click += new System.EventHandler(this.btnToEvaluate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(111, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(730, 471);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnToEvaluate);
            this.Controls.Add(this.cBoxEvaluations);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAddtoFavorite);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblProducerName);
            this.Controls.Add(this.lblProductName);
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProducerName;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Button btnAddtoFavorite;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cBoxEvaluations;
        private System.Windows.Forms.Button btnToEvaluate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}