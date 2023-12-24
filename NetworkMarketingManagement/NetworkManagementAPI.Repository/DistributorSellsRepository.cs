using NetworkManagementAPI.Entities;
using NetworkManagementAPI.Repository.Interfaces;
using NetworkManagmentAPI.Data;

namespace NetworkManagementAPI.Repository
{
    public class DistributorSellsRepository : RepositoryBase<DistributorSell>, IDistributorSellsRepository
    {
        public DistributorSellsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
