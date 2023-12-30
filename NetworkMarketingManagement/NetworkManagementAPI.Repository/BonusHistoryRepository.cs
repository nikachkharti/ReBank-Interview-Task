using Microsoft.EntityFrameworkCore;
using NetworkManagementAPI.Entities;
using NetworkManagementAPI.Repository.Interfaces;
using NetworkManagmentAPI.Data;

namespace NetworkManagementAPI.Repository
{
    public class BonusHistoryRepository : RepositoryBase<BonusHistory>, IBonusHistoryRepository
    {
        private readonly ApplicationDbContext _context;
        public BonusHistoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task CalculateBonuses(int distributorId)
        {
            List<DistributorSell> unprocessedChildrenSales = new();

            List<DistributorSell> unprocessedSales = await _context.DistributorSells
                .Where(x => x.DistributorId == distributorId && x.IsProcessed == false)
                .Include(s => s.Distributor)
                .ToListAsync();

            var recomendedChildren = await GetAllRecommendedDistributors(distributorId);

            if (recomendedChildren.Count() > 0)
            {
                foreach (var recomendedChild in recomendedChildren)
                {
                    unprocessedChildrenSales = await _context.DistributorSells
                        .Where(x => x.Distributor.RecomendatorId == recomendedChild.RecomendatorId && x.IsProcessed == false)
                        .ToListAsync();
                }
            }

            //BONUS FOR DIRECT SELLED PRODUCTS FOR distributorId - 10%
            if (unprocessedSales.Count() != 0)
            {
                foreach (var sale in unprocessedSales)
                {
                    decimal saleBonus = sale.TotalPrice * 10 / 100;
                    sale.IsProcessed = true;

                    await _context.BonusHistories.AddAsync(new BonusHistory
                    {
                        DistributorId = sale.DistributorId,
                        SaleId = sale.Id,
                        BonusAmount = saleBonus,
                        DateCalculated = DateTime.UtcNow
                    });
                }
            }

            //BONUS FOR CHILDREN SELLED PRODUCTS FOR distributorId - 5%
            if (unprocessedChildrenSales.Count() != 0)
            {
                foreach (var sale in unprocessedChildrenSales)
                {
                    decimal saleBonus = sale.TotalPrice * 5 / 100;
                    sale.IsProcessed = true;

                    await _context.BonusHistories.AddAsync(new BonusHistory
                    {
                        DistributorId = distributorId,
                        SaleId = sale.Id,
                        BonusAmount = saleBonus,
                        DateCalculated = DateTime.UtcNow
                    });
                }
            }

            await _context.SaveChangesAsync();
        }

        private async Task<List<Distributor>> GetAllRecommendedDistributors(int distributorId) => await _context.Distributors.Where(x => x.RecomendatorId == distributorId).ToListAsync();
    }
}
