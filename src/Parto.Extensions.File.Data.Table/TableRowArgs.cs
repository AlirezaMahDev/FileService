using System.Runtime.InteropServices;

namespace Parto.Extensions.File.Data.Table;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal readonly record struct TableRowArgs(TableRows Rows, int Index);