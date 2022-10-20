﻿using System;

namespace DTOs.Product
{
    public class ProductListDTO
    {
        public string BarcodeNumber { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string ProducerName { get; set; }
        public bool IsApproved { get; set; }
        public int? ApprovedAdminID { get; set; }
        public string Customer { get; set; }
        public string Content { get; set; }
        public int? CustomerID { get; set; }
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

