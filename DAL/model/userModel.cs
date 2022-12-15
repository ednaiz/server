using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.model
{
    public class UserModel
    {
        public List<user> Get()
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.user.ToList();
            }
        }

        public user Get(int id)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.user.FirstOrDefault(x => x.Id == id);
            }
        }
       
        public user Get(string userName, string password)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                return db.user.FirstOrDefault(x => x.UserName == userName&&x.Password==password);
            }
        }

        public user Post(user user)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {
                db.user.Add(user);
                db.SaveChanges();
                return user;
            }
        }

        public user Put(user user)
        {
            using (OnSpotEntities db = new OnSpotEntities())
            {

                user findUser = db.user.FirstOrDefault(x => x.Id == user.Id);
                findUser.Active = user.Active;
                findUser.Email = user.Email;
                findUser.Name = user.Name;
                findUser.Password = user.Password;
                findUser.Phone = user.Phone;
                findUser.Type = user.Type;
                findUser.UserName = user.UserName;
              
                db.SaveChanges();
                return findUser;
            }
        }
    }
}
