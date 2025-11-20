namespace Parto.Extensions.File.Data.Table;

internal class TableRowFactory(IServiceProvider provider)
    : ParameterServiceFactory<TableRow, TableRowArgs>(provider);