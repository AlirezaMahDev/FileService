using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data.Stack;

internal class StackAccessFactory(IServiceProvider provider)
    : ParameterServiceFactory<StackAccess, IDataLocation>(provider);