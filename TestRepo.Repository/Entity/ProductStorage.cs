using TestRepo.Repository.Abtraction;

namespace TestRepo.Repository.Entity;

public class ProductStorage: BaseEntity<Guid>, IAudictableEntity
{
    
    public Guid ProductId { get; set; }
    public Product Product { get; set; }
    
    public Guid StorageId { get; set; }
    public Storage Storage { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}