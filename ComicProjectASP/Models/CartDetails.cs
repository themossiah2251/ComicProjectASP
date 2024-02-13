using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicProjectASP.Models
{
    [Table("Cart Details")]
    public class CartDetails
    {
        public int Id { get; set; }
        [Required]
        public int? CartId { get; set; }
        [Required]
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public Products Products { get; set; }
        public Cart Cart { get; set; }

    }
}
