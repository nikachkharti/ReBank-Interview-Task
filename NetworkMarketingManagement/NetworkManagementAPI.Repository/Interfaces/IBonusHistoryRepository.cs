using NetworkManagementAPI.Entities;

namespace NetworkManagementAPI.Repository.Interfaces
{
    public interface IBonusHistoryRepository : IRepositoryBase<BonusHistory>
    {
        Task CalculateBonuses(int distributorId);
    }
}
