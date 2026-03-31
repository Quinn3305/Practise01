using TestRepo.Repository.Abtraction;

namespace TestRepo.Repository.Entity;

public class Cart: BaseEntity<Guid>, IAudictableEntity
{
    public decimal TotalAmount { get; set; }   
    
    
    //Cart với User
    public Guid UserId { get; set; }
    public User User { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}