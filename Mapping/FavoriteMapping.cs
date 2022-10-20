using DTOs.Favorite;
using EntityLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace Mapping.FavoriteMapping
{
    public class FavoriteMapping
    {
        public Favorite FavoriteDTOTOFavorite(FavoriteDTO dto)
        {
            return new Favorite()
            {
                CustomerID = dto.CustomerID,
                ProductID = dto.ProductID,
                IsActive = dto.IsActive,
                CreatedDate = dto.CreatedDate
            };
        }
        public List<FavoriteDTO> FavoriteListToFavoriteListDTOList(List<Favorite> favoriteList)
        {
            return favoriteList.Select(x => new FavoriteDTO
            {
                ID = x.ID,
                CustomerID = x.CustomerID,
                ProductID = x.ProductID,
                CreatedDate = x.CreatedDate,
                IsActive = x.IsActive,
                Customer = x.Customer.Username,
                Product = x.Product.Name
            }).ToList();
        }
    }
}
