using System.ComponentModel.DataAnnotations;


namespace ProductsAndCategoriesDataBaseM2M.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
