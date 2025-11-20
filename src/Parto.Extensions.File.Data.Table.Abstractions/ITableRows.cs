using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Table.Abstractions;

public interface ITableRows : IDataLocationItem<TableRowsValue>, IDataCollection<ITableRow>
{
    ITableAccess Table { get; }
}