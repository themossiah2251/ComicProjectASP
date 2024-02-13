using ComicProjectASP.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicProjectASP.Models
{
    [Table("Category")]
    public class Category
    {
        [Required]
        public int Id { get; set; }
        public string? CategoryName { get; set; }

        public List<Products> Products { get; set; }
    }
}
