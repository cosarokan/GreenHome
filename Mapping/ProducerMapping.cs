using DTOs.Producer;
using EntityLayer.Models;
using System.Collections.Generic;
using System.Linq;
namespace Mapping.ProducerMapping
{
    public class ProducerMapping
    {
        public Producer ProducerDTOToProducer(ProducerDTO dto)
        {
            return new Producer()
            {
                ID = dto.ID,
                Name = dto.Name,
                CreatedDate = dto.CreatedDate,
                IsActive = dto.IsActive
            };
        }
        public List<ProducerDTO> ProducerToProducerDTOList(List<Producer> producerList)
        {
            return producerList.Select(x => new ProducerDTO
            {
                ID = x.ID,
                Name = x.Name,
                IsActive = x.IsActive,
                CreatedDate = x.CreatedDate,
            }).ToList();
        }
    }
}
