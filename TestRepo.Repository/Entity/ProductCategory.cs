using TestRepo.Repository.Abtraction;

namespace TestRepo.Repository.Entity;

public class ProductCategory: BaseEntity<Guid>, IAudictableEntity
{
    //Product
    public Guid ProductId  { get; set; }
    public Product Product { get; set; }
    
    //Category
    public Guid CategoryId  { get; set; }
    public Category Category { get; set; }
    
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}