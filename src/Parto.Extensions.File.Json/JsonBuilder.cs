using Parto.Extensions.File.Json.Abstractions;
using Parto.Extensions.File.Abstractions;

namespace Parto.Extensions.File.Json;

internal class JsonBuilder : IJsonFileBuilder
{
    public IFileBuilder FileBuilder { get; }

    public JsonBuilder(IFileBuilder fileBuilder)
    {
        FileBuilder = fileBuilder;
        FileBuilder.ExtensionsBuilder.Services.AddSingletonFactory(typeof(JsonAccessFactory<>));
    }
}