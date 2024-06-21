using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using mentoring_2.Data;
using mentoring_2.Models;

namespace mentoring_2.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly mentoring_2.Data.ApplicationDbContext _context;

        public IndexModel(mentoring_2.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
