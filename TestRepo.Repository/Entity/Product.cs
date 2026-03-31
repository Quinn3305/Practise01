using TestRepo.Repository.Abtraction;

namespace TestRepo.Repository.Entity;

public class Product: BaseEntity<Guid>, IAudictableEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string  Description { get; set; }
    public string UrlImage  { get; set; } = string .Empty;
    
    
    //Inventory
    public Inventory Inventory { get; set; }
    //Seller
    public Guid SellerId  { get; set; }
    public Seller Seller { get; set; }
    
    //OrderDetail
    public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    
    //ProductCategory
    public ICollection<ProductCategory> ProductCategories { get; set; } = new List<ProductCategory>();
    
    //ProductStorage
    public ICollection<ProductStorage> ProductStorages { get; set; } = new List<ProductStorage>();
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}