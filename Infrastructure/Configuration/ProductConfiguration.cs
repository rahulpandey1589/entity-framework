using EntityFramework.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configuration;

public class ProductConfiguration
        : IEntityTypeConfiguration<Product>
{
    public void Configure(
        EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).UseIdentityColumn();

        builder.Property(x => x.ProductName).IsRequired().HasMaxLength(100);

        builder.Property(x => x.ProductDescription).HasMaxLength(500);

        builder.HasOne(x => x.ProductDetails)
             .WithOne(prd => prd.Products)
             .HasForeignKey<ProductDetail>(frn => frn.ProductId);
    }
}