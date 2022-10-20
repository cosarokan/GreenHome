using System;
namespace DTOs.ProductEvaluation
{
    public class ProductEvaluationDTO
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int EvaluationID { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public string Product { get; set; }
        public string Customer { get; set; }
        public string Evaluation { get; set; }
    }
}
