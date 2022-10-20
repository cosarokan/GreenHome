using DataAccess.Services.CustomerService;
using DTOs.Customer;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmNewPassword : Form
    {
        public FrmNewPassword()
        {
            InitializeComponent();
        }
        CustomerService customerService = new CustomerService();
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerLoginDTO dto = new CustomerLoginDTO();
                dto.ID = UserContext.Id;
                dto.Password = txtNewPassword.Text;
                bool update = customerService.ChangePassword(dto);
                MessageBox.Show("Changed your password");
                Clear();
                this.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void Clear()
        {
            txtNewPassword.Clear();
        }
    }
}
