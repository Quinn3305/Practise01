using TestRepo.Repository.Abtraction;

namespace TestRepo.Repository.Entity;

public class OrderDetail: BaseEntity<Guid>, IAudictableEntity
{
    public int Quantity  { get; set; }
    public decimal UnitPrice { get; set; }
    
    // Với Order
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
    
    //Product
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }

}