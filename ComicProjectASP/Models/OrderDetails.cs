using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicProjectASP.Models
{
    [Table("Order Details")]
    public class OrderDetails
    {
        public int Id { get; set; }
        [Required]
        public int? OrderId { get; set; }
        [Required]
        public int? ProductId { get; set; }
        [Required]
        public int? Quantity { get; set; }
        public double? UnitPrice { get; set; }
        public Products Products { get; set; }
        public Orders Orders { get; set; }
    }
}
