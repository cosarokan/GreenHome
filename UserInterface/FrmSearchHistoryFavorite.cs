using DataAccess.Services.FavoriteService;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmSearchHistoryFavorite : Form
    {
        public FrmSearchHistoryFavorite()
        {
            InitializeComponent();
        }
        FavoriteService favoriteService = new FavoriteService();
        private void FrmSearchHistoryFavorite_Load(object sender, EventArgs e)
        {
            GetFavoritesToGridView();
            ColumnVisibleProcess();
            GetProductToListBox();
        }
        void GetFavoritesToGridView()
        {
            dataGridViewFavorites.DataSource = favoriteService.GetFavoritesList().Where(x => x.CustomerID == UserContext.Id && x.IsActive == true).ToList();
        }
        void ColumnVisibleProcess()
        {
            dataGridViewFavorites.Columns[0].Visible = false;
            dataGridViewFavorites.Columns[1].Visible = false;
            dataGridViewFavorites.Columns[2].Visible = false;
            dataGridViewFavorites.Columns[3].Visible = false;
            dataGridViewFavorites.Columns[4].Visible = false;
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRow = (int)dataGridViewFavorites.SelectedRows[0].Cells["ID"].Value;
            favoriteService.DeleteFavorite(selectedRow);
            MessageBox.Show("Removed");
            GetFavoritesToGridView();
        }
        void GetProductToListBox()
        {
            try
            {
                listBox1.Items.Clear();
                StreamReader sr = new StreamReader($@"C:\MyLogs\{UserContext.UserName}.txt");
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
                sr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No search history!");
            }

        }
    }
}
