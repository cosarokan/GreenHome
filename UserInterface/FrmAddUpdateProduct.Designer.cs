namespace UserInterface
{
    partial class FrmAddUpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUpdateProduct));
            this.lblBarcodeNumber = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductContent = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtBarcodeNumber = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductContent = new System.Windows.Forms.TextBox();
            this.cBoxProducer = new System.Windows.Forms.ComboBox();
            this.cBoxCategory = new System.Windows.Forms.ComboBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pBoxProductPicture = new System.Windows.Forms.PictureBox();
            this.lblPicture = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGotoHome = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtPictureAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProductPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBarcodeNumber
            // 
            this.lblBarcodeNumber.AutoSize = true;
            this.lblBarcodeNumber.Location = new System.Drawing.Point(117, 32);
            this.lblBarcodeNumber.Name = "lblBarcodeNumber";
            this.lblBarcodeNumber.Size = new System.Drawing.Size(87, 13);
            this.lblBarcodeNumber.TabIndex = 0;
            this.lblBarcodeNumber.Text = "Barcode Number";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(117, 72);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(50, 13);
            this.lblProducer.TabIndex = 0;
            this.lblProducer.Text = "Producer";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(117, 112);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductContent
            // 
            this.lblProductContent.AutoSize = true;
            this.lblProductContent.Location = new System.Drawing.Point(117, 192);
            this.lblProductContent.Name = "lblProductContent";
            this.lblProductContent.Size = new System.Drawing.Size(84, 13);
            this.lblProductContent.TabIndex = 0;
            this.lblProductContent.Text = "Product Content";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(117, 152);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // txtBarcodeNumber
            // 
            this.txtBarcodeNumber.Location = new System.Drawing.Point(264, 29);
            this.txtBarcodeNumber.Name = "txtBarcodeNumber";
            this.txtBarcodeNumber.Size = new System.Drawing.Size(121, 20);
            this.txtBarcodeNumber.TabIndex = 0;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(264, 108);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(121, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // txtProductContent
            // 
            this.txtProductContent.Location = new System.Drawing.Point(264, 189);
            this.txtProductContent.Name = "txtProductContent";
            this.txtProductContent.Size = new System.Drawing.Size(121, 20);
            this.txtProductContent.TabIndex = 4;
            // 
            // cBoxProducer
            // 
            this.cBoxProducer.FormattingEnabled = true;
            this.cBoxProducer.Location = new System.Drawing.Point(264, 68);
            this.cBoxProducer.Name = "cBoxProducer";
            this.cBoxProducer.Size = new System.Drawing.Size(121, 21);
            this.cBoxProducer.TabIndex = 1;
            // 
            // cBoxCategory
            // 
            this.cBoxCategory.FormattingEnabled = true;
            this.cBoxCategory.Location = new System.Drawing.Point(264, 147);
            this.cBoxCategory.Name = "cBoxCategory";
            this.cBoxCategory.Size = new System.Drawing.Size(121, 21);
            this.cBoxCategory.TabIndex = 3;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 292);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(854, 146);
            this.dataGridViewProducts.TabIndex = 3;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(429, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 72);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pBoxProductPicture
            // 
            this.pBoxProductPicture.Location = new System.Drawing.Point(264, 225);
            this.pBoxProductPicture.Name = "pBoxProductPicture";
            this.pBoxProductPicture.Size = new System.Drawing.Size(121, 30);
            this.pBoxProductPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBoxProductPicture.TabIndex = 6;
            this.pBoxProductPicture.TabStop = false;
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(117, 225);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(40, 13);
            this.lblPicture.TabIndex = 7;
            this.lblPicture.Text = "Picture";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpload.Location = new System.Drawing.Point(433, 232);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(153, 23);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Upload Picture";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(607, 93);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 72);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGotoHome
            // 
            this.btnGotoHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGotoHome.ImageKey = "25694.png";
            this.btnGotoHome.ImageList = this.imageList1;
            this.btnGotoHome.Location = new System.Drawing.Point(791, 12);
            this.btnGotoHome.Name = "btnGotoHome";
            this.btnGotoHome.Size = new System.Drawing.Size(75, 56);
            this.btnGotoHome.TabIndex = 10;
            this.btnGotoHome.UseVisualStyleBackColor = false;
            this.btnGotoHome.Click += new System.EventHandler(this.btnGotoHome_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "25694.png");
            // 
            // txtPictureAddress
            // 
            this.txtPictureAddress.Location = new System.Drawing.Point(264, 266);
            this.txtPictureAddress.Name = "txtPictureAddress";
            this.txtPictureAddress.Size = new System.Drawing.Size(121, 20);
            this.txtPictureAddress.TabIndex = 11;
            // 
            // FrmAddUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.txtPictureAddress);
            this.Controls.Add(this.btnGotoHome);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.lblPicture);
            this.Controls.Add(this.pBoxProductPicture);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.cBoxCategory);
            this.Controls.Add(this.cBoxProducer);
            this.Controls.Add(this.txtProductContent);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtBarcodeNumber);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblProductContent);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.lblBarcodeNumber);
            this.Name = "FrmAddUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Update Product";
            this.Load += new System.EventHandler(this.FrmAddUpdateProduct_Load);
            this.Click += new System.EventHandler(this.FrmAddUpdateProduct_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProductPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarcodeNumber;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductContent;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtBarcodeNumber;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductContent;
        private System.Windows.Forms.ComboBox cBoxProducer;
        private System.Windows.Forms.ComboBox cBoxCategory;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pBoxProductPicture;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGotoHome;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtPictureAddress;
    }
}