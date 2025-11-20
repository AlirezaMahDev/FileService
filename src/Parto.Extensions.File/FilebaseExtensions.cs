using Parto.Extensions.Abstractions;
using Parto.Extensions.File.Abstractions;

namespace Parto.Extensions.File;

public static class FilebaseExtensions
{
    extension(IExtensionsBuilder builder)
    {
        public IFileBuilder AddFileService()
        {
            return new FileBuilder(builder);
        }

        public IExtensionsBuilder AddFileService(Action<IFileBuilder> action)
        {
            action(AddFileService(builder));
            return builder;
        }
    }
}