using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

using Parto.Extensions.Abstractions;
using Parto.Extensions.File.Abstractions;

using FileOptions = Parto.Extensions.File.Abstractions.FileOptions;

namespace Parto.Extensions.File;

internal class FileBuilder : IFileBuilder
{
    public FileBuilder(IExtensionsBuilder builder)
    {
        ExtensionsBuilder = builder;

        ExtensionsBuilder.Services.TryAddSingleton<IFileService, FileService>();
        ExtensionsBuilder.Services.AddSingletonFactory<FileAccessFactory>();

        OptionsBuilder = ExtensionsBuilder.Services.AddOptions<FileOptions>();
        OptionsBuilder.PostConfigure(options =>
        {
            if (!Directory.Exists(options.Path))
            {
                Directory.CreateDirectory(options.Path);
            }
        });
    }

    public IExtensionsBuilder ExtensionsBuilder { get; }
    public OptionsBuilder<FileOptions> OptionsBuilder { get; }
}