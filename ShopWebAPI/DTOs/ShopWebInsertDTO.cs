using ShopWebAPI.Models;

namespace ShopWebAPI.DTOs
{
    public class ShopWebInsertDTO
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductCategoryId { get; set; } // Cambiado a ID de categoría
        public string ProductDescription { get; set; }
        public int StockQuantity { get; set; }
        public int StateProductId { get; set; } // Cambiado a ID de estado
    }

}
