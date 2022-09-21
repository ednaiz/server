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
        public static UserDTO Covert(User user)
        {
            if (user == null)
                return null;
            return new UserDTO()
            {
                City = user.City,
                Email = user.Email,
                Id = user.Id,
                FName = user.FName,
                password = user.password,
                Phone = user.Phone,
                Status = user.Status,
                UserName = user.UserName
            };
        }
        public static List<UserDTO> Covert(List<User> user)
        {
            return user.Select(x => Covert(x)).ToList();
        }
        public static List<User> Covert(List<UserDTO> user)
        {
            return user.Select(x => Covert(x)).ToList();
        }
        public static User Covert(UserDTO user)
        {
            if (user == null)
                return null;
            return new User()
            {
                City = user.City,
                Email = user.Email,
                Id = user.Id,
                FName = user.FName,
                password = user.password,
                //Phone = user.Phone,
                Status = user.Status,
                UserName = user.UserName
            };
        }
    }
}
