using Microsoft.EntityFrameworkCore;
using Whear.Web.Models;

namespace Whear.Web.Data
{
    public class Context : DbContext
    {
        public DbSet<User> User { get; set; }
        
        public Context(DbContextOptions<Context> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Converts models to MySQL tables.
            modelBuilder.Entity<User>().ToTable("user");
        }
    }
}