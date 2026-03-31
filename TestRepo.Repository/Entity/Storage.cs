using TestRepo.Repository.Abtraction;

namespace TestRepo.Repository.Entity;

public class Storage: BaseEntity<Guid>, IAudictableEntity
{
    public decimal Price { get; set; }
    public string Type  { get; set; }

    public ICollection<ProductStorage> ProductStorages { get; set; } = new List<ProductStorage>();
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}