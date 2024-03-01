using AutoMapper;
using netan.Controllers.Resources;
using netan.Models;

namespace netan.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // API Domain to Resource
            CreateMap<Make, MakeResource>();
            CreateMap<Model, ModelResource>();
            CreateMap<Feature, FeatureResource>();
            CreateMap<Vehicle, VehicleResource>()
                .ForMember(vr => vr.Contact, opt => opt.MapFrom(v => new ContactResource() { Name = v.ContactName, Email = v.ContactEmail, Phone = v.ContactPhone }))
                .ForMember(vr => vr.Features, opt => opt.MapFrom(v => v.Features.Select(v => v.Id)));

            // API resource to Domain
            CreateMap<VehicleResource, Vehicle>()
                .ForMember(m => m.ContactName, opt => opt.MapFrom(vr => vr.Contact.Name))
                .ForMember(m => m.ContactEmail, opt => opt.MapFrom(vr => vr.Contact.Email))
                .ForMember(m => m.ContactPhone, opt => opt.MapFrom(vr => vr.Contact.Phone))
                .ForMember(m => m.Features, opt => opt.MapFrom(vr => vr.Features.Select(id => new Feature { Id = id } )));
        }
    }
}