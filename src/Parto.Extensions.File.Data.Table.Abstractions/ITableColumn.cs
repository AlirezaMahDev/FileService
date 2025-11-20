using Parto.Extensions.File.Data.Abstractions;
using Parto.Extensions.File.Data.Stack.Abstractions;

namespace Parto.Extensions.File.Data.Table.Abstractions;

public interface ITableColumn : IDataLocationItem<TableColumnValue>
{
    ITableColumns Columns { get; }
    IStackAccess Stack { get; }
    int Size { get; set; }
}