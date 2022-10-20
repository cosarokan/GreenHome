using DTOs.Evaluation;
using EntityLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace Mapping
{
    public class EvaluationMapping
    {
        public Evaluation EvaluationDTOTOEvaluation(EvaluationDTO dto)
        {
            return new Evaluation()
            {
                ID = dto.ID,
                ContentEvaluation = dto.ContentEvaluation,
                IsActive = dto.IsActive,
                CreatedDate = dto.CreatedDate
            };
        }
        public List<EvaluationDTO> EvaluationListToEvaluationListDTOList(List<Evaluation> evaluationList)
        {
            return evaluationList.Select(x => new EvaluationDTO
            {
                ID = x.ID,
                ContentEvaluation = x.ContentEvaluation,
                IsActive = x.IsActive,
                CreatedDate = x.CreatedDate,
            }).ToList();
        }
    }
}
