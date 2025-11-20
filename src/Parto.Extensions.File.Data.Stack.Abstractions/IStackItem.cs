using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Stack.Abstractions;

public interface IStackItem : IDataCollectionItem<StackItemValue>
{
    DataBlockMemory Data { get; }
}