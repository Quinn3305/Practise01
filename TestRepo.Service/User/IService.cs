namespace TestRepo.Service.User;

public interface IService
{
    public Task<string> CreateUser(Request.CreateUserRequest request);
    public Task<Base.Response.PageResult<Response.GetUserResponse>> GetUser(string? searchTerm, int pageIndex, int pageSize);
    
    public Task<Response.GetUserByIdResponse?> GetUserById(Guid id);
}