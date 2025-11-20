using Parto.Extensions.File.Abstractions;

namespace Parto.Extensions.File.Json.Abstractions;

public interface IJsonFileBuilder
{
    IFileBuilder FileBuilder { get; }
}