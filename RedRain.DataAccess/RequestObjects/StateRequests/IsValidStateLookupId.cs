using RedRain.DataAccess.Procedures;
using RedRain.DataAccess.RequestObjects._BaseRequests;

namespace RedRain.DataAccess.RequestObjects.StateRequests
{
    internal class IsValidStateLookupId : IdBasedRequest
    {
        public override string GenerateSql() => StateProcedures.IsValidId;
    }
}
