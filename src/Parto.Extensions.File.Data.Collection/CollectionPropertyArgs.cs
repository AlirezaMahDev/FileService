using System.Runtime.InteropServices;

using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Collection;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal readonly record struct CollectionPropertyArgs(CollectionProperties Properties, String64 Key);