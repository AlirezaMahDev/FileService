using Microsoft.Extensions.DependencyInjection.Extensions;

using Parto.Extensions.File.Abstractions;
using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data;

internal class DataAccessBuilder : IDataAccessBuilder
{
    public DataAccessBuilder(IFileBuilder fileBuilder)
    {
        FileBuilder = fileBuilder;
        fileBuilder.ExtensionsBuilder.Services.TryAddSingleton<IDataService, DataService>();
        fileBuilder.ExtensionsBuilder.Services.TryAddSingleton<DataAccessFactory>();
    }

    public IFileBuilder FileBuilder { get; }
}