using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SaleswebMvc.Models;

namespace SaleswebMvc.Data
{
    public class SaleswebMvcContext : DbContext
    {
        public SaleswebMvcContext (DbContextOptions<SaleswebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SaleswebMvc.Models.Department> Department { get; set; }
    }
}
