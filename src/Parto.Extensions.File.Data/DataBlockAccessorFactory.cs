namespace Parto.Extensions.File.Data;

internal class DataBlockAccessorFactory(IServiceProvider provider)
    : ParameterServiceFactory<DataBlockAccessor, DataBlockAccessorArgs>(provider);