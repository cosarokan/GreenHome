using EntityLayer.Models.Abstract;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Models
{
    public class Customer : Base
    {
        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{Username}";
        }
    }
}
