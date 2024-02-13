namespace ComicProjectASP.Models
{
    public class CartViewModel
    {
        public List<CartDetails> CartItems { get; set; }
        public double TotalPrice => CartItems?.Sum(item => item.UnitPrice * item.Quantity) ?? 0;

    }
}

