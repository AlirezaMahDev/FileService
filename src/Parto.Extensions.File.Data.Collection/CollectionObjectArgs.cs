using System.Runtime.InteropServices;

namespace Parto.Extensions.File.Data.Collection;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal readonly record struct CollectionObjectArgs(CollectionObjects Objects, int Index);