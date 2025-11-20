using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Collection.Abstractions;

public interface ICollectionObjects : IDataLocationItem<CollectionObjectsValue>, IDataCollection<ICollectionObject>
{
    ICollectionAccess Access { get; }
}