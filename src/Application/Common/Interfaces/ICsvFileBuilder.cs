using BasketCommerce.Application.TodoLists.Queries.ExportTodos;

namespace BasketCommerce.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
