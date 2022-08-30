using Auto_Mapper_Calısması.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Auto_Mapper_Calısması.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpGet]
        public UserInfoDto Get()
        {
            var user = new User
            {
                Id = 0,
                FirstName = "Harun",
                LastName = "Şen",
                Status = 1
            };
            
            var userInfo = _mapper.Map<UserInfoDto>(user);
            return userInfo;
        }
    }
}
