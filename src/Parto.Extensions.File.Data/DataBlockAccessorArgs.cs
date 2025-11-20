using System.Runtime.InteropServices;

using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal record struct DataBlockAccessorArgs(DataBlock DataBlock, DataAddress Address);