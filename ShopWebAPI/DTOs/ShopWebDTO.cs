using ShopWebAPI.Models;

namespace ShopWebAPI.DTOs
{
    public class ShopWebDTO
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductCategory { get; set; }
        public string ProductDescription { get; set; }
        public int StockQuantity { get; set; }
        public int StateProduct { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
