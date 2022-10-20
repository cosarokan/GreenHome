using System;
namespace DTOs.Evaluation
{
    public class EvaluationDTO
    {
        public int ID { get; set; }
        public string ContentEvaluation { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
