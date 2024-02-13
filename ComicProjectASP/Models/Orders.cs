using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicProjectASP.Models
{
    [Table("Orders")]
    public class Orders
    {
        public int Id { get; set; }
        [Required]
        public string? UserId { get; set; }
        public int OrderStatusId { get; set; }
        public DateTime CreateDate { get; set; }=DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public OrderStatus OrderStatus { get; set; }

        public List<OrderDetails> OrderDetails { get; set; }
        

    }
}
