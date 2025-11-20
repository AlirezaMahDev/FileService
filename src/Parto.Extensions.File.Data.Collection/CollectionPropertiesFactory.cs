using Parto.Extensions.File.Data.Collection.Abstractions;

namespace Parto.Extensions.File.Data.Collection;

internal class CollectionPropertiesFactory(IServiceProvider provider)
    : ParameterServiceFactory<CollectionProperties, ICollectionObjectBase>(provider);