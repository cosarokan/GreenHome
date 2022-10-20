namespace DTOs.Category
{
    public class CategoryListDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TopCategoryID { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
