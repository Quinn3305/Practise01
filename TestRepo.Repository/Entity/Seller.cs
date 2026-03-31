using TestRepo.Repository.Abtraction;

namespace TestRepo.Repository.Entity;

public class Seller: BaseEntity<Guid>, IAudictableEntity
{
    public required string TaxCode  { get; set; }
    public required string CompanyName  { get; set; }
    public required string CompanyAddress  { get; set; }
    
    
    
    //Seller với User
    public Guid UserId  { get; set; }
    public User User  { get; set; }
    
    //Product
    public ICollection<Product> Products { get; set; } = new List<Product>();
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}