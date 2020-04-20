using Microsoft.EntityFrameworkCore;

namespace ShoppingApp.Controllers.Models.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){ }

        public DbSet<Value> Values { get; set; }
    }
}