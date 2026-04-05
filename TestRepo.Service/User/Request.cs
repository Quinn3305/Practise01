namespace TestRepo.Service.User;

public class Request
{
    public class CreateUserRequest
    {
        public string Email { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
// thêm xoá sửa 
}