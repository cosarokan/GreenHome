namespace UserInterface
{
    partial class FrmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearch));
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.txtSearxcProduct = new System.Windows.Forms.TextBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.btnGoToProduct = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnGotoHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Location = new System.Drawing.Point(258, 79);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(81, 13);
            this.lblSearchProduct.TabIndex = 0;
            this.lblSearchProduct.Text = "Search Product";
            // 
            // txtSearxcProduct
            // 
            this.txtSearxcProduct.Location = new System.Drawing.Point(128, 110);
            this.txtSearxcProduct.Name = "txtSearxcProduct";
            this.txtSearxcProduct.Size = new System.Drawing.Size(351, 20);
            this.txtSearxcProduct.TabIndex = 1;
            this.txtSearxcProduct.TextChanged += new System.EventHandler(this.txtSearxcProduct_TextChanged);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 251);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(582, 158);
            this.dataGridViewProducts.TabIndex = 3;
            // 
            // btnGoToProduct
            // 
            this.btnGoToProduct.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGoToProduct.Location = new System.Drawing.Point(185, 177);
            this.btnGoToProduct.Name = "btnGoToProduct";
            this.btnGoToProduct.Size = new System.Drawing.Size(216, 34);
            this.btnGoToProduct.TabIndex = 14;
            this.btnGoToProduct.Text = "Go To Product";
            this.btnGoToProduct.UseVisualStyleBackColor = false;
            this.btnGoToProduct.Click += new System.EventHandler(this.btnGoToProduct_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "25694.png");
            // 
            // btnGotoHome
            // 
            this.btnGotoHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGotoHome.ImageKey = "25694.png";
            this.btnGotoHome.ImageList = this.imageList1;
            this.btnGotoHome.Location = new System.Drawing.Point(528, 12);
            this.btnGotoHome.Name = "btnGotoHome";
            this.btnGotoHome.Size = new System.Drawing.Size(66, 61);
            this.btnGotoHome.TabIndex = 15;
            this.btnGotoHome.UseVisualStyleBackColor = false;
            this.btnGotoHome.Click += new System.EventHandler(this.btnGotoHome_Click);
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(606, 421);
            this.Controls.Add(this.btnGotoHome);
            this.Controls.Add(this.btnGoToProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.txtSearxcProduct);
            this.Controls.Add(this.lblSearchProduct);
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.TextBox txtSearxcProduct;
        private System.Windows.Forms.Button btnGoToProduct;
        public System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnGotoHome;
    }
}