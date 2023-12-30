using Microsoft.EntityFrameworkCore;
using NetworkManagementAPI.Entities;
using NetworkManagementAPI.Repository.CustomExceptions;
using NetworkManagementAPI.Repository.Interfaces;
using NetworkManagmentAPI.Data;

namespace NetworkManagementAPI.Repository
{
    public class DistributorRepository : RepositoryBase<Distributor>, IDistributorRepository
    {
        private readonly ApplicationDbContext _context;

        public DistributorRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
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
        public async Task IncreaseSubRecomendation(Distributor distributor)
        {
            if (distributor != null)
            {
                if (distributor.SubRecomendationsCount < 121)
                {
                    distributor.SubRecomendationsCount += 1;
                    //await _context.SaveChangesAsync();

                    await IncreaseAncestrySubRecomendations(distributor.RecomendatorId);
                }
                else
                {
                    throw new IndirectRecomendationLimitException();
                }
            }
        }
        private async Task IncreaseAncestrySubRecomendations(int recomendatorId)
        {
            var recomendator = await _context.Distributors.FirstOrDefaultAsync(x => x.Id == recomendatorId);

            if (recomendator != null)
            {
                if (recomendator.SubRecomendationsCount < 121)
                {
                    recomendator.SubRecomendationsCount += 1;
                    await _context.SaveChangesAsync();

                    await IncreaseAncestrySubRecomendations(recomendator.RecomendatorId);
                }
                else
                {
                    throw new IndirectRecomendationLimitException();
                }
            }
        }
        public async Task DecreaseSubRecomendation(Distributor distributor)
        {
            if (distributor != null)
            {
                distributor.SubRecomendationsCount -= 1;
                await _context.SaveChangesAsync();

                await DecreaseAncestrySubRecomendations(distributor.RecomendatorId);
            }
        }
        private async Task DecreaseAncestrySubRecomendations(int recomendatorId)
        {
            var recomendator = await _context.Distributors.FirstOrDefaultAsync(x => x.Id == recomendatorId);

            if (recomendator != null)
            {
                recomendator.SubRecomendationsCount -= 1;
                await _context.SaveChangesAsync();

                await DecreaseAncestrySubRecomendations(recomendator.RecomendatorId);
            }
        }
    }
}
