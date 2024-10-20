﻿namespace ShopWebAPI.DTOs
{
    public class ShopWebUpdateDTO
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductCategory { get; set; }
        public string ProductDescription { get; set; }
        public int StockQuantity { get; set; }
        public bool IsActive { get; set; }
    }
}
