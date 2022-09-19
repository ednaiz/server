using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class LessonService
    {
      public static List<LessonDTO> get()
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Get());
        }public static LessonDTO get(int id)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Get(id));
        }

        public static LessonDTO get(string date string start, string finish)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Get(date,start,finish));
        }
        public static LessonDTO Post(LessonDTO Lesson)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Post(convertion.userCovertion.Covert(Lesson)));
        }
        public static LessonDTO Put(LessonDTO Lesson)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Put(convertion.userCovertion.Covert(Lesson)));
        }
        public static LessonDTO Delete(LessonDTO Lesson)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Delete(convertion.userCovertion.Covert(Lesson)));
        }
    }
}