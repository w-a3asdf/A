using Microsoft.EntityFrameworkCore;
using Whear.Web.Models;

namespace Whear.Web.Data
{
    public class Context : DbContext
    {
        public DbSet<User> User { get; set; }
        
        public Context(DbContextOptions<Context> options) : base(options) { }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=whear;user=root;password=");
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("user");
            
            /*modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Email);
                entity.Property(e => e.Password);
            });*/
        }
    }
}