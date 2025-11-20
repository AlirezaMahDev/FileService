using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Collection.Abstractions;

public readonly struct CollectionAccess<TEntity>(ICollectionAccess access) : IDataBlockAccessorSave
    where TEntity : class
{
    public ICollectionAccess Access { get; } = access;

    public CollectionObjects<TEntity> Items { get; } = access.Objects.As<TEntity>();
    public void Save()
    {
        Access.Save();
    }
}