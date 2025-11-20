using System.Runtime.InteropServices;

using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Table;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal readonly record struct TableColumnArgs(TableColumns Columns, String64 Key);