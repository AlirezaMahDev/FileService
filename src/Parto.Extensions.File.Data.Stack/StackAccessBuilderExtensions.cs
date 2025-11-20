using Parto.Extensions.File.Data.Abstractions;
using Parto.Extensions.File.Data.Stack.Abstractions;

namespace Parto.Extensions.File.Data.Stack;

public static class StackAccessBuilderExtensions
{
    extension(IDataAccessBuilder databaseBuilder)
    {
        public IStackAccessBuilder AddStack()
        {
            return new StackAccessBuilder(databaseBuilder);
        }

        public IDataAccessBuilder AddStack(Action<IStackAccessBuilder> action)
        {
            action(AddStack(databaseBuilder));
            return databaseBuilder;
        }
    }
}