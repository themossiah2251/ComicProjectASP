using ComicProjectASP.Data;
using ComicProjectASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ComicProjectASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index(string searchQuery = "", string category = "")
        {
            IQueryable<Products> query = _context.Products.Include(p => p.Brand).Include(p => p.Category);

            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                query = query.Where(p => p.Name.Contains(searchQuery) || p.BrandName.Contains(searchQuery));
            }

            if (!string.IsNullOrWhiteSpace(category) && category != "Choose")
            {
                query = query.Where(p => p.Category.CategoryName == category);
            }

            var viewModel = new ProductViewModel
            {
                Products = await query.ToListAsync()
            };

            return View(viewModel);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

