namespace SharedModule.DDD;

public abstract class Aggregate<TId> : Entity<TId>, IAggregate<TId>
{
    private readonly List<IDomainEvent> _domainEvents = new();
    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();


    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        if (domainEvent == null) throw new ArgumentNullException(nameof(domainEvent));
        _domainEvents.Add(domainEvent);
    }
    public IDomainEvent[] CleareDomainEvents()
    {
        IDomainEvent[] events = _domainEvents.ToArray();
        _domainEvents.Clear();
        return events;
    }
}