using Microsoft.Extensions.DependencyInjection;

using Parto.Extensions.File.Abstractions;
using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data;

public static class DataAccessExtensions
{
    public static IDataAccess AsData(this IFileAccess fileAccess)
    {
        return fileAccess.Provider
            .GetRequiredService<DataAccessFactory>()
            .GetOrCreate(fileAccess);
    }

    extension(IFileBuilder builder)
    {
        public IDataAccessBuilder AddData()
        {
            return new DataAccessBuilder(builder);
        }

        public IFileBuilder AddData(Action<IDataAccessBuilder> action)
        {
            action(AddData(builder));
            return builder;
        }
    }
}