using EntityLayer.Models.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Models
{
    public class Product : Base
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Picture { get; set; }

        [StringLength(15)]
        public string BarcodeNumber { get; set; }

        [StringLength(100)]
        public string Content { get; set; }

        public int CategoryID { get; set; }
        public int ProducerID { get; set; }
        public int? BrandID { get; set; }
        public int? CustomerID { get; set; }
        public int? ApprovedAdminID { get; set; }
        public bool IsApproved { get; set; }

        public override string ToString()
        {
            return Name;
        }


        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        [ForeignKey("ProducerID")]
        public virtual Producer Producer { get; set; }

        [ForeignKey("BrandID")]
        public virtual Brand Brand { get; set; }


        [ForeignKey("ApprovedAdminID")]
        public virtual Admin Admin { get; set; }
    }
}
