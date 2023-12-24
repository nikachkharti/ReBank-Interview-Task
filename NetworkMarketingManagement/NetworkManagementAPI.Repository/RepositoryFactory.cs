using Microsoft.EntityFrameworkCore;
using NetworkManagementAPI.Repository.Interfaces;
using NetworkManagmentAPI.Data;

namespace NetworkManagementAPI.Repository
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IDistributorRepository Distributor { get; private set; }
        public IAddressRepository Address { get; private set; }
        public IContactInfoRepository ContactInfo { get; private set; }
        public IPersonalIdentifierRepository PersonalIdentifier { get; private set; }
        public IProductRepository Product { get; private set; }
        public IDistributorSellsRepository DistributorSells { get; private set; }

        private readonly ApplicationDbContext _context;

        public RepositoryFactory(ApplicationDbContext context)
        {
            _context = context;
            Distributor = new DistributorRepository(_context);
            Address = new AddressRepository(_context);
            ContactInfo = new ContactInfoRepository(_context);
            PersonalIdentifier = new PersonalIdentifierRepository(_context);
            Product = new ProductRepository(_context);
            DistributorSells = new DistributorSellsRepository(_context);
        }

        public async Task Save() => await _context.SaveChangesAsync();
    }
}
