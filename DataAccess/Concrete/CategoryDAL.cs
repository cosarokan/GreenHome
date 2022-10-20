using BusinessLayer.Repositories;
using DataAccess.Interfaces;
using DataAccessLayer;
using EntityLayer.Models;
namespace DataAccess.Concrete
{
    public class CategoryDAL : BaseRepository<MyContext, Category>, ICategoryDAL
    {
        public CategoryDAL()
        {

        }
        public CategoryDAL(MyContext context) : base(context)
        {

        }
    }
}
