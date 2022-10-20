using EntityLayer.Models.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Models
{
    public class ProductEvaluation : Base
    {
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int EvaluationID { get; set; }


        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("EvaluationID")]
        public virtual Evaluation Evaluation { get; set; }
    }
}
