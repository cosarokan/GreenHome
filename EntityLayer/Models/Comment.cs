using EntityLayer.Models.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EntityLayer.Models
{
    public class Comment : Base
    {
        [StringLength(50)]
        public string Text { get; set; }

        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int ApprovedAdminID { get; set; }
        public bool IsApproved { get; set; }


        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [ForeignKey("ApprovedAdminID")]
        public virtual Admin Admin { get; set; }
    }
}
