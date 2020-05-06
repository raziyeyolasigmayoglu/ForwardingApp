using Microsoft.EntityFrameworkCore;

namespace ForwardingApp
{
    public class ForwardingAppContext : DbContext
    {
        public DbSet<Box> Boxes {get;set;}
        public DbSet<Part> Parts {get;set;}
        public DbSet<Order> Orders {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=ForwardingAppDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}