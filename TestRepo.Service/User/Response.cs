namespace TestRepo.Service.User;

public class Response
{
    public class GetUserResponse
    {
        public Guid Id  { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public string? PhoneNumber  { get; set; }
        public string? Address  { get; set; }
        public string Role  { get; set; } = "User";//User
    }
    public class GetUserByIdResponse
    {
        public Guid Id  { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public string? PhoneNumber  { get; set; }
        public string? Address  { get; set; }
        public string Role  { get; set; } = "User";//User
        
    }
    
}