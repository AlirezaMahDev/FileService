using Parto.Extensions.File.Abstractions;

namespace Parto.Extensions.File.Data;

internal class DataAccessFactory(IServiceProvider provider)
    : ParameterServiceFactory<DataAccess, IFileAccess>(provider);