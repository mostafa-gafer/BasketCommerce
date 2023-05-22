﻿using BasketCommerce.Application.Common.Mappings;
using BasketCommerce.Domain.Entities;

namespace BasketCommerce.Application.Common.Models;

// Note: This is currently just used to demonstrate applying multiple IMapFrom attributes.
public class LookupDto : IMapFrom<TodoList>, IMapFrom<TodoItem>
{
    public int Id { get; init; }

    public string? Title { get; init; }
}
