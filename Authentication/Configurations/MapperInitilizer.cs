using Authentication.Data;
using Authentication.Models;
using AutoMapper;

namespace Authentication.Configurations
{
    public class MapperInitilizer : Profile
    {

        public MapperInitilizer() 
        {
            CreateMap<ApiUser, UserDTO>().ReverseMap();
        }
    }
}
