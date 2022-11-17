using BLL;
using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.convertion
{
    public class LessonConversion
    {
        public static LessonDTO Convert(Lesson obj)
        {
            if (obj == null)
                return null;
            return new LessonDTO()
            {
                Id = obj.Id
            };
        }
        public static Lesson Convert(LessonDTO obj)
        {
            if (obj == null)
                return null;
            return new Lesson()
            {
                Id = obj.Id
            };
        }
        public static List<Lesson> Convert(List<LessonDTO> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
        public static List<LessonDTO> Convert(List<Lesson> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
    }
}