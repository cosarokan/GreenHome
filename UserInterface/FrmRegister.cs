using DataAccess.Services.CustomerService;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }
        CustomerService customerService = new CustomerService();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                customerService.AddCustomer(txtUsername.Text, txtPassword.Text);
                MessageBox.Show("Customer added!");
                Clear();
            }
            catch (Exception)
            {
                throw;
            }
        }
        void Clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
