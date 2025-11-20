using Parto.Extensions.File.Abstractions;

namespace Parto.Extensions.File.Data.Abstractions;

public interface IDataAccessBuilder
{
    IFileBuilder FileBuilder { get; }
}