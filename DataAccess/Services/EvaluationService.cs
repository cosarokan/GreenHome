using DataAccess.Concrete;
using DTOs.Evaluation;
using EntityLayer.Models;
using Mapping;
using System.Collections.Generic;

namespace DataAccess.Services
{
    public class EvaluationService
    {
        EvaluationDAL dal = new EvaluationDAL();
        public bool AddEvaluation(EvaluationDTO dto)
        {
            dal.Add(new EvaluationMapping().EvaluationDTOTOEvaluation(dto));
            dal.MySaveChanges();
            return true;
        }
        public List<EvaluationDTO> GetEvaluationList()
        {
            List<Evaluation> liste = dal.GetAll();
            return new EvaluationMapping().EvaluationListToEvaluationListDTOList(liste);
        }
    }
}
