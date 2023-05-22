using BasketCommerce.Application.Common.Exceptions;
using BasketCommerce.Application.TodoItems.Commands.CreateTodoItem;
using BasketCommerce.Application.TodoItems.Commands.DeleteTodoItem;
using BasketCommerce.Application.TodoLists.Commands.CreateTodoList;
using BasketCommerce.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace BasketCommerce.Application.IntegrationTests.TodoItems.Commands;

using static Testing;

public class DeleteTodoItemTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoItemId()
    {
        var command = new DeleteTodoItemCommand(99);

        await FluentActions.Invoking(() =>
            SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoItem()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        var itemId = await SendAsync(new CreateTodoItemCommand
        {
            ListId = listId,
            Title = "New Item"
        });

        await SendAsync(new DeleteTodoItemCommand(itemId));

        var item = await FindAsync<TodoItem>(itemId);

        item.Should().BeNull();
    }
}
