using AutoMapper;

namespace template_dotnet6_api
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            /*
            * CreateMap<SampleMessage, ExampleModels>()
            *     .ForMember(_ => _.ExampleName, _ => _.MapFrom(_ => _.Name))
            *     .ReverseMap();
            * 
            * CreateMap<ExampleModels, GetExampleReponseDto>();
            */
        }
    }
}
