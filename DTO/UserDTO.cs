﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserLoginDTO
    {
        public string Password { get; set; }
        public string UserName { get; set; }
    }
        public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Type { get; set; }
        public Nullable<bool> Active { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}
