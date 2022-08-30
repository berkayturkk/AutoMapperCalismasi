using Auto_Mapper_Calısması.Models;
using AutoMapper;

namespace Auto_Mapper_Calısması.MapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserInfoDto>()
                .ForMember(destination => destination.Name, operation => operation.MapFrom(source => source.FirstName + " " + source.LastName))
                .ForMember(destination => destination.Status, operation => operation.MapFrom(source => ((UserStatusEnum)source.Status).ToString()));
        }
    }
}
