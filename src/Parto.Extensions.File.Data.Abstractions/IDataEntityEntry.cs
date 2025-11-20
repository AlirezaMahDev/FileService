using System.Linq.Expressions;
using System.Reflection;

namespace Parto.Extensions.File.Data.Abstractions;

public interface IDataEntityEntry
{
    string Name { get; }
    int Size { get; }
    Type ValueType { get; }

    PropertyInfo PropertyInfo { get; }
    MemberAssignment MemberAssignment { get; }
}