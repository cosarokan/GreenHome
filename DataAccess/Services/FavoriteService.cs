using DataAccess.Concrete;
using DataAccessLayer;
using DTOs.Favorite;
using EntityLayer.Models;
using Mapping.FavoriteMapping;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Services.FavoriteService
{
    public class FavoriteService
    {
        FavoriteDAL dal = new FavoriteDAL();
        MyContext context = new MyContext();
        public bool AddFavorite(FavoriteDTO dto)
        {
            try
            {
                dal.Add(new FavoriteMapping().FavoriteDTOTOFavorite(dto));
                dal.MySaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<FavoriteDTO> GetFavoritesList()
        {
            List<Favorite> liste = dal.GetAll();
            return new FavoriteMapping().FavoriteListToFavoriteListDTOList(liste);
        }
        public bool ControlFavorite(int productId, int userId)
        {
            return dal.GetAll().Any(x => x.ProductID == productId && x.CustomerID == userId);
        }
        public bool DeleteFavorite(int id)
        {
            var favorite = context.Favorite.FirstOrDefault(x => x.ID == id);
            context.Favorite.Remove(favorite);
            context.SaveChanges();
            return true;
        }
    }
}
