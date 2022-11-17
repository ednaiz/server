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
        public static UserDTO Convert(User user)
        {
            if (user == null)
                return null;
            return new UserDTO()
            {
                City = user.City,
                Email = user.Email,
                Id = user.Id,
                FName = user.FName,
                LName = user.LName,
                Address = user.Address,
                BDate = user.BDate,
                AllowingAccess = user.AllowingAccess,
                Password = user.Password,
                Phone = user.Phone,
                Status = user.Status,
                UserName = user.UserName
            };
        }
        public static List<UserDTO> Convert(List<User> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
        public static List<User> Convert(List<UserDTO> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
        public static User Convert(UserDTO user)
        {
            if (user == null)
                return null;
            return new User()
            {
                City = user.City,
                Email = user.Email,
                Id = user.Id,
                FName = user.FName,
                Password = user.Password,
                //Phone = user.Phone,
                Status = user.Status,
                UserName = user.UserName
            };
        }
    }
}
