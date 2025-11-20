using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Table.Abstractions;

public interface ITableAccessBuilder
{
    IDataAccessBuilder DataAccessBuilder { get; }
}