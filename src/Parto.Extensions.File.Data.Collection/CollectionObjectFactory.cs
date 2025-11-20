namespace Parto.Extensions.File.Data.Collection;

internal class CollectionObjectFactory(IServiceProvider provider)
    : ParameterServiceFactory<CollectionObject, CollectionObjectArgs>(provider);