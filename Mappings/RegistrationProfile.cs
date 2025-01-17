using AutoMapper;
using IdentityUserRegistration.DTO;
using IdentityUserRegistration.Entities;

namespace IdentityUserRegistration.Mappings
{
    public class RegistrationProfile : Profile
    {
        public RegistrationProfile() {
            CreateMap<UserForRegistrationDTO, User>().ForMember(dest=> dest.UserName, option=>option.MapFrom(sourc=> sourc.Email));
            
        }
    }
}
