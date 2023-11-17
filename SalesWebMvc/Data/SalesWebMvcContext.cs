using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Models
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<DepartmentModel> DepartmentModel { get; set; } = default!;
        public DbSet<SellerModel> Seller { get; set; } = default!;
        public DbSet<SalesRecordModel> SalesRecord { get; set; } = default!;
    }
}
