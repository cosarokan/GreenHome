namespace UserInterface
{
    partial class FrmHome
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
            this.btnReadBarcode = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddProductAndUpdate = new System.Windows.Forms.Button();
            this.btnHistorySearchFavorite = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReadBarcode
            // 
            this.btnReadBarcode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReadBarcode.Location = new System.Drawing.Point(144, 48);
            this.btnReadBarcode.Name = "btnReadBarcode";
            this.btnReadBarcode.Size = new System.Drawing.Size(212, 59);
            this.btnReadBarcode.TabIndex = 0;
            this.btnReadBarcode.Text = "Read Barcode";
            this.btnReadBarcode.UseVisualStyleBackColor = false;
            this.btnReadBarcode.Click += new System.EventHandler(this.btnReadBarcode_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(144, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(212, 59);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddProductAndUpdate
            // 
            this.btnAddProductAndUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProductAndUpdate.Location = new System.Drawing.Point(144, 204);
            this.btnAddProductAndUpdate.Name = "btnAddProductAndUpdate";
            this.btnAddProductAndUpdate.Size = new System.Drawing.Size(212, 59);
            this.btnAddProductAndUpdate.TabIndex = 2;
            this.btnAddProductAndUpdate.Text = "Add / Update Product";
            this.btnAddProductAndUpdate.UseVisualStyleBackColor = false;
            this.btnAddProductAndUpdate.Click += new System.EventHandler(this.btnAddProductAndUpdate_Click);
            // 
            // btnHistorySearchFavorite
            // 
            this.btnHistorySearchFavorite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHistorySearchFavorite.Location = new System.Drawing.Point(144, 282);
            this.btnHistorySearchFavorite.Name = "btnHistorySearchFavorite";
            this.btnHistorySearchFavorite.Size = new System.Drawing.Size(212, 59);
            this.btnHistorySearchFavorite.TabIndex = 3;
            this.btnHistorySearchFavorite.Text = "Search History / Favorite";
            this.btnHistorySearchFavorite.UseVisualStyleBackColor = false;
            this.btnHistorySearchFavorite.Click += new System.EventHandler(this.btnHistorySearchFavorite_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(521, 384);
            this.Controls.Add(this.btnHistorySearchFavorite);
            this.Controls.Add(this.btnAddProductAndUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReadBarcode);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadBarcode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddProductAndUpdate;
        private System.Windows.Forms.Button btnHistorySearchFavorite;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
    }
}