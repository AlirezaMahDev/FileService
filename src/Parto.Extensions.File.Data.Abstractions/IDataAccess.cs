using Parto.Extensions.File.Abstractions;

namespace Parto.Extensions.File.Data.Abstractions;

public interface IDataAccess
{
    IFileAccess FileAccess { get; }
    IDataLocation Root { get; }
}