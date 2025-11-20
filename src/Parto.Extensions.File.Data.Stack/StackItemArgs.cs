using System.Runtime.InteropServices;

namespace Parto.Extensions.File.Data.Stack;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal readonly record struct StackItemArgs(StackItems Items, int Index)
{
    public StackItems Items { get; } = Items;
    public int Index { get; } = Index;
}