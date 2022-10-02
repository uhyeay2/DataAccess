using RedRain.DataAccess.Interfaces;
using RedRain.DataAccess.RequestObjects.AddressRequests;
using RedRain.DataAccess.Repositories;
using RedRain.Domain.Interfaces.Repositories;
using RedRain.Domain.Interfaces;
using Moq;

namespace RedRain.DataAccess.Tests.RepositoryTests
{
    [TestFixture]
    public class AddressRepositoryTests
    {
        private IAddressRepository _addressRepository { get; set; }

        private Mock<IConfig> _mockedConfig = new();


        public AddressRepositoryTests()
        {
            _mockedConfig.Setup(_ => _.GetConnectionString(It.IsAny<string>())).Returns(Hidden.TestEnvDatabaseConnectionString);
            _addressRepository = new AddressRepository(_mockedConfig.Object);
        }

        [Test]
        public async Task InsertAddress_Should_ReturnOne_WhenAddressIsInserted() =>
            Assert.That(await _addressRepository.InsertAddressAsync(Guid.NewGuid(), "Line1", "Line2", "City", stateId: 1, "PostalCode"), Is.EqualTo(1));

    }
}
