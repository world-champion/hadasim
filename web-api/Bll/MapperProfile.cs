using Dto;
using Entity;
using AutoMapper;
namespace Bll
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
        CreateMap<User, UserDto>();

        CreateMap<UserDto, User>();

        CreateMap<CoronaDetails, CoronaDtailseDto>();

        CreateMap<CoronaDtailseDto, CoronaDetails>();

        CreateMap<CoronaVaccine, CoronaVaccineDto>();

        CreateMap<CoronaVaccineDto, CoronaVaccine>();
        }
        
       

    }
}