using DTOs.Category;
using EntityLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace Mapping.CategoryMapping
{
    public class CategoryMapping
    {
        public Category CategoryDTOTOCategory(CategoryDTO category)
        {
            return new Category()
            {
                Name = category.CategoryName,
                TopCategoryID = category.TopCategoryID,
                CreatedDate = category.CreatedDate,
                IsActive = category.IsActive
            };
        }
        public List<CategoryListDTO> CategoryListToCategoryListDTOList(List<Category> categoryList)
        {
            return categoryList.Select(x => new CategoryListDTO
            {
                ID = x.ID,
                Name = x.Name,
                TopCategoryID = x.TopCategoryID,
            }).ToList();
        }
    }
}
