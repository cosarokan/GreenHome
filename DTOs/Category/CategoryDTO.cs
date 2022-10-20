using System;

namespace DTOs.Category
{
    public class CategoryDTO
    {
        public string CategoryName { get; set; }
        public int TopCategoryID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
