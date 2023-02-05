using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace DataAccess
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Prodcts { get; set; }
    }
}
