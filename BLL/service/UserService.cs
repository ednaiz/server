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
            return convertion.UserCovertion.Covert(new DAL.model.UserModel().Get());
        }

        public static UserDTO get(int id)
        {
            return convertion.UserCovertion.Covert(new DAL.model.UserModel().Get(id));
        }

        public static UserDTO get(string userName, string password)
        {
            return convertion.UserCovertion.Covert(new DAL.model.UserModel().Get(userName,password));
        }

        public static UserDTO Post(UserDTO user)
        {
            return convertion.UserCovertion.Covert(new DAL.model.UserModel().Post(convertion.UserCovertion.Covert(user)));
        }
        public static UserDTO Put(UserDTO user)
        {
            return convertion.UserCovertion.Covert(new DAL.model.UserModel().Put(convertion.UserCovertion.Covert(user)));
        }
        public static UserDTO Delete(UserDTO user)
        {
            //return convertion.userCovertion.Covert(new DAL.model.userModel().Delete(convertion.userCovertion.Covert(user)));
            return null;
        }
    }
}
