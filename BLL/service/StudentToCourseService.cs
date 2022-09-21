using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL.service
{
     public class StudentToCourseService
    {
        public static List<Lesson> get()
        {
            return convertion.StudentToCourseCovertion.Covert(new DAL.model.StudentToCourseModel().Get());
        }
        public static StudentToCourseDTO get(int id)
        {
            return convertion.StudentToCourseCovertion.Covert(new DAL.model.StudentToCourseModel().Get(id));
        }
        public static StudentToCourseDTO get(int CourseId, int UserId)
        {
            return convertion.StudentToCourseCovertion.Covert(new DAL.model.StudentToCourseModel().Get(CourseId, UserId));
        }

        public static StudentToCourseDTO Post(StudentToCourseDTO StudentToCourse)
        {
            return convertion.StudentToCourseCovertion.Covert(new DAL.model.StudentToCourseModel().Post(convertion.StudentToCourseCovertion.Covert(StudentToCourse)));
        }
        public static StudentToCourseDTO Put(StudentToCourseDTO StudentToCourse)
        {
            return convertion.StudentToCourseCovertion.Covert(new DAL.model.StudentToCourseModel().Put(convertion.StudentToCourseCovertion.Covert(StudentToCourse)));
        }
    }
}
