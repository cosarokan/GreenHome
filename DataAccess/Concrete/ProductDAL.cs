using BusinessLayer.Repositories;
using DataAccess.Interfaces;
using DataAccessLayer;
using EntityLayer.Models;
namespace DataAccess.Concrete
{
    public class ProductDAL : BaseRepository<MyContext, Product>, IProductDAL
    {
        public ProductDAL()
        {

        }
        public ProductDAL(MyContext context) : base(context)
        {

        }
    }
}
