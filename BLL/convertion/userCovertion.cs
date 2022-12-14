using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convertion
{
    public class UserCovertion
    {
        public static UserDTO Convert(user user)
        {
            if (user == null)
                return null;
            return new UserDTO()
            {
                Email = user.Email,
                Id = user.Id,
                Active = user.Active,
                Name = user.Name,
                Type = user.Type,
                Password = user.Password,
                Phone = user.Phone,
                UserName = user.UserName
            };
        }
        public static List<UserDTO> Convert(List<user> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
        public static List<user> Convert(List<UserDTO> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
        public static user Convert(UserDTO user)
        {
            if (user == null)
                return null;
            return new user()
            {
                Email = user.Email,
                Id = user.Id,
                Active = user.Active,
                Name = user.Name,
                Type = user.Type,
                Password = user.Password,
                Phone = user.Phone,
                UserName = user.UserName
            };
        }
    }
}
