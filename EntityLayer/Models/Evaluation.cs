using EntityLayer.Models.Abstract;
using System.ComponentModel.DataAnnotations;
namespace EntityLayer.Models
{
    public class Evaluation : Base
    {
        [StringLength(50)]
        public string ContentEvaluation { get; set; }

        public override string ToString()
        {
            return ContentEvaluation;
        }
    }
}
