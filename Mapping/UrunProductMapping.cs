using DTOs.Product;
using EntityLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace Mapping.UrunProductMapping
{
    public class UrunProductMapping
    {
        public Product ProductDTOTOProduct(ProductDTO product)
        {
            return new Product()
            {
                ID = product.ID,
                Name = product.ProductName,
                CategoryID = product.CategoryID,
                ProducerID = product.ProducerID,
                CustomerID = product.CustomerID,
                ApprovedAdminID = product.ApprovedAdminID,
                IsApproved = product.IsApproved,
                CreatedDate = product.CreatedDate,
                BarcodeNumber = product.BarcodeNumber,
                Picture = product.Picture,
                Content = product.Content
            };
        }


        public List<ProductListDTO> ProductListToProductListDTOList(List<Product> productList)
        {
            return productList.Select(x => new ProductListDTO
            {
                ProducerName = x.Producer.ToString(),
                CategoryName = x.Category.Name,
                ProductName = x.Name,
                IsApproved = x.IsApproved,
                ApprovedAdminID = x.ApprovedAdminID,
                BarcodeNumber = x.BarcodeNumber,
                Customer = x.Customer.Username,
                Content = x.Content,
                CustomerID = x.CustomerID,
                ID = x.ID,
                IsActive = x.IsActive,
                CreatedDate = x.CreatedDate
            }).ToList();
        }

        public List<ProductDTO> ProductToProductDTOList(List<Product> productList)
        {
            return productList.Select(x => new ProductDTO
            {
                ProducerName = x.Producer.Name,
                CategoryName = x.Category.Name,
                ProductName = x.Name,
                IsApproved = x.IsApproved,
                ApprovedAdminID = x.ApprovedAdminID,
                BarcodeNumber = x.BarcodeNumber,
                Customer = x.Customer.Username,
                Content = x.Content,
                CustomerID = x.CustomerID.Value,
                ID = x.ID,
                IsActive = x.IsActive,
                CreatedDate = x.CreatedDate,
                CategoryID = x.CategoryID,
                ProducerID = x.ProducerID,
                Picture = x.Picture
            }).ToList();
        }
    }
}
