using DataAccess.Services.UrunService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmReadBarcode : Form
    {
        public FrmReadBarcode()
        {
            InitializeComponent();
        }
        UrunService productService = new UrunService();
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dataGridViewProducts.DataSource = productService.GetApprovedProduct();
                return;
            }
            dataGridViewProducts.DataSource = productService.GetProductByBarcodeNumber(txtSearch.Text);
        }
        private void FrmReadBarcode_Load(object sender, EventArgs e)
        {
            GetProductsToGrid();
            ColumnVisibleProcess();
        }
        void GetProductsToGrid()
        {
            dataGridViewProducts.DataSource = productService.GetApprovedProduct();
        }
        void ColumnVisibleProcess()
        {
            dataGridViewProducts.Columns[0].Visible = false;
            dataGridViewProducts.Columns[0].Visible = false;
            dataGridViewProducts.Columns[3].Visible = false;
            dataGridViewProducts.Columns[4].Visible = false;
            dataGridViewProducts.Columns[5].Visible = false;
            dataGridViewProducts.Columns[6].Visible = false;
            dataGridViewProducts.Columns[7].Visible = false;
            dataGridViewProducts.Columns[8].Visible = false;
            dataGridViewProducts.Columns[9].Visible = false;
            dataGridViewProducts.Columns[10].Visible = false;
            dataGridViewProducts.Columns[13].Visible = false;
            dataGridViewProducts.Columns[14].Visible = false;
        }
    }
}
