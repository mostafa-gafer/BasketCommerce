using BasketCommerce.Application.Common.Mappings;
using BasketCommerce.Domain.Entities;

namespace BasketCommerce.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}
