﻿using NetworkManagementAPI.Entities;

namespace NetworkManagementAPI.Repository.Interfaces
{
    public interface IDistributorRepository : IRepositoryBase<Distributor>
    {
        void IncreaseRecomendation(Distributor distributor);
        void DecreaseRecomendation(Distributor distributor);
        Task DecreaseSubRecomendation(Distributor distributor);
        Task IncreaseSubRecomendation(Distributor distributor);
    }
}
