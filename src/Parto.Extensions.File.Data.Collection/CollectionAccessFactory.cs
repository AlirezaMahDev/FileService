using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Collection;

internal class CollectionAccessFactory(IServiceProvider provider)
    : ParameterServiceFactory<CollectionAccess, IDataLocation>(provider);