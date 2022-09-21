using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class UserModel
    {
        public List<User> Get()
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.User.ToList();
            }
        }

        public User Get(int id)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.User.FirstOrDefault(x => x.Id == id);
            }
        }

        public User Get(string userName, string password)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.User.FirstOrDefault(x => x.UserName == userName&&x.password==password);
            }
        }

        public User Post(User user)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                db.User.Add(user);
                db.SaveChanges();
                return user;
            }
        }

        public User Put(User user)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {

                User findUser = db.User.FirstOrDefault(x => x.Id == user.Id);
                findUser.FName = user.FName;
                findUser.Phone = user.Phone;
                findUser.Status = user.Status;
                findUser.UserName = user.UserName;
                db.SaveChanges();
                return findUser;
            }
        }
    }
}
