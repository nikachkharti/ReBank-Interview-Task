using NetworkManagementAPI.Entities;
using NetworkManagementAPI.Repository.Interfaces;
using NetworkManagmentAPI.Data;

namespace NetworkManagementAPI.Repository
{
    public class PersonalIdentifierRepository : RepositoryBase<PersonalIdentifier>, IPersonalIdentifierRepository
    {
        public PersonalIdentifierRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
