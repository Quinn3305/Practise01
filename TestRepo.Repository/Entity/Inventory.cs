using TestRepo.Repository.Abtraction;

namespace TestRepo.Repository.Entity;

public class Inventory: BaseEntity<Guid>, IAudictableEntity
{
    public int TotalSell { get; set; }
    public int TotalInStock { get; set; }
    //Product
    public Guid ProductId  { get; set; }
    public Product Product { get; set; }
    
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}