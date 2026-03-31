using Microsoft.EntityFrameworkCore;
using TestRepo.Repository.Entity;

namespace TestRepo.Repository;

public class AppDbContext : DbContext
{
    
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    // public DbSet<User> Users { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Seller> Sellers { get; set; }
    public DbSet<Storage> Storages { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
    public DbSet<ProductStorage> ProductStorages { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Cart> Carts { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(builder =>
        {
            var user = new List<User>()
            {
                new()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Gia",
                    LastName = "Quyen",
                    Email = "admin@gmail.com",
                    HashedPassword = "PiedTeam",
                    Role = "Admin"
                }
            };
            builder.HasData(user);
        });
    }
}