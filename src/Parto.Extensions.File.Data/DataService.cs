using Microsoft.Extensions.Hosting;

using Parto.Extensions.File.Abstractions;
using Parto.Extensions.File.Data.Abstractions;

namespace Parto.Extensions.File.Data;

internal class DataService(IFileService fileService, IHostEnvironment hostEnvironment) : IDataService
{
    public IDataAccess Default { get; }
        = fileService.Access($"{hostEnvironment.ApplicationName}.db").AsData();
}