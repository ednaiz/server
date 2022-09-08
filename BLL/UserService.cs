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
        public static List<UserDTOO> get()
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Get());
        }

        public static UserDTOO get(int id)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Get(id));
        }

        public static UserDTOO get(string userName, string password)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Get(userName,password));
        }

        public static UserDTOO Post(UserDTOO user)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Post(convertion.userCovertion.Covert(user)));
        }
        public static UserDTOO Put(UserDTOO user)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Put(convertion.userCovertion.Covert(user)));
        }
    }
}
