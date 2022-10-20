using EntityLayer.Models.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Models
{
    public class Favorite : Base
    {
        public int CustomerID { get; set; }
        public int ProductID { get; set; }



        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }


        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}
