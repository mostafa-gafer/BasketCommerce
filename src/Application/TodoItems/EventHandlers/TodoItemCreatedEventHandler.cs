using BasketCommerce.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace BasketCommerce.Application.TodoItems.EventHandlers;

public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("BasketCommerce Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
