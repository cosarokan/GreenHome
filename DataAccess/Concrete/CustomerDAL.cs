using BusinessLayer.Repositories;
using DataAccess.Interfaces;
using DataAccessLayer;
using EntityLayer.Models;
namespace DataAccess.Concrete
{
    public class CustomerDAL : BaseRepository<MyContext, Customer>, ICustomerDAL
    {
        public CustomerDAL()
        {

        }
        public CustomerDAL(MyContext context) : base(context)
        {

        }
    }
}
