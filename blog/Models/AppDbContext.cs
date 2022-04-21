using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;
using Microsoft.EntityFrameworkCore;

namespace blog.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):
            base(options)
        {
        }

        public DbSet<Posts> Posts { get; set; }
        public DbSet<Category> Category { get; set; }
        
    }
}
