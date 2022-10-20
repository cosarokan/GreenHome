using DTOs.ProductEvaluation;
using EntityLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace Mapping
{
    public class ProductEvaluationMapping
    {
        public ProductEvaluation ProductEvaluationDTOTOProductEvaluation(ProductEvaluationDTO dto)
        {
            return new ProductEvaluation()
            {
                ID = dto.ID,
                ProductID = dto.ProductID,
                CustomerID = dto.CustomerID,
                EvaluationID = dto.EvaluationID,
                CreatedDate = dto.CreatedDate,
                IsActive = dto.IsActive,
            };
        }
        public List<ProductEvaluationDTO> ProductEvaluationListToProductEvaluationListDTOList(List<ProductEvaluation> productEvaluationList)
        {
            return productEvaluationList.Select(x => new ProductEvaluationDTO
            {
                ID = x.ID,
                CustomerID=x.CustomerID,
                EvaluationID = x.EvaluationID,
                ProductID = x.ProductID,
                Customer = x.Customer.Username,
                Evaluation = x.Evaluation.ContentEvaluation,
                Product = x.Product.Name,
                IsActive = x.IsActive
            }).ToList();
        }
    }
}
