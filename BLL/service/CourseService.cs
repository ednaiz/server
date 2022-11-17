using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class CourseService
    {
      public static List<CourseDTO> get()
        {
            return convertion.CourseConvertion.Convert(new DAL.model.CourseModel().Get());
        }
        public static CourseDTO get(int id)
        {
            return convertion.CourseConvertion.Convert(new DAL.model.CourseModel().Get(id));
        }
        public static CourseDTO get(string Name, int UserId, int NumOfLessons)
        {
            return convertion.CourseConvertion.Convert(new DAL.model.CourseModel().Get(Name, UserId, NumOfLessons));
        }
        public static CourseDTO Post(CourseDTO course)
        {
            return convertion.CourseConvertion.Convert(new DAL.model.CourseModel().Post(convertion.CourseConvertion.Convert(course)));
        }
        public static CourseDTO Put(CourseDTO course)
        {
            return convertion.CourseConvertion.Convert(new DAL.model.CourseModel().Put(convertion.CourseConvertion.Convert(course)));
        }
       
    }
}