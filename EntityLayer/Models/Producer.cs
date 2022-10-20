using EntityLayer.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Models
{
    public class Producer : Base
    {
        [StringLength(50)]
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
