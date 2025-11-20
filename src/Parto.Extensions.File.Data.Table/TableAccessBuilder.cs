using Parto.Extensions.File.Data.Abstractions;
using Parto.Extensions.File.Data.Collection;
using Parto.Extensions.File.Data.Stack;
using Parto.Extensions.File.Data.Table.Abstractions;

namespace Parto.Extensions.File.Data.Table;

internal class TableAccessBuilder : ITableAccessBuilder
{
    public IDataAccessBuilder DataAccessBuilder { get; }

    public TableAccessBuilder(IDataAccessBuilder dataAccessBuilder)
    {
        DataAccessBuilder = dataAccessBuilder;
        dataAccessBuilder.FileBuilder.AddData(builder =>
        {
            builder.AddStack();
            builder.AddCollection();
        });
        dataAccessBuilder.FileBuilder.ExtensionsBuilder.Services.AddSingletonFactory<TableAccessFactory>();
        dataAccessBuilder.FileBuilder.ExtensionsBuilder.Services.AddSingletonFactory<TableColumnFactory>();
        dataAccessBuilder.FileBuilder.ExtensionsBuilder.Services.AddSingletonFactory<TableColumnsFactory>();
        dataAccessBuilder.FileBuilder.ExtensionsBuilder.Services.AddSingletonFactory<TableRowsFactory>();
        dataAccessBuilder.FileBuilder.ExtensionsBuilder.Services.AddSingletonFactory<TableRowFactory>();
    }
}