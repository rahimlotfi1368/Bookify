using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Reviews.Events;

public record ReviewCreatedDomainEvent(Guid ReviwId):IDomainEvent;