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
    public class CustomerController : ApiController
    {
        public List<UserDTOO> Get()
        {
            return  UserService.get();
        }

        public UserDTOO Get(int id)
        {
            return UserService.get(id);
        }

        public UserDTOO Get(string userName,string password)
        {
            return UserService.get(userName,password);
        }
        [HttpPost]
        public UserDTOO Post(UserDTOO user)
        {
            return UserService.Post(user);
        }
        [HttpPut]
        public UserDTOO Put(UserDTOO user)
        {
            return UserService.Put(user);
        }


    }
}
