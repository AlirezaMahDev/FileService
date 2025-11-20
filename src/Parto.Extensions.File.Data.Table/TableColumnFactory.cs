namespace Parto.Extensions.File.Data.Table;

internal class TableColumnFactory(IServiceProvider provider)
    : ParameterServiceFactory<TableColumn, TableColumnArgs>(provider);