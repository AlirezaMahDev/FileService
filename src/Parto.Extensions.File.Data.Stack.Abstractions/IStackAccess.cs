using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Stack.Abstractions;

public interface IStackAccess : IDataLocationItem
{
    IStackItems Items { get; }
    int Size { get; set; }
}