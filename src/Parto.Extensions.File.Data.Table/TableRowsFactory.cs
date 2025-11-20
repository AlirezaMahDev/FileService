namespace Parto.Extensions.File.Data.Table;

internal class TableRowsFactory(IServiceProvider provider)
    : ParameterServiceFactory<TableRows, TableAccess>(provider);