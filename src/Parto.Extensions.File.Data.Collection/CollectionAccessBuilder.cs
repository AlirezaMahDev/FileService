using Parto.Extensions.File.Data.Abstractions;
using Parto.Extensions.File.Data.Collection.Abstractions;

namespace Parto.Extensions.File.Data.Collection;

internal class CollectionAccessBuilder : ICollectionAccessBuilder
{
    public IDataAccessBuilder DataAccessBuilder { get; }

    public CollectionAccessBuilder(IDataAccessBuilder dataAccessBuilder)
    {
        DataAccessBuilder = dataAccessBuilder;
        dataAccessBuilder.FileBuilder.ExtensionsBuilder.Services.AddSingletonFactory<CollectionAccessFactory>();
        dataAccessBuilder.FileBuilder.ExtensionsBuilder.Services.AddSingletonFactory<CollectionObjectFactory>();
        dataAccessBuilder.FileBuilder.ExtensionsBuilder.Services.AddSingletonFactory<CollectionObjectsFactory>();
        dataAccessBuilder.FileBuilder.ExtensionsBuilder.Services.AddSingletonFactory<CollectionPropertiesFactory>();
        dataAccessBuilder.FileBuilder.ExtensionsBuilder.Services.AddSingletonFactory<CollectionPropertyFactory>();
    }
}