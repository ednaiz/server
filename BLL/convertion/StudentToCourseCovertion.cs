using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL.convertion
{
    public class StudentToCourseCovertion
    {
        public static StudentToCourseDTO Convert(StudentToCourse student)
        {
            if (student == null)
                return null;
            return new StudentToCourseDTO()
            { 
                CourseId = student.CourseId, 
                UserId = student.UserId
            };

        }

        public static List<StudentToCourseDTO> Convert(List<StudentToCourse> student)
        {
            return student.Select(x => Convert(x)).ToList();
        }
        public static List<StudentToCourse> Convert(List<StudentToCourseDTO> student)
        {
            return student.Select(x => Convert(x)).ToList();
        }
        public static StudentToCourse Convert(StudentToCourseDTO student)
        {
            if (student == null)
                return null;
            return new StudentToCourse()
            {
                CourseId = student.CourseId,
                UserId = student.UserId
            };
        }
    }
}