using System;

namespace OS.Events
{
    public abstract class DomainEvent : IDomainEvent
    {
        protected DomainEvent()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.UtcNow();
        }

        public Guid CorrelationId { get; set; }
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}