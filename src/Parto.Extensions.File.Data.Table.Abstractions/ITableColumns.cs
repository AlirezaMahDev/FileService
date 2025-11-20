using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Table.Abstractions;

public interface ITableColumns : IDataLocationItem, IDataDictionary<String64, ITableColumn>;