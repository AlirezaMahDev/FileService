namespace Parto.Extensions.File.Data.Stack;

internal class StackItemFactory(IServiceProvider provider)
    : ParameterServiceFactory<StackItem, StackItemArgs>(provider);