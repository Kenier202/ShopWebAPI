namespace ShopWebAPI.DTOs
{
    public class ShopWebDTO
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public string ProductCategory { get; set; }
        public string ProductDescription { get; set; }
        public int StockQuantity { get; set; }
        public int IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
