using BasketCommerce.Application.Common.Interfaces;

namespace BasketCommerce.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
