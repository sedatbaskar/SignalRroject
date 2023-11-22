using AutoMapper;
using SignalR.DtoLayer.ContactDto;
using SignalREntityLayer.Entities;

namespace SignalR.Api.Mapping
{
    public class ContactMapping : Profile
    {

        public ContactMapping()
        {

            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();

        }
    }
}
