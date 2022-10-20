using DataAccess.Concrete;
using DTOs.Producer;
using EntityLayer.Models;
using Mapping.ProducerMapping;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Services.ProducerService
{
    public class ProducerService
    {
        private readonly ProducerDAL _dal;
        public ProducerService()
        {
            _dal = new ProducerDAL();
        }
        public bool AddProducer(ProducerDTO dto)
        {
            ProducerDAL dal = new ProducerDAL();
            dal.Add(new ProducerMapping().ProducerDTOToProducer(dto));
            dal.MySaveChanges();
            return true;
        }
        public List<ProducerDTO> GetProducerList()
        {
            List<Producer> liste = _dal.GetAll();
            return new ProducerMapping().ProducerToProducerDTOList(liste);
        }
        public bool ControlProducerName(string producerName)
        {
            var query = _dal.GetAll().Any(x => x.Name == producerName);
            return true;
        }
    }
}
