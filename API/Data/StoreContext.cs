using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : DbContext
    {

        // StoreContext is a child of DbContext
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        // Set up table in database with property
        public DbSet<Product> Products { get; set; }
    }
}