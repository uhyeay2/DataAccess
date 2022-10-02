using RedRain.DataAccess.Procedures;
using RedRain.DataAccess.RequestObjects._BaseRequests;

namespace RedRain.DataAccess.RequestObjects.StateRequests
{
    internal class GetStateEitherByIdOrAbbreviation : EitherByIntOrString
    {
        public GetStateEitherByIdOrAbbreviation(int? left) : base(left)
        {
        }

        public GetStateEitherByIdOrAbbreviation(string? right) : base(right)
        {
        }

        public override string GenerateSql() => StateProcedures.FetchByIdOrAbbreviation;        
    }
}
