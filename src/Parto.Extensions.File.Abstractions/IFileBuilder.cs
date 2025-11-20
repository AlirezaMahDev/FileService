using Microsoft.Extensions.Options;

using Parto.Extensions.Abstractions;

namespace Parto.Extensions.File.Abstractions;

public interface IFileBuilder
{
    IExtensionsBuilder ExtensionsBuilder { get; }
    OptionsBuilder<FileOptions> OptionsBuilder { get; }
}