using NetworkManagementAPI.Entities;
using NetworkManagementAPI.Repository.Interfaces;
using NetworkManagmentAPI.Data;

namespace NetworkManagementAPI.Repository
{
    public class DistributorRepository : RepositoryBase<Distributor>, IDistributorRepository
    {
        public DistributorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
