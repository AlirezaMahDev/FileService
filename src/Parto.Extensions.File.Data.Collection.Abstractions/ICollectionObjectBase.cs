using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Collection.Abstractions;

public interface ICollectionObjectBase : IDataLocationItem<CollectionObjectValue>, IDataCollectionItemBase
{
    ICollectionProperties Properties { get; }
}