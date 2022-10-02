using RedRain.DataAccess.DataTransferObjects;

namespace RedRain.DataAccess.Procedures
{
    internal class StateProcedures
    {
        internal static readonly string FetchAll = SqlGenerator.Fetch(typeof(StateLookupDTO));

        internal static readonly string FetchByIdOrAbbreviation = SqlGenerator.Fetch(typeof(StateLookupDTO),
            whereOverride: "(Id = @Id OR @Id IS NULL) AND (Abbreviation = @Abbreviation OR @Abbreviation IS NULL)");

        internal static readonly string IsValidId = SqlGenerator.SelectExists("StateLookup", "Id = @Id");
    }
}
