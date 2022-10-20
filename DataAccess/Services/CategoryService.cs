using DataAccess.Concrete;
using DTOs.Category;
using EntityLayer.Models;
using Mapping.CategoryMapping;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Services.CategoryService
{
    public class CategoryService
    {
        CategoryDAL dal = new CategoryDAL();
        public bool AddCategory(CategoryDTO dto)
        {
            dal.Add(new CategoryMapping().CategoryDTOTOCategory(dto));
            dal.MySaveChanges();
            return true;
        }
        public List<CategoryListDTO> GetCategoryList()
        {
            List<Category> liste = dal.GetAll();
            return new CategoryMapping().CategoryListToCategoryListDTOList(liste);
        }
        public bool ControlCategoryName(string categoryName)
        {
            var query = dal.GetAll().Any(x => x.Name == categoryName);
            return true;
        }
        public bool CategoryNameCount(string categoryName, string topCategoryId)
        {
            if (categoryName.Length < 2 || string.IsNullOrEmpty(topCategoryId))
            {
                return true;
            }
            return false;
        }
    }
}
