using ComicProjectASP.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicProjectASP.Models
{
    [Table("Brand")]
    public class Brand
    {
        public int Id { get; set; }
        public string Brand_Name { get; set; }

        public ICollection<Products> Products { get; set; }
    }
}
