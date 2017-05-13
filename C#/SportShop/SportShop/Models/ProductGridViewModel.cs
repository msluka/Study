

using System.ComponentModel.DataAnnotations;

namespace SportShop.Models
{
    public class ProductGridViewModel
    {
        
        public long Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }

    }
}