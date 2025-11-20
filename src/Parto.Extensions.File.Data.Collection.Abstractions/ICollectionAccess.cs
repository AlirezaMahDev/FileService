using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Collection.Abstractions;

public interface ICollectionAccess : IDataLocationItem
{
    ICollectionObjects Objects { get; }
}