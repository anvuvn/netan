using AutoMapper;

namespace netan.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.Make, Controllers.Resources.MakeResource>();
            CreateMap<Models.Model, Controllers.Resources.ModelResource>();
            CreateMap<Models.Feature, Controllers.Resources.FeatureResource>();
        }
    }
}