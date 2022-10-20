using System;

namespace DTOs.Customer
{
    public class CustomerLoginDTO
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
