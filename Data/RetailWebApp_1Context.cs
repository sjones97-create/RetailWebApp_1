using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RetailWebApp_1.Models;

namespace RetailWebApp_1.Data
{
    public class RetailWebApp_1Context : DbContext
    {
        public RetailWebApp_1Context (DbContextOptions<RetailWebApp_1Context> options)
            : base(options)
        {
        }

        public DbSet<RetailWebApp_1.Models.Product> Product { get; set; } = default!;
    }
}
