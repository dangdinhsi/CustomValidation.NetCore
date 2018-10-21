using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CustomVladiationDotNetCore.Models
{
    public class CustomVladiationDotNetCoreContext : DbContext
    {
        public CustomVladiationDotNetCoreContext (DbContextOptions<CustomVladiationDotNetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<CustomVladiationDotNetCore.Models.Member> Member { get; set; }
    }
}
