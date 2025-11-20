using System.Runtime.InteropServices;

namespace Parto.Extensions.File.Data.Collection.Abstractions;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public record struct CollectionObjectsValue
{
    public int Count;
}