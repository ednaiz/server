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
        public static CourseDTO Covert(Course obj)
        {
            if (obj == null)
                return null;
            return new CourseDTO()
            {
                Id=obj.Id
            };
        }
        public static Course Covert(CourseDTO obj)
        {
            if (obj == null)
                return null;
            return new Course()
            {
                Id = obj.Id
            };
        }
        public static List<Course> Covert(List<CourseDTO> user)
        {
            return user.Select(x => Covert(x)).ToList();
        }
        public static List<CourseDTO> Covert(List<Course> user)
        {
            return user.Select(x => Covert(x)).ToList();
        }
    }
}
