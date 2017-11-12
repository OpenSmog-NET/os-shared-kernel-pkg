using System;

namespace OS.Events
{
    public interface IDomainEvent
    {
        Guid CorrelationId { get; }
        Guid Id { get; }
        DateTime CreatedDate { get; }
    }
}