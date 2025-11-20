using System.Runtime.InteropServices;

namespace Parto.Extensions.File.Data.Stack.Abstractions;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public record struct StackItemsValue
{
    public int Count;
}