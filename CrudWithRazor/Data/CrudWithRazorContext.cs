using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CrudWithRazor.Models;

namespace CrudWithRazor.Data
{
    public class CrudWithRazorContext : DbContext
    {
        public CrudWithRazorContext (DbContextOptions<CrudWithRazorContext> options)
            : base(options)
        {
        }

        public DbSet<CrudWithRazor.Models.Product> Product { get; set; } = default!;
    }
}
