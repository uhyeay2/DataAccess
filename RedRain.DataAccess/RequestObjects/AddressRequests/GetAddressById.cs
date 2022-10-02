using RedRain.DataAccess.Procedures;
using RedRain.DataAccess.RequestObjects._BaseRequests;

namespace RedRain.DataAccess.RequestObjects.AddressRequests
{
    public class GetAddressById : LongIdBasedRequest
    {
        public GetAddressById(long id) : base(id)
        {
        }

        public override string GenerateSql() => AddressProcedures.GetById;
    }
}
