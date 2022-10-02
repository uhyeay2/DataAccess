using RedRain.Domain.Models;

namespace RedRain.Domain.Interfaces.Repositories
{
    public interface IAddressRepository
    {
        Task<Address?> GetAddressByGuidAsync(Guid guid);

        Task<Address?> GetAddressByIdAsync(long id);

        Task<int> InsertAddressAsync(Guid guid, string line1, string line2, string city, int stateId, string postalCode);
    }
}
