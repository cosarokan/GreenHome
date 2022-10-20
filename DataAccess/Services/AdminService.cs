using DataAccess.Concrete;
using DTOs.Admin;
using System.Linq;

namespace DataAccess.Services.AdminService
{
    public class AdminService
    {
        public AdminLoginDTO Login(string username, string password)
        {
            AdminDAL dal = new AdminDAL();
            return dal.GetAll(x => x.Username == username && x.Password == password).Select(x => new AdminLoginDTO()
            {
                ID = x.ID,
                Username = x.Username,
                Password = x.Password
            }).FirstOrDefault();
        }
    }
}