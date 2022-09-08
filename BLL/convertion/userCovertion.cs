using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convertion
{
   public class userCovertion
    {
        public static UserDTOO Covert(User user)
        {
            if (user == null)
                return null;
            return new UserDTOO()
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
        public static List<UserDTOO> Covert(List<User> user)
        {
            return user.Select(x => Covert(x)).ToList();
        }
        public static List<User> Covert(List<UserDTOO> user)
        {
            return user.Select(x => Covert(x)).ToList();
        }
        public static User Covert(UserDTOO user)
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
