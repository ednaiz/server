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
            return convertion.LessonCovertion.Covert(new DAL.model.LessonModel().Get());
        }
        public static LessonDTO get(int id)
        {
            return convertion.LessonCovertion.Covert(new DAL.model.LessonModel().Get(id));
        }

        public static LessonDTO get(string date ,string start, string finish)
        {
            return convertion.LessonCovertion.Covert(new DAL.model.LessonModel().Get(date,start,finish));
        }
        public static LessonDTO Post(LessonDTO Lesson)
        {
            return convertion.LessonCovertion.Covert(new DAL.model.LessonModel().Post(convertion.LessonCovertion.Covert(Lesson)));
        }
        public static LessonDTO Put(LessonDTO Lesson)
        {
            return convertion.LessonCovertion.Covert(new DAL.model.LessonModel().Put(convertion.LessonCovertion.Covert(Lesson)));
        }


    }
}