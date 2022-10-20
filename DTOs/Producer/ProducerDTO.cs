using System;
namespace DTOs.Producer
{
    public class ProducerDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
