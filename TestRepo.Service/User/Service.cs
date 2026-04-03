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

    public async Task<Base.Response.PageResult<Response.GetUserResponse>> GetUser(string? searchTerm, int pageIndex, int pageSize)
    {
        var query =  _dbContext.Users.Where(x=> true);
        if (searchTerm != null)
        {
            query = query.Where(x =>
                x.FirstName.Contains(searchTerm) || x.LastName.Contains(searchTerm) ||  x.Email.Contains(searchTerm));
        }
        query = query.OrderBy(x=> x.Email).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        var selectedQuery = query.Select(x => new Response.GetUserResponse
        {
            Id = x.Id,
            Email = x.Email,
            FirstName = x.FirstName,
            LastName = x.LastName,
            ImageUrl = x.ImageUrl,
            Address = x.Address,
            PhoneNumber = x.PhoneNumber,
            Role = x.Role
        });
        var listResult = await selectedQuery.ToListAsync();
        var totalItems = listResult.Count();
        var result = new Base.Response.PageResult<Response.GetUserResponse>()
        {
            TotalItems = totalItems,
            PageIndex = pageIndex,
            PageSize = pageSize,
            Items = listResult
        };
        return result;
    }
    

    public async Task<Response.GetUserByIdResponse?> GetUserById(Guid id)
    {
        var query = _dbContext.Users.Where(x => x.Id == id);
        
        var selectedQuery = query.Select(x => new Response.GetUserByIdResponse()
        {
            Id = x.Id,
            Email = x.Email,
            FirstName = x.FirstName,
            LastName = x.LastName,
            ImageUrl = x.ImageUrl,
            Address = x.Address,
            PhoneNumber = x.PhoneNumber,
            Role = x.Role
        });
        var result = await selectedQuery.FirstOrDefaultAsync();
        return result;

    }
}