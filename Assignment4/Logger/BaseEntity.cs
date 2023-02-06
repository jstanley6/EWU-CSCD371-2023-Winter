namespace Logger;

public abstract record BaseEntity : IEntity
{
    public Guid Id { get; init; }
    public abstract string Name { get; }
}