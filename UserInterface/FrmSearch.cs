using DataAccess.Services.UrunService;
using DTOs.Log;
using EntityLayer.Models;
using Logs;
using System;
using System.Windows.Forms;
namespace UserInterface
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
        }
        UrunService urunService = new UrunService();

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            GetProductsToGridView();
            ColumnVisibleProcess();
        }
        void GetProductsToGridView()
        {
            dataGridViewProducts.DataSource = urunService.GetApprovedProduct();
        }
        private void btnGoToProduct_Click(object sender, EventArgs e)
        {
            FrmProduct frmProduct = new FrmProduct(GetProduct());
            frmProduct.Show();

            JsonLogger<FavoriteLogDTO> myLog = new JsonLogger<FavoriteLogDTO>($"{UserContext.UserName}.txt");
            myLog.DoLog(new FavoriteLogDTO()
            {
                ProductName = dataGridViewProducts.SelectedRows[0].Cells[2].Value.ToString(),
                Date = DateTime.Now
            });
        }
        void ColumnVisibleProcess()
        {
            dataGridViewProducts.Columns[0].Visible = false;
            dataGridViewProducts.Columns[1].Visible = false;
            dataGridViewProducts.Columns[3].Visible = false;
            dataGridViewProducts.Columns[5].Visible = false;
            dataGridViewProducts.Columns[6].Visible = false;
            dataGridViewProducts.Columns[7].Visible = false;
            dataGridViewProducts.Columns[8].Visible = false;
            dataGridViewProducts.Columns[9].Visible = false;
            dataGridViewProducts.Columns[10].Visible = false;
            dataGridViewProducts.Columns[13].Visible = false;
            dataGridViewProducts.Columns[14].Visible = false;
        }
        private Product GetProduct()
        {
            Product p = new Product();
            p.ID = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[0].Value);
            p.BarcodeNumber = dataGridViewProducts.CurrentRow.Cells[1].Value.ToString();
            p.Name = dataGridViewProducts.CurrentRow.Cells[2].Value.ToString();
            p.Content = dataGridViewProducts.CurrentRow.Cells[4].Value.ToString();
            p.CustomerID = Convert.ToInt32(dataGridViewProducts.CurrentRow.Cells[6].Value);

            p.Producer = new Producer();
            p.Producer.Name = dataGridViewProducts.CurrentRow.Cells[12].Value.ToString();

            p.Customer = new Customer();
            p.Customer.Username = dataGridViewProducts.CurrentRow.Cells[13].Value.ToString();

            p.Picture = dataGridViewProducts.CurrentRow.Cells[3].Value.ToString();

            return p;
        }
        private void txtSearxcProduct_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearxcProduct.Text))
            {
                dataGridViewProducts.DataSource = urunService.GetApprovedProduct();
                return;
            }
            dataGridViewProducts.DataSource = urunService.SearchResult(txtSearxcProduct.Text);
        }
        private void btnGotoHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
