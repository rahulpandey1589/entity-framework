using EntityFramework.Infrastructure.Models;
using Infrastructure.Configuration;
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
     
         SeedData seedData = new();
         seedData.SeedSubjectData(modelBuilder);
     
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Product> Products { get; set; }

}
