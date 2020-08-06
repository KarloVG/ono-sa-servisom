using AutoMapper;
using Protests.Api.Requests;
using Protests.Data.Entities;

namespace Protests.Api.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegistrationRequest, AppUser>().ReverseMap();
        }
    }
}
