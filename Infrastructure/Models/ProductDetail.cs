namespace EntityFramework.Infrastructure.Models;

public class ProductDetail
{
   public int Id { get; set; }

   public int TotalQty { get; set; }

   public int ProductId { get; set; }
   public virtual Product Products { get; set; } = default!;
}