using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LearnBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        [Range(1,1000)]
        public double Price { get; set; }
        public IEnumerable<Product_Property> ProductProperties { get; set; }
        public Category Category { get; set; }
        public DateTime? AvailableAfter { get; set; } = DateTime.Now;

    }

    public enum Category { 
        Starter,
        Dessert,
        Dinner
    }
}
