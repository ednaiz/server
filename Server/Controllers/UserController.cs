using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Server.Controllers
{
    public class UserController : ApiController
    {
        public List<UserDTO> Get()
        {
            return  UserService.get();
        }

        public UserDTO Get(int id)
        {
            return UserService.get(id);
        }
        [HttpPost]
        [Route("~/api/user/login")]
        public UserDTO Get(UserLoginDTO user)
        {
            return UserService.get(user);
        }
        [HttpPost]
        public UserDTO Post(UserDTO user)
        {
            return UserService.Post(user);
        }
        [HttpPut]
        public UserDTO Put(UserDTO user)
        {
            return UserService.Put(user);
        }


    }
}
