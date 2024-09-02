using EntityFramework.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

public class InventoryDbContext : DbContext
{

    public InventoryDbContext(
      DbContextOptions<InventoryDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly( typeof(InventoryDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Product> Products { get; set; }

}
