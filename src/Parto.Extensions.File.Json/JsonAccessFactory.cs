using Parto.Extensions.File.Abstractions;

namespace Parto.Extensions.File.Json;

internal class JsonAccessFactory<TEntity>(IServiceProvider provider)
    : ParameterServiceFactory<JsonAccess<TEntity>, IFileAccess>(provider)
    where TEntity : class;