using TestRepo.Repository.Abtraction;

namespace TestRepo.Repository.Entity;

public class User: BaseEntity<Guid>, IAudictableEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string HashedPassword { get; set; }
    public string? DateOfBirth { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? ImageUrl { get; set; } = null;
    public bool IsVerify { get; set; } = false;
    public int VerifyCode { get; set; } //Mã gửi mail
    public string Role { get; set; } = "User";
    
    //User với Seller
    public Seller? Seller { get; set; }
    //User với Cart
    public Cart? Cart { get; set; }
    //User với Order
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}