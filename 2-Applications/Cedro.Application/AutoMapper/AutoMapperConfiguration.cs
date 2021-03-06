using AutoMapper;

namespace Cedro.Application.AutoMapper
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(x => { 
              x.AddProfile(new DomainToViewModelMappingProfile());
              x.AddProfile(new ViewModelToDomainMappingProfile());
             });
        }
    }
}