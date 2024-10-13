using Microsoft.EntityFrameworkCore;
using mvsshop;
using mvsshop.Domain;

namespace mvsshop;

public class AppDbContext : DbContext
{
    private DbSet<Category> categories;

    public AppDbContext(DbContextOptions options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public virtual DbSet<Category> Categories { get => categories; set => categories = value; }
    public virtual DbSet<Product> Products { get; set; }

}
