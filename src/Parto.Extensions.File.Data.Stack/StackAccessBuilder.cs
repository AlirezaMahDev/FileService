using Parto.Extensions.File.Data.Abstractions;
using Parto.Extensions.File.Data.Stack.Abstractions;

namespace Parto.Extensions.File.Data.Stack;

internal class StackAccessBuilder : IStackAccessBuilder
{
    public IDataAccessBuilder DataAccessBuilder { get; }

    public StackAccessBuilder(IDataAccessBuilder dataAccessBuilder)
    {
        DataAccessBuilder = dataAccessBuilder;
        dataAccessBuilder.FileBuilder.ExtensionsBuilder.Services.AddSingletonFactory<StackAccessFactory>();
        dataAccessBuilder.FileBuilder.ExtensionsBuilder.Services.AddSingletonFactory<StackItemFactory>();
        dataAccessBuilder.FileBuilder.ExtensionsBuilder.Services.AddSingletonFactory<StackItemsFactory>();
    }
}