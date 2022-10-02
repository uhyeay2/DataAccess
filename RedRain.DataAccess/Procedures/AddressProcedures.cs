using RedRain.DataAccess.DataTransferObjects;
using RedRain.DataAccess.RequestObjects.AddressRequests;

namespace RedRain.DataAccess.Procedures
{
    internal static class AddressProcedures
    {
        internal static string GetById = SqlGenerator.Fetch(typeof(AddressDTO));
        internal static string GetByGuid = SqlGenerator.Fetch(typeof(AddressDTO), whereOverride: "Guid = @Guid");
        internal static string Insert = SqlGenerator.Insert(typeof(InsertAddress));
    }
}
