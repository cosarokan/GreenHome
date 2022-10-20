using BusinessLayer.Repositories;
using DataAccess.Interfaces;
using DataAccessLayer;
using EntityLayer.Models;
namespace DataAccess.Concrete
{
    public class ProductEvaluationDAL : BaseRepository<MyContext, ProductEvaluation>, IProductEvaluationDAL
    {
        public ProductEvaluationDAL()
        {

        }
        public ProductEvaluationDAL(MyContext context) : base(context)  
        {

        }
    }
}
