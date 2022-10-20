using DataAccess.Services.CategoryService;
using DataAccess.Services.ProducerService;
using DataAccess.Services.UrunService;
using DTOs.Product;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmAddUpdateProduct : Form
    {
        private int _id;
        UrunService productService = new UrunService();
        CategoryService categoryService = new CategoryService();
        ProducerService producerService = new ProducerService();
        public FrmAddUpdateProduct()
        {
            InitializeComponent();
        }
        public FrmAddUpdateProduct(int id) : this()
        {
            _id = id;
        }
        private void FrmAddUpdateProduct_Load(object sender, EventArgs e)
        {
            GetProductsToGridView();
            ColumnVisibleProcess();
            GetCategories();
            GetProducers();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var controlTexts = productService.ControlTexts(txtProductName.Text, txtProductContent.Text, txtPictureAddress.Text);
            if (controlTexts == true)
            {
                MessageBox.Show("Must not be empty area!");
                return;
            }
            var control = productService.ControlProduct(txtProductName.Text);
            if (control == true)
            {
                MessageBox.Show("This product already exists!");
                Clear();
                return;
            }
            try
            {
                bool data = productService.AddProduct(new ProductDTO()
                {
                    BarcodeNumber = CreateBarcodeNumber(),
                    ProductName = txtProductName.Text,
                    Picture = txtPictureAddress.Text, // fotoğraf hallet
                    CategoryID = Convert.ToInt32(cBoxCategory.SelectedValue),
                    ProducerID = Convert.ToInt32(cBoxProducer.SelectedValue),
                    IsApproved = false,
                    CustomerID = _id,
                    CreatedDate = DateTime.Now,
                    Content = txtProductContent.Text,
                });
                MessageBox.Show("Product added but admin must approve!");
                Clear();
                GetProductsToGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var controlTexts = productService.ControlTexts(txtProductName.Text, txtProductContent.Text, txtPictureAddress.Text);
            if (controlTexts == true)
            {
                MessageBox.Show("Must not be empty area!");
                return;
            }
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                try
                {
                    ProductDTO product = (ProductDTO)dataGridViewProducts.CurrentRow.DataBoundItem;
                    product.ProductName = txtProductName.Text;
                    product.Content = txtProductContent.Text;
                    product.IsApproved = false;
                    bool update = productService.UpdateProduct(product);
                    MessageBox.Show("Product updated but admin must approve!");
                    GetProductsToGridView();
                    Clear();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Select the product!");
            }
        }
        void GetCategories()
        {
            cBoxCategory.DataSource = categoryService.GetCategoryList();
            cBoxCategory.ValueMember = "ID";
            cBoxCategory.DisplayMember = "Name";
        }   
        void GetProducers()
        {
            cBoxProducer.DataSource = producerService.GetProducerList();
            cBoxProducer.ValueMember = "ID";
            cBoxProducer.DisplayMember = "Name";

        }
        void Clear()
        {
            txtBarcodeNumber.Clear();
            txtProductContent.Clear();
            txtProductName.Clear();
            cBoxCategory.SelectedIndex = -1;
            cBoxProducer.SelectedIndex = -1;
            txtPictureAddress.Clear();
        }
        void GetProductsToGridView()
        {
            dataGridViewProducts.DataSource = productService.GetApprovedProduct();
        }
        void ColumnVisibleProcess()
        {
            dataGridViewProducts.Columns[0].Visible = false;
            dataGridViewProducts.Columns[3].Visible = false;
            dataGridViewProducts.Columns[5].Visible = false;
            dataGridViewProducts.Columns[6].Visible = false;
            dataGridViewProducts.Columns[7].Visible = false;
            dataGridViewProducts.Columns[8].Visible = false;
            dataGridViewProducts.Columns[9].Visible = false;
            dataGridViewProducts.Columns[14].Visible = false;
            txtBarcodeNumber.Enabled = false;
        }
        string CreateBarcodeNumber()
        {
            string createdRandomNumber = "";
            Random random = new Random();
            for (int i = 0; i < 11; i++)
            {
                createdRandomNumber += random.Next(0, 10);
            }
            return createdRandomNumber;
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            string image = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    image = dialog.FileName;
                    txtPictureAddress.Text = image;
                    pBoxProductPicture.ImageLocation = image;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductName.Text = dataGridViewProducts.SelectedRows[0].Cells["ProductName"].Value.ToString();
            cBoxCategory.Text = dataGridViewProducts.SelectedRows[0].Cells[11].Value.ToString();
            cBoxProducer.Text = dataGridViewProducts.SelectedRows[0].Cells[12].Value.ToString();
            txtProductContent.Text = dataGridViewProducts.SelectedRows[0].Cells[4].Value.ToString();
            txtBarcodeNumber.Text = dataGridViewProducts.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void FrmAddUpdateProduct_Click(object sender, EventArgs e)
        {
            txtBarcodeNumber.Clear();
            txtProductContent.Clear();
            txtProductName.Clear();
            cBoxCategory.SelectedIndex = -1;
            cBoxProducer.SelectedIndex = -1;
        }
        private void btnGotoHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
