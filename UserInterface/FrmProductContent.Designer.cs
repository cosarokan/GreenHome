namespace UserInterface
{
    partial class FrmProductContent
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
            this.dataGridViewProductEvaluations = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductEvaluations)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProductEvaluations
            // 
            this.dataGridViewProductEvaluations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductEvaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductEvaluations.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewProductEvaluations.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProductEvaluations.Name = "dataGridViewProductEvaluations";
            this.dataGridViewProductEvaluations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductEvaluations.Size = new System.Drawing.Size(490, 380);
            this.dataGridViewProductEvaluations.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // removedToolStripMenuItem
            // 
            this.removedToolStripMenuItem.Name = "removedToolStripMenuItem";
            this.removedToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.removedToolStripMenuItem.Text = "Removed";
            this.removedToolStripMenuItem.Click += new System.EventHandler(this.removedToolStripMenuItem_Click);
            // 
            // FrmProductContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 404);
            this.Controls.Add(this.dataGridViewProductEvaluations);
            this.Name = "FrmProductContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Content";
            this.Load += new System.EventHandler(this.FrmProductContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductEvaluations)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductEvaluations;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removedToolStripMenuItem;
    }
}