namespace TestRepo.Repository.Abtraction;

public interface IAudictableEntity
{
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
}