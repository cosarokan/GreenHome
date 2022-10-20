using BusinessLayer.Repositories;
using DataAccess.Interfaces;
using DataAccessLayer;
using EntityLayer.Models;
namespace DataAccess.Concrete
{
    public class EvaluationDAL : BaseRepository<MyContext, Evaluation>, IEvaluationDAL
    {
        public EvaluationDAL()
        {

        }
        public EvaluationDAL(MyContext context) : base(context)
        {

        }
    }
}
