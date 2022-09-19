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
      public static List<CourseDTO> get()
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Get());
        }public static CourseDTO get(int id)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Get(id));
        }
        public static CourseDTO get(string Name, int UserId, int NumOfLessons)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Get(Name, UserId, NumOfLessons));
        }
        public static CourseDTO Post(CourseDTO course)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Post(convertion.userCovertion.Covert(course)));
        }
        public static CourseDTO Put(CourseDTO course)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Put(convertion.userCovertion.Covert(Lesson)));
        }
        public static CourseDTO Delete(CourseDTO course)
        {
            return convertion.userCovertion.Covert(new DAL.model.userModel().Delete(convertion.userCovertion.Covert(course)));
        }
    }
}