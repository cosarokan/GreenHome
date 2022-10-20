using DataAccess.Services.UrunService;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmProfile : Form
    {
        public FrmProfile()
        {
            InitializeComponent();
        }
        UrunService _urunService = new UrunService();

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmProfile_Load(object sender, EventArgs e)
        {
            
            lblUser.Text = UserContext.UserName;
            lblDate.Text = UserContext.CratedDate.ToString("dd.MM.yyyy");
            lblProductCount.Text = _urunService.GetCountByCustomerId(UserContext.Id).ToString();

        }
        private void btnFavorites_Click(object sender, EventArgs e)
        {
            FrmSearchHistoryFavorite frmSearchHistoryFavorite = new FrmSearchHistoryFavorite();
            frmSearchHistoryFavorite.Show();
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FrmNewPassword frmNewPassword = new FrmNewPassword();
            frmNewPassword.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMyList_Click(object sender, EventArgs e)
        {
            FrmProductContent frmProductContent = new FrmProductContent();
            frmProductContent.Show();
        }

        private void btnBlackList_Click(object sender, EventArgs e)
        {
            FrmBlackList frmBlackList = new FrmBlackList();
            frmBlackList.Show();
        }
    }
}
