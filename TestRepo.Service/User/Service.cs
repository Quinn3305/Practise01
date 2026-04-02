using Microsoft.EntityFrameworkCore;
using TestRepo.Repository;

namespace TestRepo.Service.User;

public class Service: IService
{
    private readonly AppDbContext _dbContext;
    public Service(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<string> CreateUser(Request.CreateUserRequest request)
    {
        var existingUserQuery = _dbContext.Users.Where(x=> x.Email == request.Email);
        bool isExist = await existingUserQuery.AnyAsync();
        if(isExist) throw new Exception("User Exists With Email");

        var user = new Repository.Entity.User
        {
            Email = request.Email,
            FirstName = request.FirstName,
            LastName = request.LastName,
            HashedPassword = request.Password,
            Role = "User"
        };
        _dbContext.Add(user);
        await _dbContext.SaveChangesAsync();
        return "User Created Successfully";
    }
}