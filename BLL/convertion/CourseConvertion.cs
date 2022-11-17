using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convertion
{
   public class CourseConvertion
    {
        public static CourseDTO Convert(Course obj)
        {
            if (obj == null)
                return null;
            return new CourseDTO()
            {
                Id=obj.Id,
                Name=obj.Name,
                NumOfLessons=obj.NumOfLessons,
                UserId=obj.UserId
            };
        }
        public static Course Convert(CourseDTO obj)
        {
            if (obj == null)
                return null;
            return new Course()
            {
                Id = obj.Id,
                Name = obj.Name,
                NumOfLessons = obj.NumOfLessons,
                UserId = obj.UserId
            };
        }
        public static List<Course> Convert(List<CourseDTO> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
        public static List<CourseDTO> Convert(List<Course> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
    }
}
