using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Stack.Abstractions;

public interface IStackItems : IDataLocationItem, IDataCollection<IStackItem>
{
    IStackAccess StackAccess { get; }
}