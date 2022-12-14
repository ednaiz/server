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
        public static CourseDTO Convert(course obj)
        {
            if (obj == null)
                return null;
            return new CourseDTO()
            {
                Id=obj.Id,
                Name=obj.Name,
                TeacherId=obj.TeacherId,
                
            };
        }
        public static course Convert(CourseDTO obj)
        {
            if (obj == null)
                return null;
            return new course()
            {
                Id = obj.Id,
                Name = obj.Name,
                TeacherId = obj.TeacherId,
            };
        }
        public static List<course> Convert(List<CourseDTO> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
        public static List<CourseDTO> Convert(List<course> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
    }
}
