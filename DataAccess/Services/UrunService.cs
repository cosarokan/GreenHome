using DataAccess.Concrete;
using DTOs.Product;
using EntityLayer.Models;
using Mapping.UrunProductMapping;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Services.UrunService
{
    public class UrunService
    {
        private readonly ProductDAL _dal;

        public UrunService()
        {
            _dal = new ProductDAL();
        }
        public bool AddProduct(ProductDTO dto)
        {
            _dal.Add(new UrunProductMapping().ProductDTOTOProduct(dto));
            _dal.MySaveChanges();
            return true;
        }
        public List<ProductDTO> GetProductList()
        {
            List<Product> liste = _dal.GetAll();
            return new UrunProductMapping().ProductToProductDTOList(liste);
        }
        public bool UpdateProduct(ProductDTO dto)
        {
            var product = _dal.GetAll().Where(x => x.ID == dto.ID).FirstOrDefault();
            if (product != null)
            {
               product.ID = dto.ID;
               product.Name = dto.ProductName;
               product.CategoryID = dto.CategoryID;
               product.ProducerID = dto.ProducerID;
               product.CustomerID = dto.CustomerID;
               product.ApprovedAdminID = dto.ApprovedAdminID;
               product.IsApproved = dto.IsApproved;
               product.CreatedDate = dto.CreatedDate;
               product.BarcodeNumber = dto.BarcodeNumber;
               product.Picture = dto.Picture;
               product.Content = dto.Content;
            }
            _dal.Update(product);
            return true;
        }
        public List<ProductDTO> GetProductByBarcodeNumber(string barcode)
        {
            List<Product> liste = _dal.GetAll().Where(x => x.BarcodeNumber.Contains(barcode)).ToList();
            return new UrunProductMapping().ProductToProductDTOList(liste);
        }
        public int GetCountByCustomerId(int? customerId)
        {
            return _dal.GetAll(x => x.CustomerID == customerId).Count();
        }
        public List<ProductDTO> SearchResult(string text)
        {
            List<Product> liste = _dal.GetAll().Where(x => x.Name.ToLower().Contains(text)).ToList();
            return new UrunProductMapping().ProductToProductDTOList(liste);
        }
        public bool ControlProduct(string productName)
        {
            return _dal.GetAll().Any(x => x.Name == productName);
        }
        public List<ProductDTO> GetApprovedProduct()
        {
            List<Product> liste = _dal.GetAll().Where(x => x.IsApproved == true).ToList();
            return new UrunProductMapping().ProductToProductDTOList(liste);
        }
        public bool IsThereSameBarcodeNumber(string number)
        {
            return _dal.GetAll().Any(x => x.BarcodeNumber == number);
        }
        public List<ProductDTO> GetByProducerName(string producerName)
        {
            List<Product> liste = _dal.GetAll().Where(x => x.Producer.Name == producerName).ToList();
            return new UrunProductMapping().ProductToProductDTOList(liste);
        }
        public bool ControlTexts(string productName,string productContent, string picture)
        {
            if (productName == "" || productContent == "" || picture == "")
            {
                return true;
            }
            return false;
        }
    }
}
