using TestRepo.Repository.Abtraction;

namespace TestRepo.Repository.Entity;

public class Order: BaseEntity<Guid>, IAudictableEntity
{
    public required decimal TotalAmount { get; set; }
    public required string Status { get; set; } = "Pending";
    public required string Address { get; set; }
   
    
    //Order với User
    public Guid UserId { get; set; }
    public User User { get; set; }
    
    //OrderDetail
    public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();


    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}