using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class UserService
    {
        public static List<UserDTO> get()
        {
            return convertion.UserCovertion.Convert(new DAL.model.UserModel().Get());
        }

        public static UserDTO get(int id)
        {
            return convertion.UserCovertion.Convert(new DAL.model.UserModel().Get(id));
        }

        public static UserDTO get(string userName, string password)
        {
            return convertion.UserCovertion.Convert(new DAL.model.UserModel().Get(userName,password));
        }

        public static UserDTO Post(UserDTO user)
        {
            return convertion.UserCovertion.Convert(new DAL.model.UserModel().Post(convertion.UserCovertion.Convert(user)));
        }
        public static UserDTO Put(UserDTO user)
        {
            return convertion.UserCovertion.Convert(new DAL.model.UserModel().Put(convertion.UserCovertion.Convert(user)));
        }
        public static UserDTO Delete(UserDTO user)
        {
            //return convertion.userCovertion.Convert(new DAL.model.userModel().Delete(convertion.userCovertion.Convert(user)));
            return null;
        }
    }
}
