using TestRepo.Repository.Abtraction;

namespace TestRepo.Repository.Entity;

public class Category: BaseEntity<Guid>, IAudictableEntity
{
    public required string Name  { get; set; }
    public Guid? ParentId  { get; set; }
    public Category? Parent { get; set; }
   
    
    //Cate
    public ICollection<Category> Children { get; set; } =  new List<Category>();
    //Pro Cate
    public ICollection<ProductCategory> ProductCategories { get; set; } =  new List<ProductCategory>();
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}