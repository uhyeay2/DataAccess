using RedRain.DataAccess.Attributes.SQLGeneration.InsertAttributes;
using RedRain.DataAccess.Procedures;
using RedRain.DataAccess.RequestObjects._BaseRequests;

namespace RedRain.DataAccess.RequestObjects.AddressRequests
{
    [InsertQuery("Address")]
    public class InsertAddress : GuidBasedRequest
    {

        [Insertable("Address")]
        public override Guid? Guid { get; set; }

        [Insertable("Address")]
        public string Line1 { get; set; }

        [Insertable("Address")]
        public string Line2 { get; set; }

        [Insertable("Address")]
        public string City { get; set; }

        [Insertable("Address")]
        public int StateId { get; set; }

        [Insertable("Address")]
        public string PostalCode { get; set; }

        public InsertAddress(Guid guid, string line1, string line2, string city, int stateId, string postalCode) : base(guid)
        {
            Line1 = line1;
            Line2 = line2;
            City = city;
            StateId = stateId;
            PostalCode = postalCode;
        }

        public InsertAddress(string guid, string line1, string line2, string city, int stateId, string postalCode) : base(guid)
        {
            Line1 = line1;
            Line2 = line2;
            City = city;
            StateId = stateId;
            PostalCode = postalCode;
        }

        public override object? GenerateParameters() => new { Guid, Line1, Line2, City, StateId, PostalCode };

        public override string GenerateSql() => AddressProcedures.Insert;
    }
}
