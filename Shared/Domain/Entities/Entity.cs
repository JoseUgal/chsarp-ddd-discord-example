using Discord.Shared.Domain.Aggregate;

namespace Discord.Shared.Domain.Entities;

public abstract class Entity : AggregateRoot,
    ICreatedAt, ICreatedBy, 
    IModifiedAt, IModifiedBy, 
    IDeletedAt, IDeletedBy
{
    public DateTime CreatedAt { get; private set; }
    public string CreatedBy { get; private set; }
    public DateTime? ModifiedAt { get; private set; }
    public string ModifiedBy { get; private set; }
    public DateTime? DeletedAt { get; private set; }
    public string DeletedBy { get; private set; }

    public void UpdateCreationDate(string createdBy)
    {
        CreatedAt = DateTime.Now;
        CreatedBy = createdBy;
    }
    
    public void UpdateModificationDate(string modifiedBy)
    {
        ModifiedAt = DateTime.Now;
        ModifiedBy = modifiedBy;
    }
    
    public void UpdateDeletionDate(string deletedBy)
    {
        DeletedAt = DateTime.Now;
        CreatedBy = deletedBy;
    }
}