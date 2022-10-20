using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmHome : Form
    {
        private int _id;

        public FrmHome()
        {
            InitializeComponent();
        }
        public FrmHome(int id) : this()
        {
            _id = id;
        }
        private void btnReadBarcode_Click(object sender, System.EventArgs e)
        {
            FrmReadBarcode frmReadBarcode = new FrmReadBarcode();
            frmReadBarcode.Show();
        }
        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            FrmSearch frmSearch = new FrmSearch();
            frmSearch.Show();
        }
        private void btnAddProductAndUpdate_Click(object sender, System.EventArgs e)
        {
            FrmAddUpdateProduct frmAddUpdateProduct = new FrmAddUpdateProduct(UserContext.Id);
            frmAddUpdateProduct.Show();
        }
        private void btnHistorySearchFavorite_Click(object sender, System.EventArgs e)
        {
            FrmSearchHistoryFavorite frmSearchHistoryFavorite = new FrmSearchHistoryFavorite();
            frmSearchHistoryFavorite.Show();
        }
        private void logoutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void profileToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FrmProfile frmProfile = new FrmProfile();
            frmProfile.Show();
        }
    }
}
