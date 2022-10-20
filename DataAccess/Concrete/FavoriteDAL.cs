using BusinessLayer.Repositories;
using DataAccess.Interfaces;
using DataAccessLayer;
using EntityLayer.Models;
namespace DataAccess.Concrete
{
    internal class FavoriteDAL : BaseRepository<MyContext, Favorite>, IFavoriteDAL
    {
        public FavoriteDAL()
        {

        }
        public FavoriteDAL(MyContext context) : base(context)
        {

        }
    }
}
