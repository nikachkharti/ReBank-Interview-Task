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

        public void DecreaseRecomendation(Distributor distributor)
        {
            if (distributor != null)
                distributor.RecomendationsCount -= 1;
        }

        public void IncreaseRecomendation(Distributor distributor)
        {
            if (distributor != null)
                distributor.RecomendationsCount += 1;
        }
    }
}
