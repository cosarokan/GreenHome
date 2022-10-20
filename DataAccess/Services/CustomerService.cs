using DataAccess.Concrete;
using DTOs.Customer;
using Mapping;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DataAccess.Services.CustomerService
{
    public class CustomerService
    {
        private readonly CustomerDAL _dal;
        public CustomerService()
        {
            _dal = new CustomerDAL();
        }
        public CustomerLoginDTO Login(string username, string password)
        {
            try
            {
                return _dal.GetAll(x => x.Username == username && x.Password == password).Select(x => new CustomerLoginDTO()
                {
                    ID = x.ID,
                    Username = x.Username,
                    Password = x.Password,
                    CreatedDate = x.CreatedDate
                }).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }

        }
        public bool ChangePassword(CustomerLoginDTO dto)
        {
            var customer = _dal.GetAll().Where(x => x.ID == dto.ID).FirstOrDefault();
            if (customer != null)
            {
                customer.Password = dto.Password;
            }
            _dal.Update(customer);
            return true;
        }
        
        
        // tekrar bak
        public bool AddCustomer(string username, string password)
        {
            //MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //byte[] dizi = Encoding.UTF8.GetBytes(password);
            //dizi = md5.ComputeHash(dizi);
            //StringBuilder sb = new StringBuilder();
            //foreach (byte ba in dizi)
            //{
            //    sb.Append(ba.ToString("x2").ToLower());
            //}
            _dal.Add(new CustomerMapping().CustomerLoginDTOTOCustomer(username, password));
            _dal.MySaveChanges();
            return true;
        }
    }
}
