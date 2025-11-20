using Microsoft.Extensions.DependencyInjection;

using Parto.Extensions.File.Data.Abstractions;
using Parto.Extensions.File.Data.Collection.Abstractions;

namespace Parto.Extensions.File.Data.Collection;

public static class CollectionAccessExtensions
{
    public static ICollectionAccess AsCollection(this IDataLocation location)
    {
        return location.DataAccess.FileAccess.Provider.GetRequiredService<CollectionAccessFactory>()
            .GetOrCreate(location);
    }
}