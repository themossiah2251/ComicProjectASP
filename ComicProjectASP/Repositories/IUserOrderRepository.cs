using ComicProjectASP.Models;

namespace ComicProjectASP.Repositories
{
    public interface IUserOrderRepository
    {
        //just like we did for both interfaces home and cart 
        Task<IEnumerable<Orders>> UserOrders();
    }
}