using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Table;

internal class TableAccessFactory(IServiceProvider provider)
    : ParameterServiceFactory<TableAccess, IDataLocation>(provider);