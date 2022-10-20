namespace UserInterface
{
    partial class FrmAdminConfirmartion
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.approveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblTopCategory = new System.Windows.Forms.Label();
            this.txtTopCategory = new System.Windows.Forms.TextBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.tabPageProducer = new System.Windows.Forms.TabPage();
            this.btnAddProducer = new System.Windows.Forms.Button();
            this.dataGridViewProducers = new System.Windows.Forms.DataGridView();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageProducts.SuspendLayout();
            this.tabPageCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.tabPageProducer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewProducts.Location = new System.Drawing.Point(3, 26);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(745, 354);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.approveToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // approveToolStripMenuItem
            // 
            this.approveToolStripMenuItem.Name = "approveToolStripMenuItem";
            this.approveToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.approveToolStripMenuItem.Text = "Approve";
            this.approveToolStripMenuItem.Click += new System.EventHandler(this.approveToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageProducts);
            this.tabControl1.Controls.Add(this.tabPageCategory);
            this.tabControl1.Controls.Add(this.tabPageProducer);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 409);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.lblAdmin);
            this.tabPageProducts.Controls.Add(this.dataGridViewProducts);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 22);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(751, 383);
            this.tabPageProducts.TabIndex = 0;
            this.tabPageProducts.Text = "Products";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.dataGridViewCategories);
            this.tabPageCategory.Controls.Add(this.btnAddCategory);
            this.tabPageCategory.Controls.Add(this.lblCategoryName);
            this.tabPageCategory.Controls.Add(this.lblTopCategory);
            this.tabPageCategory.Controls.Add(this.txtTopCategory);
            this.tabPageCategory.Controls.Add(this.txtCategoryName);
            this.tabPageCategory.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategory.Size = new System.Drawing.Size(751, 383);
            this.tabPageCategory.TabIndex = 1;
            this.tabPageCategory.Text = "Category";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCategories.Location = new System.Drawing.Point(3, 230);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategories.Size = new System.Drawing.Size(745, 150);
            this.dataGridViewCategories.TabIndex = 3;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCategory.Location = new System.Drawing.Point(228, 156);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(291, 49);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(223, 39);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(80, 13);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Category Name";
            // 
            // lblTopCategory
            // 
            this.lblTopCategory.AutoSize = true;
            this.lblTopCategory.Location = new System.Drawing.Point(223, 103);
            this.lblTopCategory.Name = "lblTopCategory";
            this.lblTopCategory.Size = new System.Drawing.Size(71, 13);
            this.lblTopCategory.TabIndex = 1;
            this.lblTopCategory.Text = "Top Category";
            // 
            // txtTopCategory
            // 
            this.txtTopCategory.Location = new System.Drawing.Point(319, 103);
            this.txtTopCategory.Name = "txtTopCategory";
            this.txtTopCategory.Size = new System.Drawing.Size(200, 20);
            this.txtTopCategory.TabIndex = 0;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(319, 39);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(200, 20);
            this.txtCategoryName.TabIndex = 0;
            // 
            // tabPageProducer
            // 
            this.tabPageProducer.Controls.Add(this.btnAddProducer);
            this.tabPageProducer.Controls.Add(this.dataGridViewProducers);
            this.tabPageProducer.Controls.Add(this.txtProducer);
            this.tabPageProducer.Controls.Add(this.lblProducer);
            this.tabPageProducer.Location = new System.Drawing.Point(4, 22);
            this.tabPageProducer.Name = "tabPageProducer";
            this.tabPageProducer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducer.Size = new System.Drawing.Size(751, 383);
            this.tabPageProducer.TabIndex = 2;
            this.tabPageProducer.Text = "Producer";
            this.tabPageProducer.UseVisualStyleBackColor = true;
            // 
            // btnAddProducer
            // 
            this.btnAddProducer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProducer.Location = new System.Drawing.Point(502, 96);
            this.btnAddProducer.Name = "btnAddProducer";
            this.btnAddProducer.Size = new System.Drawing.Size(149, 20);
            this.btnAddProducer.TabIndex = 3;
            this.btnAddProducer.Text = "Add";
            this.btnAddProducer.UseVisualStyleBackColor = false;
            this.btnAddProducer.Click += new System.EventHandler(this.btnAddProducer_Click);
            // 
            // dataGridViewProducers
            // 
            this.dataGridViewProducers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducers.Location = new System.Drawing.Point(8, 183);
            this.dataGridViewProducers.Name = "dataGridViewProducers";
            this.dataGridViewProducers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducers.Size = new System.Drawing.Size(735, 192);
            this.dataGridViewProducers.TabIndex = 2;
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(207, 96);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(251, 20);
            this.txtProducer.TabIndex = 1;
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(108, 99);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(50, 13);
            this.lblProducer.TabIndex = 0;
            this.lblProducer.Text = "Producer";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(695, 3);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(36, 13);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Admin";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // FrmAdminConfirmartion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(759, 409);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmAdminConfirmartion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Confirmartion";
            this.Load += new System.EventHandler(this.FrmAdminConfirmartion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageProducts.ResumeLayout(false);
            this.tabPageProducts.PerformLayout();
            this.tabPageCategory.ResumeLayout(false);
            this.tabPageCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.tabPageProducer.ResumeLayout(false);
            this.tabPageProducer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem approveToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageProducts;
        private System.Windows.Forms.TabPage tabPageCategory;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.Label lblTopCategory;
        private System.Windows.Forms.TextBox txtTopCategory;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TabPage tabPageProducer;
        private System.Windows.Forms.DataGridView dataGridViewProducers;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Button btnAddProducer;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}