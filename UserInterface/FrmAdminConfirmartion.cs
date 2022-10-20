using DataAccess.Services.CategoryService;
using DataAccess.Services.ProducerService;
using DataAccess.Services.UrunService;
using DataAccessLayer;
using DTOs.Category;
using DTOs.Log;
using DTOs.Producer;
using Logs;
using System;
using System.Linq;
using System.Windows.Forms;
namespace UserInterface
{
    public partial class FrmAdminConfirmartion : Form
    {
        public FrmAdminConfirmartion()
        {
            InitializeComponent();
        }
        private int _id;
        CategoryService service = new CategoryService();
        UrunService urunService = new UrunService();
        ProducerService producerService = new ProducerService();
        public FrmAdminConfirmartion(int id): this()
        {
            _id = id;
        }
        MyContext db = new MyContext();
        private void FrmAdminConfirmartion_Load(object sender, EventArgs e)
        {
            lblAdmin.Text = UserContext.UserName;
            GetProductsToGridView();
            GetCategoriesToDataGrid();
            GetProducersToDataGrid();
            ColumnVisibleProcess();
        }
        void GetProductsToGridView()
        {
            dataGridViewProducts.DataSource = urunService.GetProductList();
        }
        void ColumnVisibleProcess()
        {
            // product
            dataGridViewProducts.Columns[0].Visible = false;
            dataGridViewProducts.Columns[3].Visible = false;
            dataGridViewProducts.Columns[5].Visible = false;
            dataGridViewProducts.Columns[6].Visible = false;
            dataGridViewProducts.Columns[7].Visible = false;
            dataGridViewProducts.Columns[8].Visible = false;
            dataGridViewProducts.Columns[9].Visible = false;
            dataGridViewProducts.Columns[14].Visible = false;

            // producer
            dataGridViewProducers.Columns[0].Visible = false;
            dataGridViewProducers.Columns[2].Visible = false;
            dataGridViewProducers.Columns[3].Visible = false;
        }
        private void approveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isApproved = (bool)dataGridViewProducts.SelectedRows[0].Cells["IsApproved"].Value;
            var query = db.Product.FirstOrDefault(x=> x.IsApproved == isApproved);
            query.IsApproved = true;
            query.ApprovedAdminID = UserContext.Id;
            db.SaveChanges();
            MessageBox.Show("Approved");
            GetProductsToGridView();
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            var categoryCountAndTopCategoryControl = service.CategoryNameCount(txtCategoryName.Text, txtTopCategory.Text);
            if (categoryCountAndTopCategoryControl)
            {
                MessageBox.Show("Texts must be valid!");
                return;
            }
            var control = service.ControlCategoryName(txtCategoryName.Text);
            if (control)
            {
                MessageBox.Show("This category name already exists!");
                return;
            }
            try
            {
                bool data = service.AddCategory(new CategoryDTO()
                {
                    CategoryName = txtCategoryName.Text,
                    TopCategoryID = Convert.ToInt32(txtTopCategory.Text),
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });
                JsonLogger<CategoryLogDTO> log = new JsonLogger<CategoryLogDTO>("CategorySuccessLog.txt");
                log.DoLog(new CategoryLogDTO()
                {
                    Category = txtCategoryName.Text,
                    CreatedDate = DateTime.Now,
                    Username = UserContext.UserName
                });
                MessageBox.Show("Category added!");
                Clear();
                GetCategoriesToDataGrid();
            }
            catch (Exception)
            {
                JsonLogger<LogDTO> log = new JsonLogger<LogDTO>("CategoryErrorLog.txt");
                log.DoLog(new LogDTO()
                {
                    Category = txtCategoryName.Text,
                    Customer = UserContext.UserName,
                    Date = DateTime.UtcNow
                });
            }
        }
        private void btnAddProducer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProducer.Text))
            {
                MessageBox.Show("Must not be empty area!");
                return;
            }
            var control = producerService.ControlProducerName(txtProducer.Text);
            if (control)
            {
                MessageBox.Show("This producer name already exists!");
            }
            try
            {
                bool producer = producerService.AddProducer(new ProducerDTO()
                {
                    Name = txtProducer.Text,
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true
                });
                MessageBox.Show("Producer added");
                GetProducersToDataGrid();
                Clear();
            }
            catch (Exception)
            {
                throw;
            }
        }
        void GetCategoriesToDataGrid()
        {
            dataGridViewCategories.DataSource = service.GetCategoryList();
        }
        void GetProducersToDataGrid()
        {
            dataGridViewProducers.DataSource = producerService.GetProducerList();
        }
        private void Clear()
        {
            txtCategoryName.Clear();
            txtTopCategory.Clear();
            txtProducer.Clear();
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isApproved = (bool)dataGridViewProducts.SelectedRows[0].Cells["IsApproved"].Value;
            var query = db.Product.FirstOrDefault(x => x.IsApproved == isApproved);
            query.IsApproved = false;
            query.ApprovedAdminID = UserContext.Id;
            db.SaveChanges();
            MessageBox.Show("Approved");
            GetProductsToGridView();
        }
    }
}
