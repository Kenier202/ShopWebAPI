using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopWebAPI.Models
{
    public class Products
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdProduct { get; set; }

        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        // Cambiar ProductCategoryId a int para que coincida con el Id de ProductCategory
        public int ProductCategoryId { get; set; }

        // Definir ProductCategory como una propiedad de navegación a la entidad relacionada
        [ForeignKey(nameof(ProductCategoryId))]
        public ProductCategory ProductCategory { get; set; }

        public string ProductDescription { get; set; }
        public int StockQuantity { get; set; }

        public int StateProductId { get; set; }

        // Definir StateProduct como una propiedad de navegación a la entidad relacionada
        [ForeignKey(nameof(StateProductId))]
        public State_product StateProduct { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
