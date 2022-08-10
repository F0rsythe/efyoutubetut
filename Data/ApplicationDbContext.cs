using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efyoutubetut.Models;
using Microsoft.EntityFrameworkCore;

namespace efyoutubetut.Data
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Book> Books { get; set;}

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}