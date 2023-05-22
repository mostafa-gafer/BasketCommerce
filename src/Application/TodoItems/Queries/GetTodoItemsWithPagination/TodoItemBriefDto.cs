using BasketCommerce.Application.Common.Mappings;
using BasketCommerce.Domain.Entities;

namespace BasketCommerce.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; init; }

    public int ListId { get; init; }

    public string? Title { get; init; }

    public bool Done { get; init; }
}
