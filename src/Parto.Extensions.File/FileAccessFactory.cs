namespace Parto.Extensions.File;

internal class FileAccessFactory(IServiceProvider provider)
    : ParameterServiceFactory<FileAccess, string>(provider);