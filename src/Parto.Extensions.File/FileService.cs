using Parto.Extensions.File.Abstractions;

namespace Parto.Extensions.File;

internal class FileService(FileAccessFactory fileAccessFactory) : IFileService
{
    public IFileAccess Access(string name)
    {
        return fileAccessFactory.GetOrCreate(name);
    }
}