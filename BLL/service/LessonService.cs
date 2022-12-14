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
            return convertion.LessonConversion.Convert(new DAL.model.LessonModel().Get());
        }
        public static LessonDTO get(int id)
        {
            return convertion.LessonConversion.Convert(new DAL.model.LessonModel().Get(id));
        }

        public static LessonDTO get(TimeSpan date ,TimeSpan start, DateTime finish)
        {
            return convertion.LessonConversion.Convert(new DAL.model.LessonModel().Get(date,start,finish));
        }
        public static LessonDTO Post(LessonDTO Lesson)
        {
            return convertion.LessonConversion.Convert(new DAL.model.LessonModel().Post(convertion.LessonConversion.Convert(Lesson)));
        }
        public static LessonDTO Put(LessonDTO Lesson)
        {
            return convertion.LessonConversion.Convert(new DAL.model.LessonModel().Put(convertion.LessonConversion.Convert(Lesson)));
        }


    }
}