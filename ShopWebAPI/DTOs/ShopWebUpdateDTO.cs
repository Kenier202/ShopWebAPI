using ShopWebAPI.Models;

namespace ShopWebAPI.DTOs
{
    public class ShopWebUpdateDTO
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductCategoryid { get; set; }
        public string ProductDescription { get; set; }
        public int StockQuantity { get; set; }
        public int StateProductid { get; set; }
    }
}
