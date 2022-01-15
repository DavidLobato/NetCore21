using Microsoft.EntityFrameworkCore;
using SaleswebMvc.Models;

namespace SaleswebMvc.Data
{
    public class SaleswebMvcContext : DbContext
    {
        public SaleswebMvcContext(DbContextOptions<SaleswebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
