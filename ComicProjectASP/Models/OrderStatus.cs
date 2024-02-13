using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicProjectASP.Models
{
    [Table("Order Status")]
    public class OrderStatus
    {
        public int Id { get; set; }
        public int? StatusId { get; set; }
       


        [Required,MaxLength(50)]
        public string? StatusName { get; set; }
    }
}
