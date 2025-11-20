namespace Parto.Extensions.File.Data.Collection;

internal class CollectionPropertyFactory(IServiceProvider provider)
    : ParameterServiceFactory<CollectionProperty, CollectionPropertyArgs>(provider);