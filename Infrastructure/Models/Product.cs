
namespace EntityFramework.Infrastructure.Models;

public class Product
{
    public int Id { get; set; }

    public string ProductName { get; set; } = default!;

    public string ProductDescription { get; set; } = default!;

    public bool IsActive { get; set; }

    public virtual ProductDetail ProductDetails { get; set; } = default!;

}