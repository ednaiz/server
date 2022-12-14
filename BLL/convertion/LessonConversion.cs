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
        public static LessonDTO Convert(lesson obj)
        {
            if (obj == null)
                return null;
            return new LessonDTO()
            {
                Id = obj.Id,
                CourseId=obj.CourseId,
                Date=obj.Date,
                EndTime=obj.EndTime,
                StartTime=obj.StartTime
            };
        }
        public static lesson Convert(LessonDTO obj)
        {
            if (obj == null)
                return null;
            return new lesson()
            {
                Id = obj.Id,
                CourseId = obj.CourseId,
                Date = obj.Date,
                EndTime = obj.EndTime,
                StartTime = obj.StartTime
            };
        }
        public static List<lesson> Convert(List<LessonDTO> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
        public static List<LessonDTO> Convert(List<lesson> user)
        {
            return user.Select(x => Convert(x)).ToList();
        }
    }
}