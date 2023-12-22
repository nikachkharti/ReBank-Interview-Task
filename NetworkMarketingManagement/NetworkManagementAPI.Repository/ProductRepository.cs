using NetworkManagementAPI.Entities;
using NetworkManagementAPI.Repository.Interfaces;
using NetworkManagmentAPI.Data;

namespace NetworkManagementAPI.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
