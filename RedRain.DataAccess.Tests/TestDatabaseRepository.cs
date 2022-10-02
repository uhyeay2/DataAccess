using RedRain.DataAccess.Interfaces;
using RedRain.DataAccess.RequestObjects._BaseRequests;
using RedRain.Domain.Interfaces;

namespace RedRain.DataAccess.Tests
{
    internal class TestDatabaseRepository : RepositoryBase
    {
        internal TestDatabaseRepository(IConfig config, string configKeyName) : base(config, configKeyName)
        {
        }

        internal TestDatabaseRepository(IConfig config) : base(config)
        {
        }

        public static class ClearTable
        {
            public class Address : ParameterlessRequest, IRequestObject
            {
                public override string GenerateSql() => "DELETE FROM Address";
            }
        }

        public async Task ClearTables()
        {
            await ExecuteAsync(new ClearTable.Address());
        }
    }
}
