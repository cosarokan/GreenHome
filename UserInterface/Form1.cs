using DataAccess.Services.AdminService;
using DataAccess.Services.CustomerService;
using DTOs.Log;
using Logs;
using System;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AdminService adminService = new AdminService();
        CustomerService customerService = new CustomerService();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Must not be empty area!");
                    return;
                }
                var login = customerService.Login(txtUsername.Text, txtPassword.Text);
                if (login.Username != txtUsername.Text || login.Password != txtPassword.Text)
                {
                    MessageBox.Show("Username or password is incorrect");
                    return;
                }
                UserContext.Id = login.ID;
                UserContext.UserName = login.Username;
                UserContext.CratedDate = login.CreatedDate;

                FrmHome frmHome = new FrmHome(login.ID);
                frmHome.Show();
                MessageBox.Show($"Welcome {login.Username}");
                ClearCustomerTextBoxes();
                SuccessLogged(login.Username);

            }
            catch (Exception)
            {
                throw;
            }
        }
        void SuccessLogged(string username)
        {
            JsonLogger<CustomerLogDTO> log = new JsonLogger<CustomerLogDTO>("CustomerLoggedInSystem.txt");
            log.Login(new CustomerLogDTO()
            {
                Username = username,
                LoginDate = DateTime.UtcNow,
            });
        }
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (txtAdminUsername.Text == "" || txtAdminUsername.Text == "")
            {
                MessageBox.Show("Must not be empty area!");
            }
            var login = adminService.Login(txtAdminUsername.Text, txtAdminPassword.Text);

            if (login.Username != txtAdminUsername.Text || login.Password != txtAdminPassword.Text)
            {
                MessageBox.Show("Username or password is incorrect");
                return;
            }

            UserContext.Id = login.ID;
            UserContext.UserName = login.Username;
            FrmAdminConfirmartion frmAdminConfirmartion = new FrmAdminConfirmartion(login.ID);
            frmAdminConfirmartion.Show();
            MessageBox.Show($"Welcome admin {login.Username}");
            ClearAdminTextBoxes();
        }
        void ClearCustomerTextBoxes()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
        void ClearAdminTextBoxes()
        {
            txtAdminUsername.Clear();
            txtAdminPassword.Clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
        }
    }
}
