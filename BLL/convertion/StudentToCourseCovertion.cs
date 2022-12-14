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
        public static StudentToCourseDTO Convert(student_to_course obj)
        {
            if (obj == null)
                return null;
            return new StudentToCourseDTO()
            { 
                CourseId = obj.CourseId, 
                UserId = obj.UserId,
                Id=obj.Id
            };

        }

        public static List<StudentToCourseDTO> Convert(List<student_to_course> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static List<student_to_course> Convert(List<StudentToCourseDTO> obj)
        {
            return obj.Select(x => Convert(x)).ToList();
        }
        public static student_to_course Convert(StudentToCourseDTO obj)
        {
            if (obj == null)
                return null;
            return new student_to_course()
            {
                CourseId = obj.CourseId,
                UserId = obj.UserId,
                Id= obj.Id
            };
        }
    }
}