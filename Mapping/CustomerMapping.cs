
using EntityLayer.Models;
using System;

namespace Mapping
{
    public class CustomerMapping
    {
        public Customer CustomerLoginDTOTOCustomer(string username, string password)
        {
            return new Customer()
            {
                Username = username,
                Password = password,
                CreatedDate = DateTime.Now,
                IsActive = true
            };
        }
    }
}
