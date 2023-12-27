using AutoMapper;
using NetworkManagementAPI.Entities;
using NetworkManagementAPI.Models;

namespace NetworkMarketingManagement.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Distributor, DistributorDTO>();
            CreateMap<Distributor, GetDistributorDTOForSelling>();
            CreateMap<AddDistributorDTO, Distributor>();

            CreateMap<Address, GetAddressDTO>();
            CreateMap<AddAddressDTO, Address>();

            CreateMap<ContactInfo, GetContactInfoDTO>();
            CreateMap<AddContactInfoDTO, ContactInfo>();

            CreateMap<PersonalIdentifier, GetPersonalIdentifierDTO>();
            CreateMap<AddPersonalIdentifierDTO, PersonalIdentifier>();

            CreateMap<Product, GetProductDTO>();
            CreateMap<AddProductDTO, Product>();

            CreateMap<DistributorSell, GetDistributorSellDTO>();
            CreateMap<AddDistributorSellDTO, DistributorSell>();

        }
    }
}
