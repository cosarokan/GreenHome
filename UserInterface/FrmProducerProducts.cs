using DataAccess.Services.UrunService;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmProducerProducts : Form
    {
        public FrmProducerProducts()
        {
            InitializeComponent();
        }
        string _name;
        UrunService productService = new UrunService();
        public FrmProducerProducts(string name) : this()
        {
            _name = name;
        }
        private void FrmProducerProducts_Load(object sender, EventArgs e)
        {
            listBoxProducts.DataSource = productService.GetByProducerName(_name);
        }
    }
}
