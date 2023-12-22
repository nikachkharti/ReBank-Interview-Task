using NetworkManagementAPI.Entities;
using NetworkManagementAPI.Repository.Interfaces;
using NetworkManagmentAPI.Data;

namespace NetworkManagementAPI.Repository
{
    public class ContactInfoRepository : RepositoryBase<ContactInfo>, IContactInfoRepository
    {
        public ContactInfoRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
