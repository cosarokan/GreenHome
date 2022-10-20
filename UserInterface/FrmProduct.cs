using DataAccess.Services;
using DataAccess.Services.FavoriteService;
using DTOs.Favorite;
using DTOs.ProductEvaluation;
using EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmProduct : Form
    {
        private Product _product;
        FavoriteService favoriteService = new FavoriteService();
        EvaluationService evaluationService = new EvaluationService();
        ProductEvaluationService productEvaluationService = new ProductEvaluationService();
        List<string> contentList = new List<string>();
        public FrmProduct()
        {
            InitializeComponent();
        }
        public FrmProduct(Product product) : this()
        {
            _product = product;
        }
        private void FrmProduct_Load(object sender, EventArgs e)
        {
            SetProductName();
            CreateContent();
            CreateListView();
            GetEvaluationToCombo();
        }
        private void btnAddtoFavorite_Click(object sender, EventArgs e)
        {
            var control = favoriteService.ControlFavorite(_product.ID, UserContext.Id);
            if (control == true)
            {
                MessageBox.Show("This product is already in the favorite list!");
                return;
            }
            try
            {
                bool data = favoriteService.AddFavorite(new FavoriteDTO()
                {
                    CustomerID = UserContext.Id,
                    ProductID = _product.ID,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                });
                MessageBox.Show("Added to favorite list");
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void btnToEvaluate_Click(object sender, EventArgs e)
        {
            try
            {
                bool data = productEvaluationService.AddProductEvaluation(new ProductEvaluationDTO()
                {
                    ProductID = _product.ID,
                    EvaluationID = cBoxEvaluations.SelectedIndex,
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    CustomerID = UserContext.Id
                });
                MessageBox.Show("Added");
                Clear();
            }
            catch (Exception)
            {

                throw;
            }
        }
        void GetEvaluationToCombo()
        {
            cBoxEvaluations.DataSource = evaluationService.GetEvaluationList();
            cBoxEvaluations.DisplayMember = "ContentEvaluation";
            cBoxEvaluations.ValueMember = "ID";
        }
        void CreateListView()
        {
            int row = 1;
            foreach (var item in contentList)
            {
                ListViewItem li = new ListViewItem();
                li.Text = (row++).ToString();
                li.SubItems.Add(item);
                listView1.Items.Add(li);
            }
        }
        void SetProductName()
        {
            lblProductName.Text = _product.Name;
            lblProducerName.Text = _product.Producer.Name;
            lblCustomer.Text = _product.Customer.Username;
            pictureBox1.ImageLocation = _product.Picture;
        }
        void CreateContent()
        {
            var data = _product.Content.Split(',');

            foreach (var item in data)
            {
                contentList.Add(item);
            }
        }
        void Clear()
        {
            cBoxEvaluations.SelectedIndex = -1;
        }
        private void lblProducerName_Click(object sender, EventArgs e)
        {
            FrmProducerProducts frmProducerProducts = new FrmProducerProducts(_product.Producer
                .Name);
            frmProducerProducts.Show();
        }
    }
}
