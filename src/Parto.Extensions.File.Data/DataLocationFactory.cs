namespace Parto.Extensions.File.Data;

internal class DataLocationFactory(IServiceProvider provider, DataAccess access)
    : ParameterServiceFactory<DataLocation, DataLocationArgs>(provider)
{
    public DataLocation GetOrCreate(long parameter)
    {
        return base.GetOrCreate(new(access, parameter));
    }
}