
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicProjectASP.Models
{
    [Table("Products")]
    public class Products
    {
        public int Id { get; set; }
            [Required]

            public int? BrandId { get; set; }
            [Required]
            public string? BrandName { get; set; }
            public string? Category_Name { get; set; }
            
            public int? CategoryId { get; set; }


            public string? Name { get; set; }
            public double? Price { get; set; }
          public string? Images { get; set; }

        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }

        public List<CartDetails> CartDetails { get; set; }

    }
    }



