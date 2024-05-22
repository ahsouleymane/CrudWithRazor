using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudWithRazor.Data;
using CrudWithRazor.Models;

namespace CrudWithRazor.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly CrudWithRazor.Data.CrudWithRazorContext _context;

        public IndexModel(CrudWithRazor.Data.CrudWithRazorContext context)
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
