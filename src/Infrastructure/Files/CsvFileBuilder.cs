using System.Globalization;
using BasketCommerce.Application.Common.Interfaces;
using BasketCommerce.Application.TodoLists.Queries.ExportTodos;
using BasketCommerce.Infrastructure.Files.Maps;
using CsvHelper;

namespace BasketCommerce.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
