using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Table;

internal record struct TableDataArgs(TableRow Row, int Index, String64 Key);