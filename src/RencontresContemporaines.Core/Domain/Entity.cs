namespace RencontresContemporaines.Core.Domain;

public abstract class Entity
{
    private readonly Guid id;
    
    public Guid Id => id;

    public Entity(Guid id)
    {
        this.id = id;
    }
}