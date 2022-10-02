namespace RedRain.Domain.Interfaces
{
    public interface IConfig
    {
        string GetConnectionString(string connectionStringName);
    }
}
