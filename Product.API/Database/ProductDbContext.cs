using Microsoft.EntityFrameworkCore;
namespace Product.API.Database;

public class ProductDbContext : DbContext
{
    public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
    {
    }

    public DbSet<Domain.Product> Products { get; set; }
}