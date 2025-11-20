namespace Parto.Extensions.File.Data.Stack;

internal class StackItemsFactory(IServiceProvider provider)
    : ParameterServiceFactory<StackItems, StackAccess>(provider);