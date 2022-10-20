using BusinessLayer.Repositories;
using DataAccess.Interfaces;
using DataAccessLayer;
using EntityLayer.Models;
namespace DataAccess.Concrete
{
    public class ProducerDAL : BaseRepository<MyContext, Producer>, IProducerDAL
    {
        public ProducerDAL()
        {

        }
        public ProducerDAL(MyContext context) : base(context)
        {
                
        }
    }
}
