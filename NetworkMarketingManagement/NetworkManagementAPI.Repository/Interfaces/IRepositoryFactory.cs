namespace NetworkManagementAPI.Repository.Interfaces
{
    public interface IRepositoryFactory
    {
        public IDistributorRepository Distributor { get; }
        public IAddressRepository Address { get; }
        public IContactInfoRepository ContactInfo { get; }
        public IPersonalIdentifierRepository PersonalIdentifier { get; }
        public IProductRepository Product { get; }
        public IDistributorSellsRepository DistributorSells { get; }
        public IBonusHistoryRepository BonusHistory { get; }
        Task Save();
    }
}
