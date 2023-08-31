using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerLabLibrary
{
    public class ComputerDbContext:DbContext
    {
        public ComputerDbContext(DbContextOptions<ComputerDbContext> options) : base(options) { }

        public DbSet<ComputerLabModel> computer { get; set; }
        public DbSet<Department> department { get; set; }

    }
}
