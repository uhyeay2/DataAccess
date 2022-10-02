using RedRain.DataAccess.DataTransferObjects;
using RedRain.DataAccess.RequestObjects.AddressRequests;
using RedRain.Domain.Models;

namespace RedRain.DataAccess.Repositories
{
    internal class AddressRepository : RepositoryBase, Domain.Interfaces.Repositories.IAddressRepository
    {
        public AddressRepository(Domain.Interfaces.IConfig config) : base(config) { }

        public async Task<Address?> GetAddressByGuidAsync(Guid guid) =>
          (await FetchAsync<GetAddressByGuid, AddressDTO>(new GetAddressByGuid(guid)))?.AsAddress();

        public async Task<Address?> GetAddressByIdAsync(long id) =>
         (await FetchAsync<GetAddressById, AddressDTO>(new GetAddressById(id)))?.AsAddress();

        public async Task<int> InsertAddressAsync(Guid guid, string line1, string line2, string city, int stateId, string postalCode) =>
            await ExecuteAsync(new InsertAddress(guid, line1, line2, city, stateId, postalCode));
    }
}
