using Microsoft.Extensions.DependencyInjection;

using Parto.Extensions.File.Data.Abstractions;
using Parto.Extensions.File.Data.Table.Abstractions;

namespace Parto.Extensions.File.Data.Table;

public static class TableAccessExtensions
{
    public static ITableAccess AsTable(this IDataLocation dataLocation)
    {
        return dataLocation.DataAccess.FileAccess.Provider.GetRequiredService<TableAccessFactory>()
            .GetOrCreate(dataLocation);
    }
}