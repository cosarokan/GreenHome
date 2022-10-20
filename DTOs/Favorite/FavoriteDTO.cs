using System;

namespace DTOs.Favorite
{
    public class FavoriteDTO
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Customer { get; set; }
        public string Product { get; set; }
    }
}
