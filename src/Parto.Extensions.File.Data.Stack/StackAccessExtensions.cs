using Microsoft.Extensions.DependencyInjection;

using Parto.Extensions.File.Data.Abstractions;
using Parto.Extensions.File.Data.Stack.Abstractions;

namespace Parto.Extensions.File.Data.Stack;

public static class StackAccessExtensions
{
    public static IStackAccess AsStack(this IDataLocation dataLocation)
    {
        return dataLocation.DataAccess.FileAccess.Provider.GetRequiredService<StackAccessFactory>()
            .GetOrCreate(dataLocation);
    }

    public static StackAccess<TEntity> As<TEntity>(this IStackAccess dataLocation)
        where TEntity : unmanaged
    {
        return new(dataLocation);
    }
}