using EntityLayer.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Models
{
    public class Brand : Base
    {
        [StringLength(50)]
        public string Name { get; set; }
    }
}
