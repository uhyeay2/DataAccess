using RedRain.DataAccess.Procedures;
using RedRain.DataAccess.RequestObjects._BaseRequests;

namespace RedRain.DataAccess.RequestObjects.AddressRequests
{
    public class GetAddressByGuid : GuidBasedRequest
    {
        public GetAddressByGuid(Guid guid) : base(guid) { }

        public override string GenerateSql() => AddressProcedures.GetByGuid;
    }
}
