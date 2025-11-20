using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Stack.Abstractions;

public interface IStackAccessBuilder
{
    IDataAccessBuilder DataAccessBuilder { get; }
}