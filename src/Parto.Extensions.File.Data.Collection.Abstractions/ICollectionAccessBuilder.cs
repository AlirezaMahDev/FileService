using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Collection.Abstractions;

public interface ICollectionAccessBuilder
{
    IDataAccessBuilder DataAccessBuilder { get; }
}