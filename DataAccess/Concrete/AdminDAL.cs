using BusinessLayer.Repositories;
using DataAccess.Interfaces;
using DataAccessLayer;
using EntityLayer.Models;
namespace DataAccess.Concrete
{
    public class AdminDAL : BaseRepository<MyContext, Admin>, IAdminDAL
    {
        public AdminDAL()
        {

        }
        public AdminDAL(MyContext context) : base(context)
        {

        }
    }
}
