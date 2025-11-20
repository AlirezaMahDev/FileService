namespace Parto.Extensions.File.Data.Table;

internal class TableColumnsFactory(IServiceProvider provider)
    : ParameterServiceFactory<TableColumns, TableAccess>(provider);