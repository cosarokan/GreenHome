using DataAccess.Concrete;
using DataAccessLayer;
using DTOs.ProductEvaluation;
using EntityLayer.Models;
using Mapping;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Services
{
    public class ProductEvaluationService
    {
        ProductEvaluationDAL dal = new ProductEvaluationDAL();
        MyContext context = new MyContext();
        public bool AddProductEvaluation(ProductEvaluationDTO dto)
        {
            dal.Add(new ProductEvaluationMapping().ProductEvaluationDTOTOProductEvaluation(dto));
            dal.MySaveChanges();
            return true;
        }
        public List<ProductEvaluationDTO> GetProductEvaluationList(int customerId)
        {
            List<ProductEvaluation> liste = dal.GetAll().Where(x => x.CustomerID == customerId).ToList();
            return new ProductEvaluationMapping().ProductEvaluationListToProductEvaluationListDTOList(liste);
        }
        public bool DeleteTheEvaluation(ProductEvaluationDTO dto)
        {
            var query = dal.GetAll().Where(x => x.ID == dto.ID).FirstOrDefault();
            if (query != null)
            {
                query.ID = dto.ID;
                query.EvaluationID = dto.EvaluationID;
                query.CustomerID = dto.CustomerID;
                query.ProductID = dto.ProductID;
                query.CreatedDate = dto.CreatedDate;
                query.IsActive = dto.IsActive;
            }
            dal.Delete(query);
            return true;
        }
        public List<ProductEvaluationDTO> GetActiveEvaluation(int userId)
        {
            List<ProductEvaluation> liste = dal.GetAll().Where(x => x.CustomerID == userId && x.IsActive == true).ToList();
            return new ProductEvaluationMapping().ProductEvaluationListToProductEvaluationListDTOList(liste);
        }
        public bool DeleteEvaluation(int id)
        {
            var evaluation = context.ProductEvaluation.FirstOrDefault(x => x.ID == id);
            context.ProductEvaluation.Remove(evaluation);
            context.SaveChanges();
            return true;
        }
    }
}
