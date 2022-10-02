namespace RedRain.Domain.Models
{
    public class Address
    {
        public Address(string? streetLine1, string? streetLine2, string? city, string? state, string? postalCode, Guid guid)
        {
            StreetLine1 = streetLine1 ?? string.Empty;
            StreetLine2 = streetLine2 ?? string.Empty;
            PostalCode = postalCode ?? string.Empty;
            City = city ?? string.Empty;
            State = state ?? string.Empty;
            Guid = guid;
        }

        public string StreetLine1 { get; set; } = string.Empty;

        public string StreetLine2 { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string PostalCode { get; set; } = string.Empty;

        public Guid Guid { get; set; }
    }
}
