using AutoMapper;
using Owl.UniverseBag.Application.DTO.AccountModule;
using Owl.UniverseBag.Domain;

namespace Owl.UniverseBag.Application.MapperConfiguration
{
    public class AccountProfile : Profile,IProfile
    {
        public AccountProfile(IMapperConfigurationExpression config)
        {
            config.CreateMap<User, UserDto>();
        }
    }
}
