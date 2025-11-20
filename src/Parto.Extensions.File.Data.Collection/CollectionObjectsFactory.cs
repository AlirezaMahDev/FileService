namespace Parto.Extensions.File.Data.Collection;

internal class CollectionObjectsFactory(IServiceProvider provider)
    : ParameterServiceFactory<CollectionObjects, CollectionAccess>(provider);