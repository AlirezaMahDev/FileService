using Parto.Extensions.File.Abstractions;

namespace Parto.Extensions.File.Data.Abstractions;

public interface IDataBlock
{
    IFileAccess FileAccess { get; }
    IDataBlockAccessor Read(DataAddress address);
}