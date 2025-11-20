using System.Runtime.InteropServices;

namespace Parto.Extensions.File.Data.Table.Abstractions;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public record struct TableRowsValue
{
    public int Count;
}