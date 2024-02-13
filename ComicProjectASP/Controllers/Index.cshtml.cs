using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ComicProjectASP.Data;
using ComicProjectASP.Models;

namespace ComicProjectASP.Controllers
{
    public class IndexModel : PageModel
    {
        private readonly ComicProjectASP.Data.ApplicationDbContext _context;

        public IndexModel(ComicProjectASP.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Products> Products { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Products = await _context.Products
                .Include(p => p.Brand)
                .Include(p => p.Category).ToListAsync();
        }
    }
}
