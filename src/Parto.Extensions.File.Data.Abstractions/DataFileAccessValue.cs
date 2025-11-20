using System.Runtime.InteropServices;

namespace Parto.Extensions.File.Data.Abstractions;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public record struct DataFileAccessValue
{
    public long Last;
}