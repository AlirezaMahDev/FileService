using Microsoft.Extensions.DependencyInjection;

using Parto.Extensions.File.Json.Abstractions;
using Parto.Extensions.File.Abstractions;

namespace Parto.Extensions.File.Json;

public static class JsonExtensions
{
    public static IJsonAccess<TEntity> AsJson<TEntity>(this IFileAccess fileAccess)
        where TEntity : class
    {
        return fileAccess.Provider
            .GetRequiredService<JsonAccessFactory<TEntity>>()
            .GetOrCreate(fileAccess);
    }

    extension(IFileBuilder builder)
    {
        public IJsonFileBuilder AddJson()
        {
            return new JsonBuilder(builder);
        }

        public IFileBuilder AddJson(Action<IJsonFileBuilder> action)
        {
            action(AddJson(builder));
            return builder;
        }
    }
}