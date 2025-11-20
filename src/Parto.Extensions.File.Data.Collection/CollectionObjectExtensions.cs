using Microsoft.Extensions.DependencyInjection;

using Parto.Extensions.File.Data.Abstractions;
using Parto.Extensions.File.Data.Collection.Abstractions;

namespace Parto.Extensions.File.Data.Collection;

public static class CollectionObjectExtensions
{
    public static ICollectionObjectBase AsObject(this IDataLocation location)
    {
        return ActivatorUtilities.CreateInstance<CollectionObjectBase>(location.DataAccess.FileAccess.Provider,
            location);
    }
}