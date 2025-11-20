using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Table.Abstractions;

public interface ITableAccess : IDataLocationItem
{
    ITableColumns Columns { get; }
    ITableRows Rows { get; }
}