using System.ComponentModel.DataAnnotations;


namespace ProductsAndCategoriesDataBaseM2M.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
